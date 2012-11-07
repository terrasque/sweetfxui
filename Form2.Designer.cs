namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ti_reload = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ti_screen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ti_toggle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.i_toggle = new System.Windows.Forms.Label();
            this.i_screen = new System.Windows.Forms.Label();
            this.i_reload = new System.Windows.Forms.Label();
            this.smaaSetting = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.smaaSetting);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 312);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Injector settings";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 276);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(245, 30);
            this.button7.TabIndex = 2;
            this.button7.Text = "Save settings";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.i_reload);
            this.groupBox2.Controls.Add(this.i_screen);
            this.groupBox2.Controls.Add(this.i_toggle);
            this.groupBox2.Controls.Add(this.ti_reload);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ti_screen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ti_toggle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key bindings";
            // 
            // ti_reload
            // 
            this.ti_reload.Location = new System.Drawing.Point(125, 71);
            this.ti_reload.Name = "ti_reload";
            this.ti_reload.Size = new System.Drawing.Size(36, 20);
            this.ti_reload.TabIndex = 5;
            this.ti_reload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ti_reload_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Reload settings";
            // 
            // ti_screen
            // 
            this.ti_screen.Location = new System.Drawing.Point(125, 47);
            this.ti_screen.Name = "ti_screen";
            this.ti_screen.Size = new System.Drawing.Size(36, 20);
            this.ti_screen.TabIndex = 3;
            this.ti_screen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ti_screen_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Save screenshot";
            this.toolTip1.SetToolTip(this.label8, "Will save a .bmp image in the game\'s folder");
            // 
            // ti_toggle
            // 
            this.ti_toggle.Location = new System.Drawing.Point(125, 20);
            this.ti_toggle.Name = "ti_toggle";
            this.ti_toggle.Size = new System.Drawing.Size(36, 20);
            this.ti_toggle.TabIndex = 1;
            this.ti_toggle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ti_toggle_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Toggle effects on / off";
            // 
            // i_toggle
            // 
            this.i_toggle.AutoSize = true;
            this.i_toggle.Location = new System.Drawing.Point(167, 23);
            this.i_toggle.Name = "i_toggle";
            this.i_toggle.Size = new System.Drawing.Size(35, 13);
            this.i_toggle.TabIndex = 6;
            this.i_toggle.Text = "label1";
            // 
            // i_screen
            // 
            this.i_screen.AutoSize = true;
            this.i_screen.Location = new System.Drawing.Point(167, 50);
            this.i_screen.Name = "i_screen";
            this.i_screen.Size = new System.Drawing.Size(35, 13);
            this.i_screen.TabIndex = 7;
            this.i_screen.Text = "label1";
            // 
            // i_reload
            // 
            this.i_reload.AutoSize = true;
            this.i_reload.Location = new System.Drawing.Point(167, 74);
            this.i_reload.Name = "i_reload";
            this.i_reload.Size = new System.Drawing.Size(35, 13);
            this.i_reload.TabIndex = 8;
            this.i_reload.Text = "label1";
            // 
            // smaaSetting
            // 
            this.smaaSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smaaSetting.FormattingEnabled = true;
            this.smaaSetting.Location = new System.Drawing.Point(88, 158);
            this.smaaSetting.Name = "smaaSetting";
            this.smaaSetting.Size = new System.Drawing.Size(157, 21);
            this.smaaSetting.TabIndex = 3;
            this.smaaSetting.SelectedIndexChanged += new System.EventHandler(this.smaaSetting_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SMAA Preset :";
            this.toolTip1.SetToolTip(this.label1, "SMAA preset to use. Default is \"SMAA_PRESET_CUSTOM\" - which allows for custom set" +
                    "tings");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable Steam overlay compatibility hack";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note: For changes done in here to take effect, the game usually needs to be resta" +
                "rted.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ti_reload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ti_screen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ti_toggle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label i_reload;
        private System.Windows.Forms.Label i_screen;
        private System.Windows.Forms.Label i_toggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox smaaSetting;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}