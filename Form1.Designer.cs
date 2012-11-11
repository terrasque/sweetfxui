namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gamesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detailList = new System.Windows.Forms.ListBox();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.autoSave = new System.Windows.Forms.CheckBox();
            this.optionLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.categoryDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activeGroups = new System.Windows.Forms.CheckedListBox();
            this.injectorSetup = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.installFXbutton = new System.Windows.Forms.Button();
            this.remove_sweetfx = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openGameExe = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.versionInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesList
            // 
            this.gamesList.AllowDrop = true;
            this.gamesList.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesList.FormattingEnabled = true;
            this.gamesList.ItemHeight = 14;
            this.gamesList.Location = new System.Drawing.Point(12, 29);
            this.gamesList.Name = "gamesList";
            this.gamesList.ScrollAlwaysVisible = true;
            this.gamesList.Size = new System.Drawing.Size(254, 466);
            this.gamesList.TabIndex = 0;
            this.gamesList.SelectedIndexChanged += new System.EventHandler(this.gamesList_SelectedIndexChanged);
            this.gamesList.DragDrop += new System.Windows.Forms.DragEventHandler(this.gamesList_DragDrop);
            this.gamesList.DragEnter += new System.Windows.Forms.DragEventHandler(this.gamesList_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game list";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.detailList);
            this.panel1.Controls.Add(this.optionPanel);
            this.panel1.Controls.Add(this.categoryDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.activeGroups);
            this.panel1.Location = new System.Drawing.Point(284, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 531);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Settings displayed for:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categories";
            // 
            // detailList
            // 
            this.detailList.FormattingEnabled = true;
            this.detailList.Location = new System.Drawing.Point(0, 305);
            this.detailList.Name = "detailList";
            this.detailList.Size = new System.Drawing.Size(589, 95);
            this.detailList.TabIndex = 4;
            this.detailList.SelectedIndexChanged += new System.EventHandler(this.detailList_SelectedIndexChanged);
            // 
            // optionPanel
            // 
            this.optionPanel.Controls.Add(this.label6);
            this.optionPanel.Controls.Add(this.label5);
            this.optionPanel.Controls.Add(this.textBox1);
            this.optionPanel.Controls.Add(this.autoSave);
            this.optionPanel.Controls.Add(this.optionLabel);
            this.optionPanel.Controls.Add(this.button2);
            this.optionPanel.Location = new System.Drawing.Point(0, 398);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(589, 127);
            this.optionPanel.TabIndex = 3;
            this.optionPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Values :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 28);
            this.label5.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // autoSave
            // 
            this.autoSave.AutoSize = true;
            this.autoSave.Location = new System.Drawing.Point(385, 103);
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(173, 17);
            this.autoSave.TabIndex = 5;
            this.autoSave.Text = "Automatically save on changes";
            this.autoSave.UseVisualStyleBackColor = true;
            this.autoSave.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel.Location = new System.Drawing.Point(3, 5);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(108, 13);
            this.optionLabel.TabIndex = 0;
            this.optionLabel.Text = "Select an option..";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save new config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryDescription
            // 
            this.categoryDescription.Location = new System.Drawing.Point(0, 256);
            this.categoryDescription.Name = "categoryDescription";
            this.categoryDescription.Size = new System.Drawing.Size(586, 33);
            this.categoryDescription.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No game selected";
            // 
            // activeGroups
            // 
            this.activeGroups.FormattingEnabled = true;
            this.activeGroups.Location = new System.Drawing.Point(0, 41);
            this.activeGroups.Name = "activeGroups";
            this.activeGroups.Size = new System.Drawing.Size(589, 214);
            this.activeGroups.TabIndex = 0;
            this.activeGroups.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.activeGroups_ItemCheck);
            this.activeGroups.SelectedIndexChanged += new System.EventHandler(this.activeGroups_SelectedIndexChanged);
            // 
            // injectorSetup
            // 
            this.injectorSetup.Enabled = false;
            this.injectorSetup.Location = new System.Drawing.Point(6, 107);
            this.injectorSetup.Name = "injectorSetup";
            this.injectorSetup.Size = new System.Drawing.Size(148, 27);
            this.injectorSetup.TabIndex = 8;
            this.injectorSetup.Text = "SweetFX Injector settings";
            this.injectorSetup.UseVisualStyleBackColor = true;
            this.injectorSetup.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Launch selected game";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 305);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 46);
            this.button8.TabIndex = 5;
            this.button8.Text = "Save / load configuration";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 357);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 45);
            this.button7.TabIndex = 4;
            this.button7.Text = "List changes from default";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // installFXbutton
            // 
            this.installFXbutton.Location = new System.Drawing.Point(6, 74);
            this.installFXbutton.Name = "installFXbutton";
            this.installFXbutton.Size = new System.Drawing.Size(148, 27);
            this.installFXbutton.TabIndex = 2;
            this.installFXbutton.TabStop = false;
            this.installFXbutton.Text = "Add SweetFX";
            this.installFXbutton.UseVisualStyleBackColor = true;
            this.installFXbutton.Visible = false;
            this.installFXbutton.Click += new System.EventHandler(this.installFXbutton_Click);
            // 
            // remove_sweetfx
            // 
            this.remove_sweetfx.Location = new System.Drawing.Point(6, 74);
            this.remove_sweetfx.Name = "remove_sweetfx";
            this.remove_sweetfx.Size = new System.Drawing.Size(148, 27);
            this.remove_sweetfx.TabIndex = 9;
            this.remove_sweetfx.Text = "Remove SweetFX";
            this.toolTip1.SetToolTip(this.remove_sweetfx, "Will not remove the settings");
            this.remove_sweetfx.UseVisualStyleBackColor = true;
            this.remove_sweetfx.Click += new System.EventHandler(this.remove_sweetfx_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add new game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openGameExe
            // 
            this.openGameExe.Filter = "Exe files|*.exe";
            this.openGameExe.Title = "Open game exe file";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.versionInfo);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.injectorSetup);
            this.groupBox1.Controls.Add(this.installFXbutton);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.remove_sweetfx);
            this.groupBox1.Location = new System.Drawing.Point(897, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 525);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Misc";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 228);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 27);
            this.button10.TabIndex = 15;
            this.button10.Text = "Game settings";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button9.Location = new System.Drawing.Point(6, 480);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 22);
            this.button9.TabIndex = 14;
            this.button9.Text = "About / Help";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // versionInfo
            // 
            this.versionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.versionInfo.Location = new System.Drawing.Point(0, 505);
            this.versionInfo.Name = "versionInfo";
            this.versionInfo.Size = new System.Drawing.Size(160, 17);
            this.versionInfo.TabIndex = 13;
            this.versionInfo.Text = "SweetFX Configurator v1.2.2r13";
            this.versionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SweetFX Configurator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox activeGroups;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openGameExe;
        private System.Windows.Forms.Button installFXbutton;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.ListBox detailList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox autoSave;
        private System.Windows.Forms.Label categoryDescription;
        private System.Windows.Forms.Button injectorSetup;
        private System.Windows.Forms.Button remove_sweetfx;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label versionInfo;
        private System.Windows.Forms.Button button10;
    }
}

