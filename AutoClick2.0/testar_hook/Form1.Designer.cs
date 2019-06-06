namespace testar_hook
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
            this.TB_StartKey = new System.Windows.Forms.TextBox();
            this.B_Run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_StopKey = new System.Windows.Forms.TextBox();
            this.B_Stop = new System.Windows.Forms.Button();
            this.CB_Key1 = new System.Windows.Forms.ComboBox();
            this.TB_RightClick = new System.Windows.Forms.TextBox();
            this.TB_LeftClick = new System.Windows.Forms.TextBox();
            this.CHB_LeftClick = new System.Windows.Forms.CheckBox();
            this.CHB_RightClick = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CHB_Key1 = new System.Windows.Forms.CheckBox();
            this.TB_Key1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Key2 = new System.Windows.Forms.TextBox();
            this.CHB_Key2 = new System.Windows.Forms.CheckBox();
            this.CB_Key2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Key4 = new System.Windows.Forms.TextBox();
            this.CHB_Key4 = new System.Windows.Forms.CheckBox();
            this.CB_Key4 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_Key3 = new System.Windows.Forms.TextBox();
            this.CHB_Key3 = new System.Windows.Forms.CheckBox();
            this.CB_Key3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_Key8 = new System.Windows.Forms.TextBox();
            this.CHB_Key8 = new System.Windows.Forms.CheckBox();
            this.CB_Key8 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_Key7 = new System.Windows.Forms.TextBox();
            this.CHB_Key7 = new System.Windows.Forms.CheckBox();
            this.CB_Key7 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_Key6 = new System.Windows.Forms.TextBox();
            this.CHB_Key6 = new System.Windows.Forms.CheckBox();
            this.CB_Key6 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TB_Key5 = new System.Windows.Forms.TextBox();
            this.CHB_Key5 = new System.Windows.Forms.CheckBox();
            this.CB_Key5 = new System.Windows.Forms.ComboBox();
            this.CHB_SameStartStop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TB_StartKey
            // 
            this.TB_StartKey.Location = new System.Drawing.Point(542, 25);
            this.TB_StartKey.Name = "TB_StartKey";
            this.TB_StartKey.Size = new System.Drawing.Size(50, 20);
            this.TB_StartKey.TabIndex = 1;
            // 
            // B_Run
            // 
            this.B_Run.Location = new System.Drawing.Point(573, 286);
            this.B_Run.Name = "B_Run";
            this.B_Run.Size = new System.Drawing.Size(75, 23);
            this.B_Run.TabIndex = 3;
            this.B_Run.Text = "Run";
            this.B_Run.UseVisualStyleBackColor = true;
            this.B_Run.Click += new System.EventHandler(this.B_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start_Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stop_Key";
            // 
            // TB_StopKey
            // 
            this.TB_StopKey.Location = new System.Drawing.Point(598, 25);
            this.TB_StopKey.Name = "TB_StopKey";
            this.TB_StopKey.Size = new System.Drawing.Size(50, 20);
            this.TB_StopKey.TabIndex = 6;
            // 
            // B_Stop
            // 
            this.B_Stop.Location = new System.Drawing.Point(3, 286);
            this.B_Stop.Name = "B_Stop";
            this.B_Stop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B_Stop.Size = new System.Drawing.Size(106, 23);
            this.B_Stop.TabIndex = 7;
            this.B_Stop.Text = "Stop Running";
            this.B_Stop.UseVisualStyleBackColor = true;
            this.B_Stop.Click += new System.EventHandler(this.B_Stop_Click);
            // 
            // CB_Key1
            // 
            this.CB_Key1.Enabled = false;
            this.CB_Key1.FormattingEnabled = true;
            this.CB_Key1.Location = new System.Drawing.Point(0, 94);
            this.CB_Key1.Name = "CB_Key1";
            this.CB_Key1.Size = new System.Drawing.Size(50, 21);
            this.CB_Key1.TabIndex = 8;
            // 
            // TB_RightClick
            // 
            this.TB_RightClick.Enabled = false;
            this.TB_RightClick.Location = new System.Drawing.Point(218, 25);
            this.TB_RightClick.Name = "TB_RightClick";
            this.TB_RightClick.Size = new System.Drawing.Size(100, 20);
            this.TB_RightClick.TabIndex = 10;
            // 
            // TB_LeftClick
            // 
            this.TB_LeftClick.Enabled = false;
            this.TB_LeftClick.Location = new System.Drawing.Point(0, 25);
            this.TB_LeftClick.Name = "TB_LeftClick";
            this.TB_LeftClick.Size = new System.Drawing.Size(100, 20);
            this.TB_LeftClick.TabIndex = 11;
            // 
            // CHB_LeftClick
            // 
            this.CHB_LeftClick.AutoSize = true;
            this.CHB_LeftClick.Location = new System.Drawing.Point(106, 25);
            this.CHB_LeftClick.Name = "CHB_LeftClick";
            this.CHB_LeftClick.Size = new System.Drawing.Size(112, 17);
            this.CHB_LeftClick.TabIndex = 12;
            this.CHB_LeftClick.Text = "Left_Click_Enable";
            this.CHB_LeftClick.UseVisualStyleBackColor = true;
            this.CHB_LeftClick.CheckedChanged += new System.EventHandler(this.CHB_LeftClick_CheckedChanged);
            // 
            // CHB_RightClick
            // 
            this.CHB_RightClick.AutoSize = true;
            this.CHB_RightClick.Location = new System.Drawing.Point(324, 25);
            this.CHB_RightClick.Name = "CHB_RightClick";
            this.CHB_RightClick.Size = new System.Drawing.Size(119, 17);
            this.CHB_RightClick.TabIndex = 13;
            this.CHB_RightClick.Text = "Right_Click_Enable";
            this.CHB_RightClick.UseVisualStyleBackColor = true;
            this.CHB_RightClick.CheckedChanged += new System.EventHandler(this.CHB_RightClick_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Left_Click_interval(ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Right_Click_interval(ms)";
            // 
            // CHB_Key1
            // 
            this.CHB_Key1.AutoSize = true;
            this.CHB_Key1.Location = new System.Drawing.Point(56, 98);
            this.CHB_Key1.Name = "CHB_Key1";
            this.CHB_Key1.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key1.TabIndex = 16;
            this.CHB_Key1.Text = "Key1_Enable";
            this.CHB_Key1.UseVisualStyleBackColor = true;
            this.CHB_Key1.CheckedChanged += new System.EventHandler(this.CHB_Key1_CheckedChanged);
            // 
            // TB_Key1
            // 
            this.TB_Key1.Enabled = false;
            this.TB_Key1.Location = new System.Drawing.Point(0, 121);
            this.TB_Key1.Name = "TB_Key1";
            this.TB_Key1.Size = new System.Drawing.Size(50, 20);
            this.TB_Key1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Key1_interval(ms)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Keyboard input 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Keyboard input 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Key2_interval(ms)";
            // 
            // TB_Key2
            // 
            this.TB_Key2.Enabled = false;
            this.TB_Key2.Location = new System.Drawing.Point(148, 121);
            this.TB_Key2.Name = "TB_Key2";
            this.TB_Key2.Size = new System.Drawing.Size(50, 20);
            this.TB_Key2.TabIndex = 26;
            // 
            // CHB_Key2
            // 
            this.CHB_Key2.AutoSize = true;
            this.CHB_Key2.Location = new System.Drawing.Point(204, 98);
            this.CHB_Key2.Name = "CHB_Key2";
            this.CHB_Key2.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key2.TabIndex = 25;
            this.CHB_Key2.Text = "Key2_Enable";
            this.CHB_Key2.UseVisualStyleBackColor = true;
            this.CHB_Key2.CheckedChanged += new System.EventHandler(this.CHB_Key2_CheckedChanged);
            // 
            // CB_Key2
            // 
            this.CB_Key2.Enabled = false;
            this.CB_Key2.FormattingEnabled = true;
            this.CB_Key2.Location = new System.Drawing.Point(148, 94);
            this.CB_Key2.Name = "CB_Key2";
            this.CB_Key2.Size = new System.Drawing.Size(50, 21);
            this.CB_Key2.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Keyboard input 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Key4_interval(ms)";
            // 
            // TB_Key4
            // 
            this.TB_Key4.Enabled = false;
            this.TB_Key4.Location = new System.Drawing.Point(444, 121);
            this.TB_Key4.Name = "TB_Key4";
            this.TB_Key4.Size = new System.Drawing.Size(50, 20);
            this.TB_Key4.TabIndex = 36;
            // 
            // CHB_Key4
            // 
            this.CHB_Key4.AutoSize = true;
            this.CHB_Key4.Location = new System.Drawing.Point(500, 98);
            this.CHB_Key4.Name = "CHB_Key4";
            this.CHB_Key4.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key4.TabIndex = 35;
            this.CHB_Key4.Text = "Key4_Enable";
            this.CHB_Key4.UseVisualStyleBackColor = true;
            this.CHB_Key4.CheckedChanged += new System.EventHandler(this.CHB_Key4_CheckedChanged);
            // 
            // CB_Key4
            // 
            this.CB_Key4.Enabled = false;
            this.CB_Key4.FormattingEnabled = true;
            this.CB_Key4.Location = new System.Drawing.Point(444, 94);
            this.CB_Key4.Name = "CB_Key4";
            this.CB_Key4.Size = new System.Drawing.Size(50, 21);
            this.CB_Key4.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Keyboard input 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Key3_interval(ms)";
            // 
            // TB_Key3
            // 
            this.TB_Key3.Enabled = false;
            this.TB_Key3.Location = new System.Drawing.Point(296, 121);
            this.TB_Key3.Name = "TB_Key3";
            this.TB_Key3.Size = new System.Drawing.Size(50, 20);
            this.TB_Key3.TabIndex = 31;
            // 
            // CHB_Key3
            // 
            this.CHB_Key3.AutoSize = true;
            this.CHB_Key3.Location = new System.Drawing.Point(352, 98);
            this.CHB_Key3.Name = "CHB_Key3";
            this.CHB_Key3.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key3.TabIndex = 30;
            this.CHB_Key3.Text = "Key3_Enable";
            this.CHB_Key3.UseVisualStyleBackColor = true;
            this.CHB_Key3.CheckedChanged += new System.EventHandler(this.CHB_Key3_CheckedChanged);
            // 
            // CB_Key3
            // 
            this.CB_Key3.Enabled = false;
            this.CB_Key3.FormattingEnabled = true;
            this.CB_Key3.Location = new System.Drawing.Point(296, 94);
            this.CB_Key3.Name = "CB_Key3";
            this.CB_Key3.Size = new System.Drawing.Size(50, 21);
            this.CB_Key3.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Keyboard input 8";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(497, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Key8_interval(ms)";
            // 
            // TB_Key8
            // 
            this.TB_Key8.Enabled = false;
            this.TB_Key8.Location = new System.Drawing.Point(444, 236);
            this.TB_Key8.Name = "TB_Key8";
            this.TB_Key8.Size = new System.Drawing.Size(50, 20);
            this.TB_Key8.TabIndex = 56;
            // 
            // CHB_Key8
            // 
            this.CHB_Key8.AutoSize = true;
            this.CHB_Key8.Location = new System.Drawing.Point(500, 213);
            this.CHB_Key8.Name = "CHB_Key8";
            this.CHB_Key8.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key8.TabIndex = 55;
            this.CHB_Key8.Text = "Key8_Enable";
            this.CHB_Key8.UseVisualStyleBackColor = true;
            this.CHB_Key8.CheckedChanged += new System.EventHandler(this.CHB_Key8_CheckedChanged);
            // 
            // CB_Key8
            // 
            this.CB_Key8.Enabled = false;
            this.CB_Key8.FormattingEnabled = true;
            this.CB_Key8.Location = new System.Drawing.Point(444, 209);
            this.CB_Key8.Name = "CB_Key8";
            this.CB_Key8.Size = new System.Drawing.Size(50, 21);
            this.CB_Key8.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(296, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "Keyboard input 7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(349, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Key7_interval(ms)";
            // 
            // TB_Key7
            // 
            this.TB_Key7.Enabled = false;
            this.TB_Key7.Location = new System.Drawing.Point(296, 236);
            this.TB_Key7.Name = "TB_Key7";
            this.TB_Key7.Size = new System.Drawing.Size(50, 20);
            this.TB_Key7.TabIndex = 51;
            // 
            // CHB_Key7
            // 
            this.CHB_Key7.AutoSize = true;
            this.CHB_Key7.Location = new System.Drawing.Point(352, 213);
            this.CHB_Key7.Name = "CHB_Key7";
            this.CHB_Key7.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key7.TabIndex = 50;
            this.CHB_Key7.Text = "Key7_Enable";
            this.CHB_Key7.UseVisualStyleBackColor = true;
            this.CHB_Key7.CheckedChanged += new System.EventHandler(this.CHB_Key7_CheckedChanged);
            // 
            // CB_Key7
            // 
            this.CB_Key7.Enabled = false;
            this.CB_Key7.FormattingEnabled = true;
            this.CB_Key7.Location = new System.Drawing.Point(296, 209);
            this.CB_Key7.Name = "CB_Key7";
            this.CB_Key7.Size = new System.Drawing.Size(50, 21);
            this.CB_Key7.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(148, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Keyboard input 6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(201, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Key6_interval(ms)";
            // 
            // TB_Key6
            // 
            this.TB_Key6.Enabled = false;
            this.TB_Key6.Location = new System.Drawing.Point(148, 236);
            this.TB_Key6.Name = "TB_Key6";
            this.TB_Key6.Size = new System.Drawing.Size(50, 20);
            this.TB_Key6.TabIndex = 46;
            // 
            // CHB_Key6
            // 
            this.CHB_Key6.AutoSize = true;
            this.CHB_Key6.Location = new System.Drawing.Point(204, 213);
            this.CHB_Key6.Name = "CHB_Key6";
            this.CHB_Key6.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key6.TabIndex = 45;
            this.CHB_Key6.Text = "Key6_Enable";
            this.CHB_Key6.UseVisualStyleBackColor = true;
            this.CHB_Key6.CheckedChanged += new System.EventHandler(this.CHB_Key6_CheckedChanged);
            // 
            // CB_Key6
            // 
            this.CB_Key6.Enabled = false;
            this.CB_Key6.FormattingEnabled = true;
            this.CB_Key6.Location = new System.Drawing.Point(148, 209);
            this.CB_Key6.Name = "CB_Key6";
            this.CB_Key6.Size = new System.Drawing.Size(50, 21);
            this.CB_Key6.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(0, 190);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Keyboard input 5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(53, 239);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Key5_interval(ms)";
            // 
            // TB_Key5
            // 
            this.TB_Key5.Enabled = false;
            this.TB_Key5.Location = new System.Drawing.Point(0, 236);
            this.TB_Key5.Name = "TB_Key5";
            this.TB_Key5.Size = new System.Drawing.Size(50, 20);
            this.TB_Key5.TabIndex = 41;
            // 
            // CHB_Key5
            // 
            this.CHB_Key5.AutoSize = true;
            this.CHB_Key5.Location = new System.Drawing.Point(56, 213);
            this.CHB_Key5.Name = "CHB_Key5";
            this.CHB_Key5.Size = new System.Drawing.Size(89, 17);
            this.CHB_Key5.TabIndex = 40;
            this.CHB_Key5.Text = "Key5_Enable";
            this.CHB_Key5.UseVisualStyleBackColor = true;
            this.CHB_Key5.CheckedChanged += new System.EventHandler(this.CHB_Key5_CheckedChanged);
            // 
            // CB_Key5
            // 
            this.CB_Key5.Enabled = false;
            this.CB_Key5.FormattingEnabled = true;
            this.CB_Key5.Location = new System.Drawing.Point(0, 209);
            this.CB_Key5.Name = "CB_Key5";
            this.CB_Key5.Size = new System.Drawing.Size(50, 21);
            this.CB_Key5.TabIndex = 39;
            // 
            // CHB_SameStartStop
            // 
            this.CHB_SameStartStop.AutoSize = true;
            this.CHB_SameStartStop.Location = new System.Drawing.Point(542, 52);
            this.CHB_SameStartStop.Name = "CHB_SameStartStop";
            this.CHB_SameStartStop.Size = new System.Drawing.Size(101, 17);
            this.CHB_SameStartStop.TabIndex = 59;
            this.CHB_SameStartStop.Text = "Same start/stop";
            this.CHB_SameStartStop.UseVisualStyleBackColor = true;
            this.CHB_SameStartStop.CheckedChanged += new System.EventHandler(this.CHB_SameStartStopChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 321);
            this.Controls.Add(this.CHB_SameStartStop);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TB_Key8);
            this.Controls.Add(this.CHB_Key8);
            this.Controls.Add(this.CB_Key8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TB_Key7);
            this.Controls.Add(this.CHB_Key7);
            this.Controls.Add(this.CB_Key7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TB_Key6);
            this.Controls.Add(this.CHB_Key6);
            this.Controls.Add(this.CB_Key6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TB_Key5);
            this.Controls.Add(this.CHB_Key5);
            this.Controls.Add(this.CB_Key5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TB_Key4);
            this.Controls.Add(this.CHB_Key4);
            this.Controls.Add(this.CB_Key4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TB_Key3);
            this.Controls.Add(this.CHB_Key3);
            this.Controls.Add(this.CB_Key3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Key2);
            this.Controls.Add(this.CHB_Key2);
            this.Controls.Add(this.CB_Key2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Key1);
            this.Controls.Add(this.CHB_Key1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CHB_RightClick);
            this.Controls.Add(this.CHB_LeftClick);
            this.Controls.Add(this.TB_LeftClick);
            this.Controls.Add(this.TB_RightClick);
            this.Controls.Add(this.CB_Key1);
            this.Controls.Add(this.B_Stop);
            this.Controls.Add(this.TB_StopKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Run);
            this.Controls.Add(this.TB_StartKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_StartKey;
        private System.Windows.Forms.Button B_Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_StopKey;
        private System.Windows.Forms.Button B_Stop;
        private System.Windows.Forms.ComboBox CB_Key1;
        private System.Windows.Forms.TextBox TB_RightClick;
        private System.Windows.Forms.TextBox TB_LeftClick;
        private System.Windows.Forms.CheckBox CHB_LeftClick;
        private System.Windows.Forms.CheckBox CHB_RightClick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CHB_Key1;
        private System.Windows.Forms.TextBox TB_Key1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Key2;
        private System.Windows.Forms.CheckBox CHB_Key2;
        private System.Windows.Forms.ComboBox CB_Key2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Key4;
        private System.Windows.Forms.CheckBox CHB_Key4;
        private System.Windows.Forms.ComboBox CB_Key4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_Key3;
        private System.Windows.Forms.CheckBox CHB_Key3;
        private System.Windows.Forms.ComboBox CB_Key3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_Key8;
        private System.Windows.Forms.CheckBox CHB_Key8;
        private System.Windows.Forms.ComboBox CB_Key8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_Key7;
        private System.Windows.Forms.CheckBox CHB_Key7;
        private System.Windows.Forms.ComboBox CB_Key7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_Key6;
        private System.Windows.Forms.CheckBox CHB_Key6;
        private System.Windows.Forms.ComboBox CB_Key6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TB_Key5;
        private System.Windows.Forms.CheckBox CHB_Key5;
        private System.Windows.Forms.ComboBox CB_Key5;
        private System.Windows.Forms.CheckBox CHB_SameStartStop;
    }
}

