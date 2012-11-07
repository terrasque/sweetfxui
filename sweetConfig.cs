using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public class sweetConfig
    {
        public class FXSetting
        {
            public interface FXcontrol
            {
                void init(System.Windows.Forms.Panel panel, FXSetting setting);
                void removeInput();
                void createInput();
            }

            public abstract class BaseControl: FXcontrol {
                public System.Windows.Forms.Panel panel;
                public FXSetting parent;

                public static System.Drawing.Point controlPosition = new System.Drawing.Point(6, 53);

                public void init(System.Windows.Forms.Panel p, FXSetting parent) {
                    panel = p;
                    this.parent = parent;
                }


                public abstract void removeInput();
                public abstract void createInput();

            }

            public class TextControl: BaseControl {
                System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                
                public void handleTextInput(object sender, System.EventArgs e)
                {
                    if (textBox1 != null && textBox1.Text != "")
                    {
                        parent.setValue(textBox1.Text);
                    }
                 }

                public override void createInput()
                {
                    textBox1.Location = controlPosition;
                    textBox1.Size = new System.Drawing.Size(181, 20);
                    textBox1.TextChanged += new System.EventHandler(this.handleTextInput);
                    textBox1.Text = parent.value;
                    panel.Controls.Add(textBox1);
                }

                public override void removeInput()
                {
                    textBox1.Dispose();
                }
            }

            public class BoolControl : BaseControl
            {
                System.Windows.Forms.CheckBox box = new System.Windows.Forms.CheckBox();

                public void handleBoolInput(object sender, System.EventArgs e)
                {
                    if (box != null)
                    {
                        parent.setValue(box.Checked ? "1" : "0");
                    }
                }

                public override void createInput()
                {
                    box.Location = controlPosition;
                    box.Size = new System.Drawing.Size(181, 20);
                    box.CheckedChanged += new System.EventHandler(this.handleBoolInput);
                    box.Checked = parent.value == "1";
                    box.Text = "Setting enabled";
                    panel.Controls.Add(box);
                }

                public override void removeInput()
                {
                    box.Dispose();
                }
            }

            public class IntControl : BaseControl
            {
                System.Windows.Forms.TrackBar tracker = new System.Windows.Forms.TrackBar();
                System.Windows.Forms.NumericUpDown numeral = new System.Windows.Forms.NumericUpDown();

                static public Regex intRx = new Regex(@"^([0-9]+)\s+to\s+([0-9]+)$");
                private Match match;

                public override void createInput()
                {
                    int width = 380;
                    this.match = IntControl.intRx.Match(parent.limit);
                    System.Drawing.Point tempcp = new System.Drawing.Point(controlPosition.X + width + 5, controlPosition.Y);
                    tracker.Location = controlPosition;
                    numeral.Location = tempcp;
                    tracker.Size = new System.Drawing.Size(width, 10);
                    numeral.Size = new System.Drawing.Size(40, 20);

                    tracker.Maximum = Convert.ToInt32(match.Groups[2].Value);
                    numeral.Maximum = Convert.ToInt32(match.Groups[2].Value);
                    tracker.Minimum = Convert.ToInt32(match.Groups[1].Value);
                    numeral.Minimum = Convert.ToInt32(match.Groups[1].Value);

                    tracker.ValueChanged += new System.EventHandler(this.handleTrackerInput);
                    numeral.ValueChanged += new System.EventHandler(this.handleNumeralInput);
                    panel.Controls.Add(tracker);
                    panel.Controls.Add(numeral);
                    tracker.BringToFront();
                    numeral.DecimalPlaces = 0;

                    updateValue(Convert.ToInt32(parent.value));
                }

                private void handleTrackerInput(object sender, System.EventArgs e)
                {
                    updateValue(tracker.Value);
                }

                private void handleNumeralInput(object sender, System.EventArgs e)
                {
                    updateValue(Convert.ToInt32(numeral.Value));
                }

                public void updateValue(int value)
                {
                    tracker.Value = value;
                    numeral.Value = value;
                    parent.setValue(value.ToString());
                }

                public override void removeInput()
                {
                    tracker.Dispose();
                    numeral.Dispose();
                }
            }

            public class SelectControl : BaseControl
            {
                System.Windows.Forms.ComboBox box = new System.Windows.Forms.ComboBox();

                public void handleInput(object sender, System.EventArgs e)
                {
                    if (box != null)
                    {
                        parent.setValue((String)box.SelectedItem);
                    }
                }

                public override void createInput()
                {
                    box.Location = controlPosition;
                    box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    box.Size = new System.Drawing.Size(181, 20);
                    box.SelectedIndexChanged += new System.EventHandler(this.handleInput);
                    List<String> selection = parent.limit.Split('|').ToList<String>();
                    box.DataSource = selection;
                    box.Text = "Setting enabled";
                    panel.Controls.Add(box);
                    box.SelectedIndex = selection.IndexOf(parent.value);
                }

                public override void removeInput()
                {
                    box.Dispose();
                }
            }

            public class Float3Control : BaseControl
            {
                System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
                System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();

                static public Regex f3Rx = new Regex(@"^float3\s*\(\s*([0-9\.]+)\s*,\s*([0-9\.]+)\s*,\s*([0-9\.]+)\s*\)$");
                private Match match;

                public override void createInput()
                {
                    match = f3Rx.Match(parent.value);

                    textBox1.Location = controlPosition;
                    textBox1.Size = new System.Drawing.Size(60, 20);
                    textBox1.TextChanged += new System.EventHandler(this.handleTextInput);
                    textBox1.Text = match.Groups[1].Value;
                    panel.Controls.Add(textBox1);

                    textBox2.Location = new System.Drawing.Point(controlPosition.X + 60, controlPosition.Y);
                    textBox2.Size = new System.Drawing.Size(60, 20);
                    textBox2.TextChanged += new System.EventHandler(this.handleTextInput);
                    textBox2.Text = match.Groups[2].Value;
                    panel.Controls.Add(textBox2);

                    textBox3.Location = new System.Drawing.Point(controlPosition.X + 120, controlPosition.Y);
                    textBox3.Size = new System.Drawing.Size(60, 20);
                    textBox3.TextChanged += new System.EventHandler(this.handleTextInput);
                    textBox3.Text = match.Groups[3].Value;
                    panel.Controls.Add(textBox3);
                }

                public void handleTextInput(object sender, System.EventArgs e)
                {
                    if (textBox1 != null && textBox1.Text != "")
                    {
                        String s = string.Format("float3({0}, {1}, {2})", textBox1.Text, textBox2.Text, textBox3.Text);
                        parent.setValue(s);
                    }
                }

                public override void removeInput()
                {
                    textBox1.Dispose();
                    textBox2.Dispose();
                    textBox3.Dispose();
                }

            }

            public FXSetting parent = null;
            public String name;
            public String value;
            public String origValue;
            public String comment;
            public String limit;
            public FXcontrol control;
            public sweetConfig controller;

            public List<FXSetting> children = new List<FXSetting>();

            public void addInput(System.Windows.Forms.Panel form)
            {
                if (limit == "0 or 1")
                {
                    control = new BoolControl();
                }
                else if (limit.Contains("|")) {
                    control = new SelectControl();
                }
                else if (IntControl.intRx.Match(limit).Success)
                {
                    control = new IntControl();
                } else if (Float3Control.f3Rx.Match(value).Success) {
                    control = new Float3Control();
                } else
                {
                    control = new TextControl();
                }
                control.init(form, this);
                control.createInput();
            }

            public void addChild(FXSetting child)
            {
                children.Add(child);
            }

            public void removeInput()
            {
                control.removeInput();
            }

            public FXSetting(Match match, FXSetting parent, sweetConfig controller)
            {
                name = match.Groups[1].Value;
                value = match.Groups[2].Value;
                origValue = match.Groups[2].Value;
                limit = match.Groups[3].Value;
                comment = match.Groups[4].Value;
                this.parent = parent;
                this.controller = controller;
                controller.byName.Add(name, this);
                if (parent != null) parent.addChild(this);
            }

            public override string ToString()
            {
                if (parent != null) return name + " : " + comment;

                return comment;
            }

            internal string formatLine()
            {
                return "#define " + name.PadRight(22) + " " + value.PadRight(12) + " // [" + limit + "] " + comment;
            }


            internal void valueChanged()
            {
                if (controller != null) controller.settingsChanged();
            }

            internal void setValue(string p)
            {
                this.value = p;
                valueChanged();
            }
        }
        String filePath;

        public List<FXSetting> FXSettings = new List<FXSetting>();
        public List<FXSetting> categories = new List<FXSetting>();

        static Regex settingMatcher = new Regex(@"#define\s+([A-Za-z0-9_]+)\s+(.+?)\s+//\s*\[(.*?)\]\s*(.*)");
        static Regex settingGroupMatcher = new Regex(@"\s*/\s+(.*?) settings");

        public bool autoSave = false;

        public enum configVersions {OLD, v13};

        public configVersions configVersion = configVersions.OLD;

        public Dictionary<String, FXSetting> byName = new Dictionary<String,FXSetting>();

        public bool isClone = false;

        public sweetConfig(String file)
        {
            if (File.Exists(file))
            {
                filePath = file;
                parseConfig();
            }
        }

        public FXSetting[] diffConfig(sweetConfig otherConfig)
        {
            List<FXSetting> bla = new List<FXSetting>();
            foreach (FXSetting s in otherConfig.FXSettings)
            {
                if (!byName.ContainsKey(s.name) || byName[s.name].value != s.value) {
                    if (byName[s.name].parent == null || byName[s.name].parent.value == "1")
                    {
                        bla.Add(byName[s.name]);
                    }
                }
            }
            return bla.ToArray();
        }

        public void writeConfig()
        {
            if (isClone)
            {
                //Disable writing file if marked as clone
                return;
            }

            string[] lines = System.IO.File.ReadAllLines(filePath);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath + ".temp"))
            {
                foreach (String l in lines)
                {
                    Match m = settingMatcher.Match(l);
                    if (m.Success)
                    {
                        file.WriteLine(byName[m.Groups[1].Value].formatLine());
                    }
                    else
                    {
                        file.WriteLine(l);
                    }
                }
            }
            File.Copy(filePath, filePath + ".orig", true);
            File.Copy(filePath + ".temp", filePath, true);
            File.Delete(filePath + ".temp");
        }

        public sweetConfig clone()
        {
            sweetConfig clone = new sweetConfig(this.filePath);
            clone.isClone = true;
            return clone;
        }

        private void parseConfig()
        {
            logger.info("Processing config file " + filePath);
            string[] lines = System.IO.File.ReadAllLines(filePath);
            FXSetting parent = null;
            foreach (string l in lines)
            {
                Match m = settingMatcher.Match(l);
                if (m.Success)
                {
                    FXSettings.Add(new FXSetting(m, parent, this));
                }
                else
                {
                    Match m2 = settingGroupMatcher.Match(l);
                    if (m2.Success)
                    {
                        String groupname = m2.Groups[1].Value;
                        foreach (FXSetting fxp in FXSettings)
                        {
                            if (fxp.comment.StartsWith(groupname))
                            {
                                parent = fxp;
                                break;
                            }
                        }
                    }
                    else
                    {
                        logger.debug("Could not decode : " + l);
                    }
                }
            }

            // USE_SPLITSCREEN was added in v1.3
            if (byName.ContainsKey("USE_SPLITSCREEN"))
            {
                configVersion = configVersions.v13;
            }
        }

        internal void settingsChanged()
        {
            if (autoSave)
            {
                writeConfig();
            }
        }

        internal void loadPreset(configPreset preset)
        {
            foreach (FXSetting s in FXSettings)
            {
                if (preset.haveSetting(s.name))
                {
                    s.value = preset.getValueOf(s.name);
                }
            }
        }
    }
}
