namespace WindowsFormsApplication1
{
    partial class gameData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameData));
            this.gameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gameArgs = new System.Windows.Forms.TextBox();
            this.specialInstall = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specialpath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.execFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.installDir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.Location = new System.Drawing.Point(113, 12);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(194, 20);
            this.gameName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Launch arguments";
            // 
            // gameArgs
            // 
            this.gameArgs.Location = new System.Drawing.Point(113, 38);
            this.gameArgs.Name = "gameArgs";
            this.gameArgs.Size = new System.Drawing.Size(194, 20);
            this.gameArgs.TabIndex = 4;
            // 
            // specialInstall
            // 
            this.specialInstall.AutoSize = true;
            this.specialInstall.Location = new System.Drawing.Point(125, 23);
            this.specialInstall.Name = "specialInstall";
            this.specialInstall.Size = new System.Drawing.Size(65, 17);
            this.specialInstall.TabIndex = 5;
            this.specialInstall.Text = "Enabled";
            this.specialInstall.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Split SweetFX install";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Open folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // path
            // 
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.Location = new System.Drawing.Point(9, 159);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(260, 42);
            this.path.TabIndex = 8;
            this.path.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Split install folder";
            // 
            // specialpath
            // 
            this.specialpath.Location = new System.Drawing.Point(125, 46);
            this.specialpath.Name = "specialpath";
            this.specialpath.Size = new System.Drawing.Size(196, 20);
            this.specialpath.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.specialpath);
            this.groupBox1.Controls.Add(this.specialInstall);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(323, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 197);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Split SweetFX install";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 95);
            this.label5.TabIndex = 11;
            this.label5.Text = "Some game engines require the injector files installed to a subdirectory (usually" +
                " \"bin\" or \"bin32\") for it to work properly. Enable this to split the files when " +
                "adding SweetFX to this game.";
            // 
            // execFolder
            // 
            this.execFolder.Location = new System.Drawing.Point(113, 64);
            this.execFolder.Name = "execFolder";
            this.execFolder.Size = new System.Drawing.Size(155, 20);
            this.execFolder.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Working directory";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(274, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(327, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(650, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 23);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // installDir
            // 
            this.installDir.Location = new System.Drawing.Point(343, 25);
            this.installDir.Name = "installDir";
            this.installDir.Size = new System.Drawing.Size(301, 20);
            this.installDir.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SweetFX Installation directory";
            // 
            // gameData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 271);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.installDir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.execFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gameArgs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "gameData";
            this.Text = "gameData";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gameArgs;
        private System.Windows.Forms.CheckBox specialInstall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox specialpath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox execFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox installDir;
        private System.Windows.Forms.Label label7;

    }
}