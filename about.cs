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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void about_Load(object sender, EventArgs e)
        {
            versionLabel.Text = "Version " + Form1.VERSION;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forums.guru3d.com/showthread.php?t=368880");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(
                System.IO.Path.Combine(Form1.sweetfx_folder, "SweetFX readme.txt")
            );
        }
    }
}
