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
    public partial class gameData : Form
    {
        gameEntry entry;
        private Form1 parent;

        public gameData(gameEntry entry, Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.entry = entry;
            gameName.Text = entry.shortName;
            gameArgs.Text = entry.runArgs;
            specialInstall.Checked = entry.special_install;
            this.Text = entry.shortName + " settings";
            path.Text = entry.path;
            specialpath.Text = entry.special_subfolder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entry.runArgs = gameArgs.Text;
            entry.shortName = gameName.Text;
            entry.special_install = specialInstall.Checked;
            entry.special_subfolder = specialpath.Text;

            parent.settings.saveSettings();
            parent.refreshUI();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(entry.folder);
        }

    }
}
