namespace Note_Mover
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.DownButton = new System.Windows.Forms.PictureBox();
            this.UpButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.BodyText1 = new System.Windows.Forms.Label();
            this.BodyBox1 = new System.Windows.Forms.TextBox();
            this.BodyOk = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TitleOk = new System.Windows.Forms.Button();
            this.Title1 = new System.Windows.Forms.Label();
            this.ttlBox1 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.PictureBox();
            this.Xmax = new System.Windows.Forms.Label();
            this.Ymax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.LabelAtleast = new System.Windows.Forms.Label();
            this.LDelSpots = new System.Windows.Forms.Label();
            this.DeletedListShow = new System.Windows.Forms.Button();
            this.SortList = new System.Windows.Forms.Button();
            this.OccuListShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.SpotBack = new System.Windows.Forms.Panel();
            this.ProjectBox = new System.Windows.Forms.TextBox();
            this.ProjectButtonOk = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpLegendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemePic = new System.Windows.Forms.PictureBox();
            this.ExitFullscreen = new System.Windows.Forms.Button();
            this.Optionslbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThemePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.DownButton);
            this.panel1.Controls.Add(this.UpButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Location = new System.Drawing.Point(44, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 165);
            this.panel1.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::Note_Mover.Properties.Resources.Minimize;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(5, 53);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(15, 15);
            this.Minimize.TabIndex = 12;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // DownButton
            // 
            this.DownButton.BackColor = System.Drawing.Color.Transparent;
            this.DownButton.BackgroundImage = global::Note_Mover.Properties.Resources.DownArrow;
            this.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DownButton.Image = ((System.Drawing.Image)(resources.GetObject("DownButton.Image")));
            this.DownButton.Location = new System.Drawing.Point(235, 32);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(15, 15);
            this.DownButton.TabIndex = 11;
            this.DownButton.TabStop = false;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            this.DownButton.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.DownButton.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // UpButton
            // 
            this.UpButton.BackColor = System.Drawing.Color.Transparent;
            this.UpButton.BackgroundImage = global::Note_Mover.Properties.Resources.up_arrow;
            this.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpButton.Image = ((System.Drawing.Image)(resources.GetObject("UpButton.Image")));
            this.UpButton.Location = new System.Drawing.Point(235, 10);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(15, 15);
            this.UpButton.TabIndex = 10;
            this.UpButton.TabStop = false;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            this.UpButton.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.UpButton.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Note_Mover.Properties.Resources.Add1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BackgroundImage = global::Note_Mover.Properties.Resources.maroon2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ClearBtn);
            this.panel4.Controls.Add(this.BodyText1);
            this.panel4.Controls.Add(this.BodyBox1);
            this.panel4.Controls.Add(this.BodyOk);
            this.panel4.Location = new System.Drawing.Point(21, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 102);
            this.panel4.TabIndex = 5;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(170, 48);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(41, 23);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.TabStop = false;
            this.ClearBtn.Text = "clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // BodyText1
            // 
            this.BodyText1.AutoSize = true;
            this.BodyText1.BackColor = System.Drawing.Color.Transparent;
            this.BodyText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BodyText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyText1.ForeColor = System.Drawing.SystemColors.Control;
            this.BodyText1.Location = new System.Drawing.Point(16, 9);
            this.BodyText1.MaximumSize = new System.Drawing.Size(180, 0);
            this.BodyText1.Name = "BodyText1";
            this.BodyText1.Size = new System.Drawing.Size(117, 17);
            this.BodyText1.TabIndex = 5;
            this.BodyText1.Text = "Enter info here";
            this.BodyText1.Click += new System.EventHandler(this.BodyText1_Click);
            this.BodyText1.MouseEnter += new System.EventHandler(this.Title1_MouseEnter);
            this.BodyText1.MouseLeave += new System.EventHandler(this.Title1_MouseLeave);
            // 
            // BodyBox1
            // 
            this.BodyBox1.Location = new System.Drawing.Point(19, 8);
            this.BodyBox1.MaxLength = 500;
            this.BodyBox1.Multiline = true;
            this.BodyBox1.Name = "BodyBox1";
            this.BodyBox1.Size = new System.Drawing.Size(150, 73);
            this.BodyBox1.TabIndex = 4;
            // 
            // BodyOk
            // 
            this.BodyOk.BackColor = System.Drawing.Color.Transparent;
            this.BodyOk.Location = new System.Drawing.Point(170, 19);
            this.BodyOk.Name = "BodyOk";
            this.BodyOk.Size = new System.Drawing.Size(41, 23);
            this.BodyOk.TabIndex = 3;
            this.BodyOk.TabStop = false;
            this.BodyOk.Text = "ok";
            this.BodyOk.UseVisualStyleBackColor = false;
            this.BodyOk.Click += new System.EventHandler(this.BodyOk_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BackgroundImage = global::Note_Mover.Properties.Resources.maroon2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TitleOk);
            this.panel3.Controls.Add(this.Title1);
            this.panel3.Controls.Add(this.ttlBox1);
            this.panel3.Location = new System.Drawing.Point(21, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 38);
            this.panel3.TabIndex = 4;
            // 
            // TitleOk
            // 
            this.TitleOk.BackColor = System.Drawing.Color.Transparent;
            this.TitleOk.Location = new System.Drawing.Point(184, 6);
            this.TitleOk.Name = "TitleOk";
            this.TitleOk.Size = new System.Drawing.Size(27, 23);
            this.TitleOk.TabIndex = 3;
            this.TitleOk.Text = "ok";
            this.TitleOk.UseVisualStyleBackColor = false;
            this.TitleOk.Click += new System.EventHandler(this.TitleOk_Click);
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.BackColor = System.Drawing.Color.Transparent;
            this.Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.SystemColors.Control;
            this.Title1.Location = new System.Drawing.Point(15, 4);
            this.Title1.MaximumSize = new System.Drawing.Size(250, 50);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(134, 22);
            this.Title1.TabIndex = 2;
            this.Title1.Text = "Enter Title here";
            this.Title1.Click += new System.EventHandler(this.Title1_Click);
            this.Title1.MouseEnter += new System.EventHandler(this.Title1_MouseEnter);
            this.Title1.MouseLeave += new System.EventHandler(this.Title1_MouseLeave);
            // 
            // ttlBox1
            // 
            this.ttlBox1.Location = new System.Drawing.Point(18, 8);
            this.ttlBox1.MaxLength = 17;
            this.ttlBox1.Name = "ttlBox1";
            this.ttlBox1.Size = new System.Drawing.Size(130, 20);
            this.ttlBox1.TabIndex = 5;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.BackgroundImage = global::Note_Mover.Properties.Resources.X;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(5, 12);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(15, 15);
            this.Delete.TabIndex = 9;
            this.Delete.TabStop = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            this.Delete.MouseEnter += new System.EventHandler(this.Delete_MouseEnter);
            this.Delete.MouseLeave += new System.EventHandler(this.Delete_MouseLeave);
            // 
            // Xmax
            // 
            this.Xmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Xmax.AutoSize = true;
            this.Xmax.BackColor = System.Drawing.Color.Transparent;
            this.Xmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xmax.ForeColor = System.Drawing.Color.Azure;
            this.Xmax.Location = new System.Drawing.Point(684, 57);
            this.Xmax.Name = "Xmax";
            this.Xmax.Size = new System.Drawing.Size(49, 20);
            this.Xmax.TabIndex = 1;
            this.Xmax.Text = "xMax";
            this.Xmax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Ymax
            // 
            this.Ymax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ymax.AutoSize = true;
            this.Ymax.BackColor = System.Drawing.Color.Transparent;
            this.Ymax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ymax.ForeColor = System.Drawing.Color.Azure;
            this.Ymax.Location = new System.Drawing.Point(739, 57);
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(49, 20);
            this.Ymax.TabIndex = 2;
            this.Ymax.Text = "yMax";
            this.Ymax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(594, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Screen Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabel.ForeColor = System.Drawing.Color.White;
            this.ProjectLabel.Location = new System.Drawing.Point(39, 34);
            this.ProjectLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(305, 29);
            this.ProjectLabel.TabIndex = 4;
            this.ProjectLabel.Text = "Enter Project Name Here";
            this.ProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProjectLabel.Click += new System.EventHandler(this.ProjectLabel_Click);
            this.ProjectLabel.MouseEnter += new System.EventHandler(this.Title1_MouseEnter);
            this.ProjectLabel.MouseLeave += new System.EventHandler(this.Title1_MouseLeave);
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.BackColor = System.Drawing.Color.Transparent;
            this.Xlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Xlabel.Location = new System.Drawing.Point(172, 35);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(37, 13);
            this.Xlabel.TabIndex = 5;
            this.Xlabel.Text = "Xpoint";
            this.Xlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Xlabel.Visible = false;
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.BackColor = System.Drawing.Color.Transparent;
            this.Ylabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ylabel.Location = new System.Drawing.Point(215, 34);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(37, 13);
            this.Ylabel.TabIndex = 6;
            this.Ylabel.Text = "Ypoint";
            this.Ylabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Ylabel.Visible = false;
            // 
            // LabelAtleast
            // 
            this.LabelAtleast.AutoSize = true;
            this.LabelAtleast.Location = new System.Drawing.Point(41, 74);
            this.LabelAtleast.Name = "LabelAtleast";
            this.LabelAtleast.Size = new System.Drawing.Size(45, 13);
            this.LabelAtleast.TabIndex = 7;
            this.LabelAtleast.Text = "Atleast1";
            this.LabelAtleast.Visible = false;
            // 
            // LDelSpots
            // 
            this.LDelSpots.AutoSize = true;
            this.LDelSpots.Location = new System.Drawing.Point(91, 74);
            this.LDelSpots.Name = "LDelSpots";
            this.LDelSpots.Size = new System.Drawing.Size(74, 13);
            this.LDelSpots.TabIndex = 9;
            this.LDelSpots.Text = "Deleted Spots";
            this.LDelSpots.Visible = false;
            // 
            // DeletedListShow
            // 
            this.DeletedListShow.Location = new System.Drawing.Point(631, 81);
            this.DeletedListShow.Name = "DeletedListShow";
            this.DeletedListShow.Size = new System.Drawing.Size(75, 23);
            this.DeletedListShow.TabIndex = 10;
            this.DeletedListShow.Text = "DeletedSpots";
            this.DeletedListShow.UseVisualStyleBackColor = true;
            this.DeletedListShow.Visible = false;
            this.DeletedListShow.Click += new System.EventHandler(this.DeletedListShow_Click);
            // 
            // SortList
            // 
            this.SortList.Location = new System.Drawing.Point(712, 81);
            this.SortList.Name = "SortList";
            this.SortList.Size = new System.Drawing.Size(75, 23);
            this.SortList.TabIndex = 11;
            this.SortList.Text = "Sort List";
            this.SortList.UseVisualStyleBackColor = true;
            this.SortList.Visible = false;
            this.SortList.Click += new System.EventHandler(this.SortList_Click);
            // 
            // OccuListShow
            // 
            this.OccuListShow.Location = new System.Drawing.Point(793, 81);
            this.OccuListShow.Name = "OccuListShow";
            this.OccuListShow.Size = new System.Drawing.Size(75, 23);
            this.OccuListShow.TabIndex = 12;
            this.OccuListShow.Text = "Occupied";
            this.OccuListShow.UseVisualStyleBackColor = true;
            this.OccuListShow.Visible = false;
            this.OccuListShow.Click += new System.EventHandler(this.OccuListShow_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(549, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DateTimer
            // 
            this.DateTimer.Enabled = true;
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // SpotBack
            // 
            this.SpotBack.AllowDrop = true;
            this.SpotBack.BackColor = System.Drawing.Color.Transparent;
            this.SpotBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SpotBack.BackgroundImage")));
            this.SpotBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpotBack.Location = new System.Drawing.Point(303, 125);
            this.SpotBack.Name = "SpotBack";
            this.SpotBack.Size = new System.Drawing.Size(253, 165);
            this.SpotBack.TabIndex = 14;
            this.SpotBack.Visible = false;
            // 
            // ProjectBox
            // 
            this.ProjectBox.Location = new System.Drawing.Point(44, 51);
            this.ProjectBox.Name = "ProjectBox";
            this.ProjectBox.Size = new System.Drawing.Size(287, 20);
            this.ProjectBox.TabIndex = 15;
            // 
            // ProjectButtonOk
            // 
            this.ProjectButtonOk.Location = new System.Drawing.Point(337, 51);
            this.ProjectButtonOk.Name = "ProjectButtonOk";
            this.ProjectButtonOk.Size = new System.Drawing.Size(27, 20);
            this.ProjectButtonOk.TabIndex = 16;
            this.ProjectButtonOk.Text = "ok";
            this.ProjectButtonOk.UseVisualStyleBackColor = true;
            this.ProjectButtonOk.Click += new System.EventHandler(this.ProjectButtonOk_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.New;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Note_Mover.Properties.Resources._1498589323_BT_save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.X;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.Undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.Paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullscreenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.Fullscreen;
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.Question;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpLegendToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpLegendToolStripMenuItem
            // 
            this.viewHelpLegendToolStripMenuItem.Image = global::Note_Mover.Properties.Resources.Question;
            this.viewHelpLegendToolStripMenuItem.Name = "viewHelpLegendToolStripMenuItem";
            this.viewHelpLegendToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.viewHelpLegendToolStripMenuItem.Text = "View Help Legend";
            this.viewHelpLegendToolStripMenuItem.Click += new System.EventHandler(this.viewHelpLegendToolStripMenuItem_Click);
            // 
            // ThemePic
            // 
            this.ThemePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemePic.BackColor = System.Drawing.Color.Transparent;
            this.ThemePic.BackgroundImage = global::Note_Mover.Properties.Resources.Theme;
            this.ThemePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThemePic.Location = new System.Drawing.Point(566, 60);
            this.ThemePic.Name = "ThemePic";
            this.ThemePic.Size = new System.Drawing.Size(18, 16);
            this.ThemePic.TabIndex = 19;
            this.ThemePic.TabStop = false;
            this.ThemePic.Click += new System.EventHandler(this.ThemePic_Click);
            this.ThemePic.MouseEnter += new System.EventHandler(this.ThemePic_MouseEnter);
            this.ThemePic.MouseLeave += new System.EventHandler(this.ThemePic_MouseLeave);
            // 
            // ExitFullscreen
            // 
            this.ExitFullscreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitFullscreen.Location = new System.Drawing.Point(447, 1);
            this.ExitFullscreen.Name = "ExitFullscreen";
            this.ExitFullscreen.Size = new System.Drawing.Size(84, 23);
            this.ExitFullscreen.TabIndex = 20;
            this.ExitFullscreen.Text = "ExitFullscreen";
            this.ExitFullscreen.UseVisualStyleBackColor = true;
            this.ExitFullscreen.Click += new System.EventHandler(this.ExitFullscreen_Click);
            // 
            // Optionslbl
            // 
            this.Optionslbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Optionslbl.AutoSize = true;
            this.Optionslbl.BackColor = System.Drawing.Color.Transparent;
            this.Optionslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optionslbl.ForeColor = System.Drawing.Color.Azure;
            this.Optionslbl.Location = new System.Drawing.Point(550, 79);
            this.Optionslbl.Name = "Optionslbl";
            this.Optionslbl.Size = new System.Drawing.Size(51, 13);
            this.Optionslbl.TabIndex = 21;
            this.Optionslbl.Text = "Themes";
            this.Optionslbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::Note_Mover.Properties.Resources.Default;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 398);
            this.Controls.Add(this.Optionslbl);
            this.Controls.Add(this.ExitFullscreen);
            this.Controls.Add(this.ThemePic);
            this.Controls.Add(this.ProjectButtonOk);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OccuListShow);
            this.Controls.Add(this.SortList);
            this.Controls.Add(this.DeletedListShow);
            this.Controls.Add(this.LDelSpots);
            this.Controls.Add(this.SpotBack);
            this.Controls.Add(this.LabelAtleast);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.Xlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ymax);
            this.Controls.Add(this.Xmax);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProjectBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Form1";
            this.Text = "Note Mover";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThemePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox BodyBox1;
        private System.Windows.Forms.Button BodyOk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TitleOk;
        private System.Windows.Forms.Label Xmax;
        private System.Windows.Forms.Label Ymax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ttlBox1;
        private System.Windows.Forms.Label BodyText1;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Label LabelAtleast;
        private System.Windows.Forms.PictureBox Delete;
        private System.Windows.Forms.PictureBox UpButton;
        private System.Windows.Forms.PictureBox DownButton;
        private System.Windows.Forms.Label LDelSpots;
        private System.Windows.Forms.Button DeletedListShow;
        private System.Windows.Forms.Button SortList;
        private System.Windows.Forms.Button OccuListShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Panel SpotBack;
        private System.Windows.Forms.TextBox ProjectBox;
        private System.Windows.Forms.Button ProjectButtonOk;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpLegendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.PictureBox ThemePic;
        private System.Windows.Forms.Button ExitFullscreen;
        private System.Windows.Forms.Label Optionslbl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.PictureBox Minimize;
    }
}

