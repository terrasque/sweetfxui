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
    public partial class Form2 : Form
    {
        gameEntry activeGame;
        static List<String> smaa_settings = new List<String>(new String[] { "SMAA_PRESET_CUSTOM", "SMAA_PRESET_LOW", "SMAA_PRESET_MEDIUM", "SMAA_PRESET_HIGH", "SMAA_PRESET_ULTRA"});
        bool initDone = false;

        public Form2(gameEntry activeGame)
        {
            InitializeComponent();
            this.activeGame = activeGame;
            setupInjectorData();
            this.Text = "Injector - " + activeGame.shortName;
            initDone = true;
        }

        private String getKeyName(String nr) {
            System.Windows.Forms.KeysConverter kc = new System.Windows.Forms.KeysConverter();
            return kc.ConvertToString(Convert.ToInt32(nr));
        }

        private void setupInjectorData()
        {
            smaaSetting.DataSource = smaa_settings;
            String bla = activeGame.injectordata.parsedData["smaa"]["preset"];
            smaaSetting.SelectedIndex = smaa_settings.IndexOf(bla);

            checkBox1.Checked = activeGame.injectordata.parsedData["misc"]["weird_steam_hack"] == "1";

            ti_toggle.Text = activeGame.injectordata.parsedData["injector"]["key_toggle"];
            ti_screen.Text = activeGame.injectordata.parsedData["injector"]["key_screenshot"];
            ti_reload.Text = activeGame.injectordata.parsedData["injector"]["key_reload"];
            i_toggle.Text = getKeyName(ti_toggle.Text);
            i_screen.Text = getKeyName(ti_screen.Text);
            i_reload.Text = getKeyName(ti_reload.Text);
        }

        private void ti_toggle_KeyDown(object sender, KeyEventArgs e)
        {
            ti_keydown(e, ti_toggle, "key_toggle");
        }

        private void ti_screen_KeyDown(object sender, KeyEventArgs e)
        {
            ti_keydown(e, ti_screen, "key_screenshot");
        }

        private void ti_reload_KeyDown(object sender, KeyEventArgs e)
        {
            ti_keydown(e, ti_reload, "key_reload");
        }

        private void ti_keydown(KeyEventArgs e, TextBox bla, String key)
        {
            bla.Text = ((int)e.KeyCode).ToString();
            e.SuppressKeyPress = true;
            activeGame.injectordata.parsedData["injector"][key] = bla.Text;
            setupInjectorData();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            activeGame.injectordata.writeIni();
            this.Dispose();
        }

        private void smaaSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initDone)
            {
                string bla = smaa_settings.ElementAt(smaaSetting.SelectedIndex);
                activeGame.injectordata.parsedData["smaa"]["preset"] = bla;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            activeGame.injectordata.parsedData["misc"]["weird_steam_hack"] = checkBox1.Checked ? "1" : "0";
        }
    }
}
