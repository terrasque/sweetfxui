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
    public partial class listPresets : Form
    {
        gameEntry game;
        configPreset activePreset;
        Form1 parent;

        public listPresets(gameEntry game, Form1 parentForm)
        {
            InitializeComponent();
            this.game = game;
            parent = parentForm;
            this.Text = "Presets for " + game.shortName;
        }

        private void listPresets_Load(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void refreshUI()
        {
            presetList.DataSource = null;
            presetList.DataSource = game.presets;

            if (presetList.SelectedIndex != -1)
            {
                configPreset preset = game.presets.ElementAt(presetList.SelectedIndex);
                sweetConfig clone = game.Config.clone();
                clone.loadPreset(preset);
                textBox2.Lines = showDiff.formatChanges(clone.diffConfig(game.Config), true);
                activePreset = preset;
            }
            else
            {
                activePreset = null;
            }
            button5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                game.createPreset(textBox1.Text);
                refreshUI();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (activePreset != null)
            {
                game.deletePreset(activePreset);
                refreshUI();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (activePreset != null)
            {
                game.loadPreset(activePreset);
                game.Config.settingsChanged();
                parent.refreshUI();
                refreshUI();
            }
        }

        private void presetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshUI();
        }

        private void presetList_DoubleClick(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (activePreset != null)
            {
                activePreset.updateFromConfig(game.Config);
                refreshUI();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (activePreset != null)
            {
                button5.Visible = false;
                textBox3.Text = activePreset.name;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                activePreset.name = textBox3.Text;
                activePreset.savePreset();
            }
            refreshUI();
        }
    }
}
