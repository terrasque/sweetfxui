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
    public partial class showDiff : Form
    {
        sweetConfig conf1;
        sweetConfig orig;
        public showDiff(sweetConfig conf1, sweetConfig orig)
        {
            InitializeComponent();
            this.conf1 = conf1;
            this.orig = orig;            
        }

        public static String[] formatChanges(sweetConfig.FXSetting[] s, bool showCompact)
        {
            List<String> changes = new List<string>();
            foreach (WindowsFormsApplication1.sweetConfig.FXSetting entry in s)
            {
                if (showCompact)
                {
                    String temp = entry.name + " = " + entry.value;
                    if (entry.parent != null) temp = temp.PadRight(34) + "// " + entry.parent.name;
                    changes.Add(temp);
                }
                else changes.Add(entry.formatLine());
            }
            return changes.ToArray();
        }

        private void displayChanges()
        {
            WindowsFormsApplication1.sweetConfig.FXSetting[] s = conf1.diffConfig(orig);
            textBox1.Lines = formatChanges(s, compact.Checked);
        }

        private void showDiff_Load(object sender, EventArgs e)
        {
            displayChanges();
        }

        private void compact_CheckedChanged(object sender, EventArgs e)
        {
            displayChanges();
        }
    }
}
