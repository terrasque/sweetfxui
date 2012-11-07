using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public storage settings;
        public static gameEntry activeGame = null;
        public static String sweetfx_folder;
        List<sweetConfig.FXSetting> cats = new List<sweetConfig.FXSetting>();
        List<sweetConfig.FXSetting> options = new List<sweetConfig.FXSetting>();
        sweetConfig.FXSetting activeSetting = null;

        public static string VERSION = "1.3.2";

        public static string sweetfxFolderName = "SweetFX";

        public Form1()
        {
            InitializeComponent();
            string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
            logger.setLogfile(System.IO.Path.Combine(baseFolder, "configurator.log"));
            settings = new storage(System.IO.Path.Combine(baseFolder, "configurator.ini"));
            String oldSettings = System.IO.Path.Combine(baseFolder, "games.txt");
            if (System.IO.File.Exists(oldSettings)) {
                settings.loadGamesFromFile(oldSettings);
                settings.saveSettings();
                System.IO.File.Delete(oldSettings);
            }
            refreshUI();

            versionInfo.Text = "SweetFX Configurator v"+ VERSION;

            sweetfx_folder = System.IO.Path.Combine(baseFolder, sweetfxFolderName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openGameExe.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                String file = openGameExe.FileName;
                addGame(file);
            }
        }

        private void addGame(String path)
        {
            settings.addGame(path);
            refreshUI();
        }

        public void refreshUI ()
        {
            gamesList.DataSource = null;
            gamesList.DataSource = settings.games;

            activeGroups.DataSource = null;
            detailList.DataSource = null;
            optionPanel.Visible = false;
            injectorSetup.Enabled = false;
            categoryDescription.Text = "";

            if (activeGame != null)
            {
                if (activeGame.Config != null)
                {
                    button8.Enabled = true;
                    button7.Enabled = true;
                    optionPanel.Visible = true;
                    cats.Clear();
                    foreach (sweetConfig.FXSetting fxs in activeGame.Config.FXSettings)
                    {
                        if (fxs.parent == null) cats.Add(fxs);
                    }
                    activeGroups.DataSource = cats;
                    for (int i = 0; i < cats.Count; i++)
                    {
                        if (cats.ElementAt(i).value == "1") activeGroups.SetItemChecked(i, true);
                    }
                }
                else
                {
                    button8.Enabled = false;
                    button7.Enabled = false;
                }

                if (activeGame.injectordata != null)
                {
                    injectorSetup.Enabled = true;
                }
            }
            else
            {
                label2.Text = "No game selected";
            }
        }

        private void gamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gamesList.SelectedIndex != -1) {
                activeGame = settings.games.ElementAt(gamesList.SelectedIndex);
                label2.Text = activeGame.shortName;
                toolTip1.SetToolTip(label2, activeGame.path);
                installFXbutton.Visible = !activeGame.isActivated;
                if (activeGame.Config != null) autoSave.Checked = activeGame.Config.autoSave;
                refreshUI();
            }
        }

        private void installFXbutton_Click(object sender, EventArgs e)
        {
            if (activeGame != null)
            {
                if (activeGame.hasWriteAccessToFolder())
                {
                    activeGame.installSweetFX();
                    refreshUI();
                }
                else
                {
                    MessageBox.Show("Can not write to folder - No access\nMight need to run the SweetFX Configurator as Administrator");
                }
            }
        }

        private void activeGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activeGroups.SelectedIndex != -1)
            {
                sweetConfig.FXSetting activeCAt = cats.ElementAt(activeGroups.SelectedIndex);
                detailList.DataSource = null;
                options = activeCAt.children;
                try
                {
                    categoryDescription.Text = activeCAt.comment.Split(':')[1].TrimStart();
                }
                catch (Exception)
                {
                    categoryDescription.Text = "No description.. Old config file?";
                }
                detailList.DataSource = options;
            }
        }

        private void detailList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detailList.SelectedIndex != -1)
            {
                if (activeSetting != null)
                {
                    activeSetting.removeInput();
                }
                activeSetting = options.ElementAt(detailList.SelectedIndex);
                label5.Text = activeSetting.comment;
                optionLabel.Text = activeSetting.name + " [" + activeSetting.origValue + "]";
                label6.Text = "Values : " + activeSetting.limit;
                textBox1.Text = activeSetting.value;
                activeSetting.addInput(optionPanel);
            }
        }

        private void activeGroups_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                cats.ElementAt(e.Index).setValue("1");
            }
            else
            {
                cats.ElementAt(e.Index).setValue("0");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activeGame.Config.writeConfig();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            activeSetting.value = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (activeGame != null)
            {
                settings.removeGame(activeGame);
                activeGame = null;
                refreshUI();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (activeGame != null)
            {
                activeGame.launchGame();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            activeGame.Config.autoSave = autoSave.Checked;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (activeGame != null && activeGame.injectordata != null)
            {
                Form2 fooform = new Form2(activeGame);
                fooform.Show();
            }
        }

        private void remove_sweetfx_Click(object sender, EventArgs e)
        {
            if (activeGame != null)
            {
                activeGame.removeSweetFX();
                refreshUI();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (activeGame != null)
            {
                sweetConfig defaultConfig = new sweetConfig(System.IO.Path.Combine(sweetfx_folder, "SweetFX_settings.txt"));
                new showDiff(activeGame.Config, defaultConfig).Show();
            }
        }

        private void gamesList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (file.ToLower().EndsWith(".exe"))
                {
                    settings.addGame(file);
                }
            }
            refreshUI();
        }

        private void gamesList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new listPresets(activeGame, this).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new about().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (activeGame != null) new gameData(activeGame, this).Show();
        }

    }
}
