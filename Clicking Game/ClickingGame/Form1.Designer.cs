namespace ClickingGame
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
            this.ShootBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.ByTitle = new System.Windows.Forms.Label();
            this.Label_Shots = new System.Windows.Forms.Label();
            this.LabelReloads = new System.Windows.Forms.Label();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.ReloadNum = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.g10 = new System.Windows.Forms.Label();
            this.r10 = new System.Windows.Forms.Label();
            this.t10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.s10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.fa10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.detail10 = new System.Windows.Forms.Label();
            this.ReloadTimer = new System.Windows.Forms.Timer(this.components);
            this.ShootTimer = new System.Windows.Forms.Timer(this.components);
            this.bar4 = new MBGlassStyleProgressBar.MBProgressBar();
            this.bar3 = new MBGlassStyleProgressBar.MBProgressBar();
            this.Reload1 = new ColorProgressBar.ColorProgressBar();
            this.Fire1 = new ColorProgressBar.ColorProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.FPBtn = new System.Windows.Forms.Button();
            this.fp10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ThemeSong = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ShootBtn
            // 
            this.ShootBtn.Location = new System.Drawing.Point(12, 70);
            this.ShootBtn.Name = "ShootBtn";
            this.ShootBtn.Size = new System.Drawing.Size(75, 23);
            this.ShootBtn.TabIndex = 0;
            this.ShootBtn.Text = "Fireball";
            this.ShootBtn.UseVisualStyleBackColor = true;
            this.ShootBtn.Click += new System.EventHandler(this.ShootBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(211, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(70, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Shoot Em Up";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ByTitle
            // 
            this.ByTitle.AutoSize = true;
            this.ByTitle.BackColor = System.Drawing.Color.Transparent;
            this.ByTitle.Location = new System.Drawing.Point(202, 31);
            this.ByTitle.Name = "ByTitle";
            this.ByTitle.Size = new System.Drawing.Size(88, 13);
            this.ByTitle.TabIndex = 2;
            this.ByTitle.Text = "Created by: Dejin";
            // 
            // Label_Shots
            // 
            this.Label_Shots.AutoSize = true;
            this.Label_Shots.Location = new System.Drawing.Point(12, 156);
            this.Label_Shots.Name = "Label_Shots";
            this.Label_Shots.Size = new System.Drawing.Size(85, 13);
            this.Label_Shots.TabIndex = 3;
            this.Label_Shots.Text = "How many shots";
            // 
            // LabelReloads
            // 
            this.LabelReloads.AutoSize = true;
            this.LabelReloads.Location = new System.Drawing.Point(12, 180);
            this.LabelReloads.Name = "LabelReloads";
            this.LabelReloads.Size = new System.Drawing.Size(94, 13);
            this.LabelReloads.TabIndex = 4;
            this.LabelReloads.Text = "How many reloads";
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Location = new System.Drawing.Point(93, 70);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReloadBtn.TabIndex = 5;
            this.ReloadBtn.Text = "Reload";
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // ReloadNum
            // 
            this.ReloadNum.AutoSize = true;
            this.ReloadNum.Location = new System.Drawing.Point(113, 180);
            this.ReloadNum.Name = "ReloadNum";
            this.ReloadNum.Size = new System.Drawing.Size(13, 13);
            this.ReloadNum.TabIndex = 7;
            this.ReloadNum.Text = "0";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(113, 156);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(13, 13);
            this.lbl20.TabIndex = 8;
            this.lbl20.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl2.Location = new System.Drawing.Point(12, 132);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(72, 13);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Fireball Ammo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Exp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(47, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(93, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Coins";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(132, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "0";
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(434, 70);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(75, 23);
            this.ShopBtn.TabIndex = 15;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(431, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Buy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Goomba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Star";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Red coins";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // g10
            // 
            this.g10.AutoSize = true;
            this.g10.BackColor = System.Drawing.Color.Transparent;
            this.g10.Location = new System.Drawing.Point(536, 127);
            this.g10.Name = "g10";
            this.g10.Size = new System.Drawing.Size(35, 13);
            this.g10.TabIndex = 21;
            this.g10.Text = "1 Star";
            // 
            // r10
            // 
            this.r10.AutoSize = true;
            this.r10.BackColor = System.Drawing.Color.Transparent;
            this.r10.Location = new System.Drawing.Point(536, 185);
            this.r10.Name = "r10";
            this.r10.Size = new System.Drawing.Size(40, 13);
            this.r10.TabIndex = 22;
            this.r10.Text = "3 Stars";
            // 
            // t10
            // 
            this.t10.AutoSize = true;
            this.t10.BackColor = System.Drawing.Color.Transparent;
            this.t10.Location = new System.Drawing.Point(722, 156);
            this.t10.Name = "t10";
            this.t10.Size = new System.Drawing.Size(59, 13);
            this.t10.TabIndex = 23;
            this.t10.Text = "1000 coins";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(113, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Shrooms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 271);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Stars";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 248);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Red coins";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Mushrooms";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 201);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Goomba";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(113, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "0";
            // 
            // s10
            // 
            this.s10.AutoSize = true;
            this.s10.BackColor = System.Drawing.Color.Transparent;
            this.s10.Location = new System.Drawing.Point(536, 156);
            this.s10.Name = "s10";
            this.s10.Size = new System.Drawing.Size(54, 13);
            this.s10.TabIndex = 33;
            this.s10.Text = "500 Coins";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(623, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Fireball Ammo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // fa10
            // 
            this.fa10.AutoSize = true;
            this.fa10.BackColor = System.Drawing.Color.Transparent;
            this.fa10.Location = new System.Drawing.Point(722, 127);
            this.fa10.Name = "fa10";
            this.fa10.Size = new System.Drawing.Size(48, 13);
            this.fa10.TabIndex = 35;
            this.fa10.Text = "50 Coins";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Ammo Upgrades";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "0";
            // 
            // detail10
            // 
            this.detail10.AutoSize = true;
            this.detail10.BackColor = System.Drawing.Color.Transparent;
            this.detail10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.detail10.Location = new System.Drawing.Point(536, 209);
            this.detail10.MaximumSize = new System.Drawing.Size(300, 0);
            this.detail10.Name = "detail10";
            this.detail10.Size = new System.Drawing.Size(298, 52);
            this.detail10.TabIndex = 38;
            this.detail10.Text = resources.GetString("detail10.Text");
            // 
            // ReloadTimer
            // 
            this.ReloadTimer.Interval = 80;
            this.ReloadTimer.Tick += new System.EventHandler(this.ReloadTimer_Tick);
            // 
            // ShootTimer
            // 
            this.ShootTimer.Interval = 70;
            this.ShootTimer.Tick += new System.EventHandler(this.ShootTimer_Tick);
            // 
            // bar4
            // 
            this.bar4.Animate = false;
            this.bar4.BackColor = System.Drawing.Color.Transparent;
            this.bar4.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.bar4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bar4.GlowColor = System.Drawing.Color.Transparent;
            this.bar4.HighlightColor = System.Drawing.Color.Transparent;
            this.bar4.Location = new System.Drawing.Point(12, 113);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(156, 13);
            this.bar4.TabIndex = 44;
            // 
            // bar3
            // 
            this.bar3.Animate = false;
            this.bar3.BackColor = System.Drawing.Color.Transparent;
            this.bar3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bar3.Color = System.Drawing.Color.Red;
            this.bar3.GlowColor = System.Drawing.Color.DarkRed;
            this.bar3.HighlightColor = System.Drawing.Color.Red;
            this.bar3.Location = new System.Drawing.Point(12, 95);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(156, 15);
            this.bar3.TabIndex = 43;
            // 
            // Reload1
            // 
            this.Reload1.BarColor = System.Drawing.Color.Lime;
            this.Reload1.BorderColor = System.Drawing.Color.White;
            this.Reload1.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.Reload1.Location = new System.Drawing.Point(18, 113);
            this.Reload1.Maximum = 100;
            this.Reload1.Minimum = 0;
            this.Reload1.Name = "Reload1";
            this.Reload1.Size = new System.Drawing.Size(150, 13);
            this.Reload1.Step = 10;
            this.Reload1.TabIndex = 45;
            this.Reload1.Value = 0;
            // 
            // Fire1
            // 
            this.Fire1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Fire1.BorderColor = System.Drawing.Color.Black;
            this.Fire1.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.Fire1.Location = new System.Drawing.Point(12, 95);
            this.Fire1.Maximum = 100;
            this.Fire1.Minimum = 0;
            this.Fire1.Name = "Fire1";
            this.Fire1.Size = new System.Drawing.Size(149, 15);
            this.Fire1.Step = 10;
            this.Fire1.TabIndex = 46;
            this.Fire1.Value = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Shooting Upgrades";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Reloading Upgrades";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(295, 84);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(295, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "0";
            // 
            // FPBtn
            // 
            this.FPBtn.Location = new System.Drawing.Point(623, 176);
            this.FPBtn.Name = "FPBtn";
            this.FPBtn.Size = new System.Drawing.Size(95, 23);
            this.FPBtn.TabIndex = 51;
            this.FPBtn.Text = "Fireball Power";
            this.FPBtn.UseVisualStyleBackColor = true;
            this.FPBtn.Click += new System.EventHandler(this.FPBtn_Click);
            // 
            // fp10
            // 
            this.fp10.AutoSize = true;
            this.fp10.BackColor = System.Drawing.Color.Transparent;
            this.fp10.Location = new System.Drawing.Point(724, 182);
            this.fp10.Name = "fp10";
            this.fp10.Size = new System.Drawing.Size(53, 13);
            this.fp10.TabIndex = 52;
            this.fp10.Text = "100 coins";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(217, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 53;
            this.label23.Text = "Fireball Power";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(295, 120);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 54;
            this.label24.Text = "0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(515, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 23);
            this.button6.TabIndex = 55;
            this.button6.Text = "Upgrades On/Off";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(622, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 23);
            this.button7.TabIndex = 56;
            this.button7.Text = "Music ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ThemeSong
            // 
            this.ThemeSong.Interval = 34000;
            this.ThemeSong.Tick += new System.EventHandler(this.ThemeSong_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 545);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.fp10);
            this.Controls.Add(this.FPBtn);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bar4);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.Fire1);
            this.Controls.Add(this.Reload1);
            this.Controls.Add(this.detail10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fa10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.s10);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.t10);
            this.Controls.Add(this.r10);
            this.Controls.Add(this.g10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.ReloadNum);
            this.Controls.Add(this.ReloadBtn);
            this.Controls.Add(this.LabelReloads);
            this.Controls.Add(this.Label_Shots);
            this.Controls.Add(this.ByTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ShootBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShootBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ByTitle;
        private System.Windows.Forms.Label Label_Shots;
        private System.Windows.Forms.Label LabelReloads;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.Label ReloadNum;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label g10;
        private System.Windows.Forms.Label r10;
        private System.Windows.Forms.Label t10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label s10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label fa10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label detail10;
        private System.Windows.Forms.Timer ReloadTimer;
        private System.Windows.Forms.Timer ShootTimer;
        private MBGlassStyleProgressBar.MBProgressBar bar3;
        private MBGlassStyleProgressBar.MBProgressBar bar4;
        private ColorProgressBar.ColorProgressBar Reload1;
        private ColorProgressBar.ColorProgressBar Fire1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button FPBtn;
        private System.Windows.Forms.Label fp10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer ThemeSong;
    }
}

