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
    public partial class importPresetForm : Form
    {
        private gameEntry game;

        public importPresetForm(gameEntry target)
        {
            InitializeComponent();
            this.game = target;
        }

        private void importPresetForm_Load(object sender, EventArgs e)
        {

        }
    }
}
