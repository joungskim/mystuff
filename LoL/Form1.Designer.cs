namespace LoL
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbChampionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCounters = new System.Windows.Forms.Button();
            this.buttonBuilds = new System.Windows.Forms.Button();
            this.tbCurrentChamp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHealth = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbAD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbDifficulty = new System.Windows.Forms.TextBox();
            this.tbIPCost = new System.Windows.Forms.TextBox();
            this.tbRPCost = new System.Windows.Forms.TextBox();
            this.pbChampImage = new System.Windows.Forms.PictureBox();
            this.buttonSkills = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbReleaseDate = new System.Windows.Forms.TextBox();
            this.lbSelectChamp = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.wbInformation = new System.Windows.Forms.WebBrowser();
            this.buttonOffline = new System.Windows.Forms.Button();
            this.buttonOnline = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbCover = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pbExitButton = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbRedTimer = new System.Windows.Forms.TextBox();
            this.timerRed = new System.Windows.Forms.Timer(this.components);
            this.timerBlue = new System.Windows.Forms.Timer(this.components);
            this.timerDragon = new System.Windows.Forms.Timer(this.components);
            this.timerBaron = new System.Windows.Forms.Timer(this.components);
            this.tbBlueTimer = new System.Windows.Forms.TextBox();
            this.tbDragonTimer = new System.Windows.Forms.TextBox();
            this.tbBaronTimer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonTimerHelp = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbEnableTimer = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChampImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbChampionName
            // 
            this.tbChampionName.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbChampionName.ForeColor = System.Drawing.Color.Lime;
            this.tbChampionName.Location = new System.Drawing.Point(68, 54);
            this.tbChampionName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbChampionName.Name = "tbChampionName";
            this.tbChampionName.Size = new System.Drawing.Size(162, 20);
            this.tbChampionName.TabIndex = 0;
            this.tbChampionName.TextChanged += new System.EventHandler(this.tbChampionName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Champion:";
            // 
            // buttonCounters
            // 
            this.buttonCounters.Location = new System.Drawing.Point(541, 54);
            this.buttonCounters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCounters.Name = "buttonCounters";
            this.buttonCounters.Size = new System.Drawing.Size(106, 19);
            this.buttonCounters.TabIndex = 2;
            this.buttonCounters.Text = "Counters";
            this.buttonCounters.UseVisualStyleBackColor = true;
            this.buttonCounters.Click += new System.EventHandler(this.buttonCounters_Click);
            // 
            // buttonBuilds
            // 
            this.buttonBuilds.Location = new System.Drawing.Point(651, 54);
            this.buttonBuilds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuilds.Name = "buttonBuilds";
            this.buttonBuilds.Size = new System.Drawing.Size(106, 19);
            this.buttonBuilds.TabIndex = 3;
            this.buttonBuilds.Text = "Builds";
            this.buttonBuilds.UseVisualStyleBackColor = true;
            this.buttonBuilds.Click += new System.EventHandler(this.buttonBuilds_Click);
            // 
            // tbCurrentChamp
            // 
            this.tbCurrentChamp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbCurrentChamp.ForeColor = System.Drawing.Color.Lime;
            this.tbCurrentChamp.Location = new System.Drawing.Point(360, 54);
            this.tbCurrentChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCurrentChamp.Name = "tbCurrentChamp";
            this.tbCurrentChamp.ReadOnly = true;
            this.tbCurrentChamp.Size = new System.Drawing.Size(177, 20);
            this.tbCurrentChamp.TabIndex = 5;
            this.tbCurrentChamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(239, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Champion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(239, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.BackColor = System.Drawing.Color.Transparent;
            this.labelHP.ForeColor = System.Drawing.Color.Transparent;
            this.labelHP.Location = new System.Drawing.Point(239, 100);
            this.labelHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(59, 13);
            this.labelHP.TabIndex = 9;
            this.labelHP.Text = "Tankiness:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(239, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "AD";
            // 
            // tbHealth
            // 
            this.tbHealth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbHealth.ForeColor = System.Drawing.Color.Lime;
            this.tbHealth.Location = new System.Drawing.Point(300, 98);
            this.tbHealth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHealth.Name = "tbHealth";
            this.tbHealth.ReadOnly = true;
            this.tbHealth.Size = new System.Drawing.Size(38, 20);
            this.tbHealth.TabIndex = 11;
            this.tbHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbType
            // 
            this.tbType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbType.ForeColor = System.Drawing.Color.Lime;
            this.tbType.Location = new System.Drawing.Point(300, 75);
            this.tbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(38, 20);
            this.tbType.TabIndex = 12;
            this.tbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbAD
            // 
            this.tbAD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAD.ForeColor = System.Drawing.Color.Lime;
            this.tbAD.Location = new System.Drawing.Point(300, 120);
            this.tbAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAD.Name = "tbAD";
            this.tbAD.ReadOnly = true;
            this.tbAD.Size = new System.Drawing.Size(38, 20);
            this.tbAD.TabIndex = 13;
            this.tbAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(239, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "RPCost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(239, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "IPCost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(239, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Difficulty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(239, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "AP";
            // 
            // tbAP
            // 
            this.tbAP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAP.ForeColor = System.Drawing.Color.Lime;
            this.tbAP.Location = new System.Drawing.Point(300, 143);
            this.tbAP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAP.Name = "tbAP";
            this.tbAP.ReadOnly = true;
            this.tbAP.Size = new System.Drawing.Size(38, 20);
            this.tbAP.TabIndex = 18;
            this.tbAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDifficulty
            // 
            this.tbDifficulty.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDifficulty.ForeColor = System.Drawing.Color.Lime;
            this.tbDifficulty.Location = new System.Drawing.Point(300, 166);
            this.tbDifficulty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDifficulty.Name = "tbDifficulty";
            this.tbDifficulty.ReadOnly = true;
            this.tbDifficulty.Size = new System.Drawing.Size(38, 20);
            this.tbDifficulty.TabIndex = 19;
            this.tbDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIPCost
            // 
            this.tbIPCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIPCost.ForeColor = System.Drawing.Color.Lime;
            this.tbIPCost.Location = new System.Drawing.Point(300, 188);
            this.tbIPCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIPCost.Name = "tbIPCost";
            this.tbIPCost.ReadOnly = true;
            this.tbIPCost.Size = new System.Drawing.Size(38, 20);
            this.tbIPCost.TabIndex = 20;
            this.tbIPCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRPCost
            // 
            this.tbRPCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbRPCost.ForeColor = System.Drawing.Color.Lime;
            this.tbRPCost.Location = new System.Drawing.Point(300, 211);
            this.tbRPCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRPCost.Name = "tbRPCost";
            this.tbRPCost.ReadOnly = true;
            this.tbRPCost.Size = new System.Drawing.Size(38, 20);
            this.tbRPCost.TabIndex = 21;
            this.tbRPCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbChampImage
            // 
            this.pbChampImage.BackColor = System.Drawing.Color.Transparent;
            this.pbChampImage.Location = new System.Drawing.Point(242, 536);
            this.pbChampImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbChampImage.Name = "pbChampImage";
            this.pbChampImage.Size = new System.Drawing.Size(100, 102);
            this.pbChampImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChampImage.TabIndex = 24;
            this.pbChampImage.TabStop = false;
            // 
            // buttonSkills
            // 
            this.buttonSkills.Location = new System.Drawing.Point(761, 54);
            this.buttonSkills.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSkills.Name = "buttonSkills";
            this.buttonSkills.Size = new System.Drawing.Size(106, 19);
            this.buttonSkills.TabIndex = 25;
            this.buttonSkills.Text = "Skills";
            this.buttonSkills.UseVisualStyleBackColor = true;
            this.buttonSkills.Click += new System.EventHandler(this.buttonSkills_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(253, 640);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Release Date:";
            // 
            // tbReleaseDate
            // 
            this.tbReleaseDate.Location = new System.Drawing.Point(242, 658);
            this.tbReleaseDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbReleaseDate.Name = "tbReleaseDate";
            this.tbReleaseDate.ReadOnly = true;
            this.tbReleaseDate.Size = new System.Drawing.Size(102, 20);
            this.tbReleaseDate.TabIndex = 27;
            this.tbReleaseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSelectChamp
            // 
            this.lbSelectChamp.BackColor = System.Drawing.Color.Black;
            this.lbSelectChamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSelectChamp.ForeColor = System.Drawing.Color.Lime;
            this.lbSelectChamp.FormattingEnabled = true;
            this.lbSelectChamp.Location = new System.Drawing.Point(9, 77);
            this.lbSelectChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSelectChamp.Name = "lbSelectChamp";
            this.lbSelectChamp.Size = new System.Drawing.Size(220, 600);
            this.lbSelectChamp.TabIndex = 28;
            this.lbSelectChamp.SelectedValueChanged += new System.EventHandler(this.buttonSelectChamp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(243, 247);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "Based on scale\r\nx/100";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wbInformation
            // 
            this.wbInformation.Location = new System.Drawing.Point(360, 77);
            this.wbInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wbInformation.MinimumSize = new System.Drawing.Size(15, 16);
            this.wbInformation.Name = "wbInformation";
            this.wbInformation.ScriptErrorsSuppressed = true;
            this.wbInformation.Size = new System.Drawing.Size(712, 519);
            this.wbInformation.TabIndex = 30;
            // 
            // buttonOffline
            // 
            this.buttonOffline.Location = new System.Drawing.Point(958, 54);
            this.buttonOffline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOffline.Name = "buttonOffline";
            this.buttonOffline.Size = new System.Drawing.Size(56, 19);
            this.buttonOffline.TabIndex = 32;
            this.buttonOffline.Text = "Offline";
            this.buttonOffline.UseVisualStyleBackColor = true;
            // 
            // buttonOnline
            // 
            this.buttonOnline.Location = new System.Drawing.Point(1018, 54);
            this.buttonOnline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOnline.Name = "buttonOnline";
            this.buttonOnline.Size = new System.Drawing.Size(56, 19);
            this.buttonOnline.TabIndex = 33;
            this.buttonOnline.Text = "Online";
            this.buttonOnline.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(897, 54);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 19);
            this.buttonClear.TabIndex = 34;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTime.ForeColor = System.Drawing.Color.Lime;
            this.labelDateTime.Location = new System.Drawing.Point(232, 283);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(53, 13);
            this.labelDateTime.TabIndex = 35;
            this.labelDateTime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbCover
            // 
            this.pbCover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbCover.Location = new System.Drawing.Point(360, 77);
            this.pbCover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(712, 519);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 36;
            this.pbCover.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pbExitButton);
            this.panel1.Controls.Add(this.pbMinimize);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 30);
            this.panel1.TabIndex = 39;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(20, 2);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 10);
            this.label16.TabIndex = 51;
            this.label16.Text = "Version 1.0 (Beta)";
            // 
            // pbExitButton
            // 
            this.pbExitButton.Image = ((System.Drawing.Image)(resources.GetObject("pbExitButton.Image")));
            this.pbExitButton.Location = new System.Drawing.Point(1046, 2);
            this.pbExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbExitButton.Name = "pbExitButton";
            this.pbExitButton.Size = new System.Drawing.Size(31, 28);
            this.pbExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExitButton.TabIndex = 0;
            this.pbExitButton.TabStop = false;
            this.pbExitButton.Click += new System.EventHandler(this.pbExitButton_Click);
            this.pbExitButton.MouseEnter += new System.EventHandler(this.pbExitButton_MouseEnter);
            this.pbExitButton.MouseLeave += new System.EventHandler(this.pbExitButton_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(1010, 2);
            this.pbMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(31, 28);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 50;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.HotPink;
            this.label11.Location = new System.Drawing.Point(233, 328);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Red Buff:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Aqua;
            this.label12.Location = new System.Drawing.Point(233, 351);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Blue Buff:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(233, 396);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "BARON:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(233, 374);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "DRAGON:";
            // 
            // tbRedTimer
            // 
            this.tbRedTimer.BackColor = System.Drawing.Color.Black;
            this.tbRedTimer.Location = new System.Drawing.Point(287, 326);
            this.tbRedTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRedTimer.Name = "tbRedTimer";
            this.tbRedTimer.ReadOnly = true;
            this.tbRedTimer.Size = new System.Drawing.Size(51, 20);
            this.tbRedTimer.TabIndex = 44;
            // 
            // timerRed
            // 
            this.timerRed.Interval = 1000;
            this.timerRed.Tick += new System.EventHandler(this.timerRed_Tick);
            // 
            // timerBlue
            // 
            this.timerBlue.Interval = 1000;
            this.timerBlue.Tick += new System.EventHandler(this.timerBlue_Tick);
            // 
            // timerDragon
            // 
            this.timerDragon.Interval = 1000;
            this.timerDragon.Tick += new System.EventHandler(this.timerDragon_Tick);
            // 
            // timerBaron
            // 
            this.timerBaron.Interval = 1000;
            this.timerBaron.Tick += new System.EventHandler(this.timerBaron_Tick);
            // 
            // tbBlueTimer
            // 
            this.tbBlueTimer.BackColor = System.Drawing.Color.Black;
            this.tbBlueTimer.Location = new System.Drawing.Point(287, 349);
            this.tbBlueTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBlueTimer.Name = "tbBlueTimer";
            this.tbBlueTimer.ReadOnly = true;
            this.tbBlueTimer.Size = new System.Drawing.Size(51, 20);
            this.tbBlueTimer.TabIndex = 45;
            // 
            // tbDragonTimer
            // 
            this.tbDragonTimer.BackColor = System.Drawing.Color.Black;
            this.tbDragonTimer.Location = new System.Drawing.Point(287, 371);
            this.tbDragonTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDragonTimer.Name = "tbDragonTimer";
            this.tbDragonTimer.ReadOnly = true;
            this.tbDragonTimer.Size = new System.Drawing.Size(51, 20);
            this.tbDragonTimer.TabIndex = 46;
            // 
            // tbBaronTimer
            // 
            this.tbBaronTimer.BackColor = System.Drawing.Color.Black;
            this.tbBaronTimer.Location = new System.Drawing.Point(287, 394);
            this.tbBaronTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBaronTimer.Name = "tbBaronTimer";
            this.tbBaronTimer.ReadOnly = true;
            this.tbBaronTimer.Size = new System.Drawing.Size(51, 20);
            this.tbBaronTimer.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(231, 303);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 48;
            this.label15.Text = "TIMERS";
            // 
            // buttonTimerHelp
            // 
            this.buttonTimerHelp.Location = new System.Drawing.Point(299, 303);
            this.buttonTimerHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTimerHelp.Name = "buttonTimerHelp";
            this.buttonTimerHelp.Size = new System.Drawing.Size(22, 19);
            this.buttonTimerHelp.TabIndex = 49;
            this.buttonTimerHelp.Text = "?";
            this.buttonTimerHelp.UseVisualStyleBackColor = true;
            this.buttonTimerHelp.Click += new System.EventHandler(this.buttonTimerHelp_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(11, 9);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(76, 41);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 51;
            this.pbLogo.TabStop = false;
            // 
            // cbEnableTimer
            // 
            this.cbEnableTimer.AutoSize = true;
            this.cbEnableTimer.BackColor = System.Drawing.Color.Transparent;
            this.cbEnableTimer.ForeColor = System.Drawing.Color.White;
            this.cbEnableTimer.Location = new System.Drawing.Point(242, 417);
            this.cbEnableTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEnableTimer.Name = "cbEnableTimer";
            this.cbEnableTimer.Size = new System.Drawing.Size(93, 17);
            this.cbEnableTimer.TabIndex = 52;
            this.cbEnableTimer.Text = "Enable Timers";
            this.cbEnableTimer.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.cbEnableTimer);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.buttonTimerHelp);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbBaronTimer);
            this.Controls.Add(this.tbDragonTimer);
            this.Controls.Add(this.tbBlueTimer);
            this.Controls.Add(this.tbRedTimer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOnline);
            this.Controls.Add(this.buttonOffline);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbSelectChamp);
            this.Controls.Add(this.tbReleaseDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSkills);
            this.Controls.Add(this.pbChampImage);
            this.Controls.Add(this.tbRPCost);
            this.Controls.Add(this.tbIPCost);
            this.Controls.Add(this.tbDifficulty);
            this.Controls.Add(this.tbAP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAD);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbHealth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCurrentChamp);
            this.Controls.Add(this.buttonBuilds);
            this.Controls.Add(this.buttonCounters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbChampionName);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.wbInformation);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "League Of Legends: Database";
            ((System.ComponentModel.ISupportInitialize)(this.pbChampImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChampionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCounters;
        private System.Windows.Forms.Button buttonBuilds;
        private System.Windows.Forms.TextBox tbCurrentChamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHealth;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbAD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbDifficulty;
        private System.Windows.Forms.TextBox tbIPCost;
        private System.Windows.Forms.TextBox tbRPCost;
        private System.Windows.Forms.PictureBox pbChampImage;
        private System.Windows.Forms.Button buttonSkills;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbReleaseDate;
        private System.Windows.Forms.ListBox lbSelectChamp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.WebBrowser wbInformation;
        private System.Windows.Forms.Button buttonOffline;
        private System.Windows.Forms.Button buttonOnline;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbRedTimer;
        private System.Windows.Forms.Timer timerRed;
        private System.Windows.Forms.Timer timerBlue;
        private System.Windows.Forms.Timer timerDragon;
        private System.Windows.Forms.Timer timerBaron;
        private System.Windows.Forms.TextBox tbBlueTimer;
        private System.Windows.Forms.TextBox tbDragonTimer;
        private System.Windows.Forms.TextBox tbBaronTimer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonTimerHelp;
        private System.Windows.Forms.PictureBox pbExitButton;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.CheckBox cbEnableTimer;
        private System.Windows.Forms.Label label16;
    }
}

