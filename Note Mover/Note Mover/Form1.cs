using Note_Mover.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Note_Mover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//no code


        //Point PanelMouseDownLocation;//allow user to move base panel
        Point SavedLastOccupied;
        Point NewPanelUpLocation;
        Point DefaultPoint;
        Point Home;
        

        List<Point> pointList = new List<Point>();//list of previous points of panel
        List<Point> OccupiedList = new List<Point>();//Keeps track of panel locations
        List<Point> DeletedList = new List<Point>();//Keeps track of where Panel was deleted
        



        private FormWindowState oldstate = FormWindowState.Normal;
        private FormBorderStyle oldstyle = FormBorderStyle.Sizable;
        public static int xPoint;
        public static int yPoint;
        int xStart;
        int yStart;
        DateTime createdAt;
        public int Atleast1 = 0;//Checks if atleast 1 panel is alive
        public int DeletedSpots = 0;

        //private void panel1_MouseDown_1(object sender, MouseEventArgs e)//moves panel with hold of mouse click
        //{
        //     if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        //}

        //private void panel1_MouseMove_1(object sender, MouseEventArgs e)//moves panel with hold of mouse click
        //{

        //     if (e.Button == MouseButtons.Left)

        //    {

        //          panel1.Left += e.X - PanelMouseDownLocation.X;

        //         panel1.Top += e.Y - PanelMouseDownLocation.Y;

        //    }
        //}//also need to uncheck in another location

        public void Form1_Load(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////

            if (Settings.Default.ProjectLabel != ""&& Settings.Default.ProjectLabel != null)//Restores Title Name from Previous Session
            {
               ProjectLabel.Text = Settings.Default.ProjectLabel;
            }

            Size = Settings.Default.FormSize;//Restores Form Size from Previous Session

            Optionslbl.Hide();//dont show this label until later.
            //////////////////////////////////////////////////////////////////


            xPoint = this.Height / 25;      //set loc of box
            yPoint = this.Width / 12;       //set loc of box
            xStart = this.Height / 25;      //stays the same to get start location
            yStart = this.Width / 12;       //stays the same to get start location

            Home = new Point(xStart, yStart);

            Xlabel.Text = xPoint.ToString();//shows where panel X location is.
            Ylabel.Text = yPoint.ToString();//shows where panel Y location is.

            Xmax.Text = this.Height.ToString(); //tells window height
            Ymax.Text = this.Width.ToString();  //tells window width

            ttlBox1.Hide();                     //hidden till needed.
            BodyBox1.Hide();                    //hidden till needed.
            TitleOk.Hide();                     //hidden till needed.
            BodyOk.Hide();                      //hidden till needed.
            ClearBtn.Hide();                      //hidden till needed.
            ProjectBox.Hide();                  //hidden till needed.
            ProjectButtonOk.Hide();             //hidden till needed.
            ExitFullscreen.Hide();              //hidden till needed.

            DefaultPoint = new Point(xPoint, yPoint);//Used to Allowfirst panel loc to be showed as Occupied
            OccupiedList.Add(DefaultPoint);              //adds to list
            panel1.Location = DefaultPoint;              //Set the starting location of Panel1
            
            
        }
    

        private void Title1_Click(object sender, EventArgs e)//label Title 1
        {
            Label titleLabel = (Label)sender;
            titleLabel.Hide();

            Panel parent = (Panel)titleLabel.Parent;

            Button titleButton = parent.Controls.OfType<Button>().First();
            titleButton.Show();

            TextBox titleBox = parent.Controls.OfType<TextBox>().First();
            titleBox.Show();
            titleBox.Select();
        }

        private void BodyText1_Click(object sender, EventArgs e)
        {
            Label bodyLabel = (Label)sender;
            bodyLabel.Hide();

            Panel parent = (Panel)bodyLabel.Parent;

            Button bodyButton = parent.Controls.OfType<Button>().First();//Clear button Show
            bodyButton.Show();

            Button bodyButton2 = parent.Controls.OfType<Button>().Last();//Ok Button Show
            bodyButton2.Show();

            TextBox bodyBox = parent.Controls.OfType<TextBox>().First();
            bodyBox.Show();
            bodyBox.Select();
        }

        private void BodyOk_Click(object sender, EventArgs e)
        {
            Panel parent = (Panel)((Button)sender).Parent;

            TextBox bodyBox = parent.Controls.OfType<TextBox>().First();
            Label bodyLabel = parent.Controls.OfType<Label>().First();

            if (!string.IsNullOrWhiteSpace(bodyBox.Text))//makes sure user inputs text
            {
                bodyLabel.Text = bodyBox.Text;//if text is entered make box txt = label txt
            }

            
            bodyLabel.Show();

           // ((Button)sender).Hide();

            var c = GetAll(parent, typeof(Button));     //Identify Buttons in Form1
            foreach (var button in c)                 //tell them all to
            button.Hide();                            //Hide


            bodyBox.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//Add new Panel + icon
        {
            if ((DateTime.Now - createdAt) > TimeSpan.FromSeconds(0.1))
            {
                PictureBox pictureBoxAdd = (PictureBox)sender;
                var parent = (Panel)pictureBoxAdd.Parent;
                //pictureBoxAdd.Click -= pictureBox1_Click;
                CopyPanel(parent);
                createdAt = DateTime.Now;
            }
            //foreach (var points in OccupiedList)
            //{
            //     MessageBox.Show(points.ToString());

            //}
        }

        

        public void SortListMethod()
        {
            OccupiedList = OccupiedList.OrderBy(p => p.Y)
                      .ThenBy(p => p.X)
                      .ToList();
        }

        public void CopyPanel(Panel originalPanel)//Clone Machine
        {
            
            //////////////////////////////////////////////////////////////////////////
            Panel rootPanel = UICloner.ClonePanel(originalPanel);
            //////////////////////////////////////////////////////////////////////////Clone PictureBoxes

            PictureBox addBtnPic = UICloner.CloneAddPicture(pictureBox1);
            addBtnPic.Click += pictureBox1_Click;
            addBtnPic.MouseEnter += Delete_MouseEnter;
            addBtnPic.MouseLeave += Delete_MouseLeave;
            rootPanel.Controls.Add(addBtnPic);

            PictureBox DeleteBtnPic = UICloner.CloneAddPicture(Delete);
            DeleteBtnPic.Click += Delete_Click;
            DeleteBtnPic.Click += SortList_Click;
            DeleteBtnPic.MouseEnter += Delete_MouseEnter;
            DeleteBtnPic.MouseLeave += Delete_MouseLeave;
            rootPanel.Controls.Add(DeleteBtnPic);

            PictureBox UpButtonPic = UICloner.CloneAddPicture(UpButton);
            UpButtonPic.Click += UpButton_Click;
            UpButtonPic.MouseEnter += Delete_MouseEnter;
            UpButtonPic.MouseLeave += Delete_MouseLeave;
            rootPanel.Controls.Add(UpButtonPic);

            PictureBox DownBtnPic = UICloner.CloneAddPicture(DownButton);
            DownBtnPic.Click += DownButton_Click;
            DownBtnPic.MouseEnter += Delete_MouseEnter;
            DownBtnPic.MouseLeave += Delete_MouseLeave;
            rootPanel.Controls.Add(DownBtnPic);

            PictureBox MinimizePic = UICloner.CloneAddPicture(Minimize);
            MinimizePic.Click += Minimize_Click;
            MinimizePic.MouseEnter += Delete_MouseEnter;
            MinimizePic.MouseLeave += Delete_MouseLeave;
            rootPanel.Controls.Add(MinimizePic);


            ///////////////////////////////////////////////////////////////////////////Clone Labels
            Panel firstPanel = UICloner.ClonePanel(panel3);           
            Button titleButton = UICloner.CloneButton(TitleOk);
            titleButton.Click += TitleOk_Click;
            firstPanel.Controls.Add(titleButton);
            TextBox titleBox = UICloner.CloneTextBox(ttlBox1);                              
            firstPanel.Controls.Add(titleBox);

            rootPanel.Controls.Add(firstPanel);

            Panel secondPanel = UICloner.ClonePanel(panel4);
            /////////////////////////////////////////////////////////This Keeps the Text of Labels Defaulted
            Label infoLabel = new Label();
            infoLabel.BackColor = Color.Transparent;
            infoLabel.ForeColor = Color.White;
            infoLabel.Text = "Enter info here";             
            infoLabel.Font = BodyText1.Font;
            infoLabel.Location = BodyText1.Location;
            infoLabel.AutoSize = true;
            infoLabel.Click += BodyText1_Click;
            infoLabel.MouseEnter += Title1_MouseEnter;
            infoLabel.MouseLeave += Title1_MouseLeave;
            secondPanel.Controls.Add(infoLabel);
            /////////////////////////////////////////////////////////This Keeps the Text of Labels Defaulted
            Label titleLabel = new Label();
            titleLabel.BackColor = Color.Transparent;
            titleLabel.ForeColor = Color.White;
            titleLabel.Text = "Enter Title here";
            titleLabel.Font = Title1.Font;
            titleLabel.Location = Title1.Location;
            titleLabel.AutoSize = true;           
            titleLabel.Click += Title1_Click;
            titleLabel.MouseEnter += Title1_MouseEnter;
            titleLabel.MouseLeave += Title1_MouseLeave;
            firstPanel.Controls.Add(titleLabel);
            ////////////////////////////////////////////////////////Clone Body Ok Btn

            Button infoButton = UICloner.CloneButton(BodyOk);
            infoButton.Click += BodyOk_Click;                      
            secondPanel.Controls.Add(infoButton);

            ////////////////////////////////////////////////////////Clone Body Ok Btn

            Button clearButton = UICloner.CloneButton(ClearBtn);
            clearButton.Click += ClearBtn_Click;
            secondPanel.Controls.Add(clearButton);


            ////////////////////////////////////////////////////////Clone Body TextBox 

            TextBox bodyBox = UICloner.CloneTextBox(BodyBox1);
            secondPanel.Controls.Add(bodyBox);                      


            ///////////////////////////////////////////////////////////////////////

            rootPanel.Controls.Add(secondPanel);                    //add a child panel to the main panel

            ///////////////////////////////////////////////////////////////////////    
                                                                           
            //Button up = UICloner.CloneButton(UpButton);
            //up.Click += UpButton_Click;                                  //Clone Up Btn
            //rootPanel.Controls.Add(up);

            //Button down = UICloner.CloneButton(DownButton);
            //down.Click += DownButton_Click;                              //Clone Dwn Btn
            //rootPanel.Controls.Add(down);

            ///////////////////////////////////////////////////////////////////////

            
            while (true)
            {
                if (DeletedSpots > 0)
                {
                    Point DeletedLast = DeletedList.Last();
                    Point DeleteNull = new Point(0, 0);
                    int xPoint = DeletedLast.X;
                    int yPoint = DeletedLast.Y;


                    Point newLocation2 = new Point(xPoint, yPoint);
                    DeletedList.Remove(DeletedLast);
                    DeletedSpots -= 1;
                    LDelSpots.Text = DeletedSpots.ToString();
                    OccupiedList.Remove(DeleteNull);//Teleportation From here
                    if (OccupiedList.Contains(newLocation2))
                    {
                        continue;
                    }
                    else
                    {
                        OccupiedList.Add(newLocation2);
                        rootPanel.Location = newLocation2;
                        break;
                    }
                }
                else
                {
                    SortListMethod();
                    Point lastLocation = OccupiedList.Last();
                    SavedLastOccupied = OccupiedList.Last();
                    int xPoint = lastLocation.X;
                    int yPoint = lastLocation.Y;

                    if (xPoint < 900)
                    {
                        xPoint += 259;
                    }
                    else
                    {
                        xPoint = xStart;
                        yPoint = yPoint + 180;
                    }
                    Point newLocation = new Point(xPoint, yPoint);
                    OccupiedList.Add(newLocation);
                    SavedLastOccupied = newLocation;
                    rootPanel.Location = newLocation;
                    break;
                }

                //OccupiedList.Add(SavedLastOccupied);//To Finally Teleporting Here

            }

                this.Controls.Add(rootPanel);

                

                Atleast1 += 1;
                
                LabelAtleast.Text = Atleast1.ToString();

                SortListMethod();//Sorts Occupied list
                

            }

        
        ////////////////////////////////////////////////////////////////////////////////////////
        
        public IEnumerable<Control> GetAll(Control control, Type type)//Find Controls
        {
            var controls = control.Controls.Cast<Control>();
                                                                            
            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);//Make a change to these controls by using code below.
        }

             //var c = GetAll(this, typeof(Label));     //Identify ALL LABELS in Form1
             //foreach (var label in c)                 //tell them all to
             //   label.ForeColor = Form3.Bgcolor;      //Change color
        ////////////////////////////////////////////////////////////////////////////////////////

        private void TitleOk_Click(object sender, EventArgs e)//Title 1 OK button
        {
            Button titleOk = (Button)sender;
            Panel parent = (Panel)titleOk.Parent;

            TextBox titleBox = parent.Controls.OfType<TextBox>().First();
            Label titleLabel = parent.Controls.OfType<Label>().First();

            if (!string.IsNullOrWhiteSpace(titleBox.Text))//makes sure user inputs text
            {
                titleLabel.Text = titleBox.Text;//if text is entered make box txt = label txt
            }


            titleLabel.Show();
            titleBox.Hide();
            titleOk.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
            if (Atleast1 > 0)
            {
                
                PictureBox pictureBoxDelete = (PictureBox)sender;
                var parent1 = (Panel)pictureBoxDelete.Parent;
                pictureBoxDelete.Click -= Delete_Click;
                Point DeletedPoint = parent1.Location;
                this.Controls.Remove(parent1);

                if (parent1.Location != OccupiedList.Last())
                {
                    DeletedList.Add(DeletedPoint);
                    DeletedSpots += 1;
                   
                }
                if (parent1.Location == OccupiedList.Last())
                {
                    OccupiedList.Remove(OccupiedList.Last());
                    //DeletedList.Add(DeletedPoint);
                    //DeletedSpots += 1;
                    

                }

                OccupiedList.Remove(parent1.Location);
                Atleast1 -= 1;

                
            }
            LabelAtleast.Text = Atleast1.ToString();
            LDelSpots.Text = DeletedSpots.ToString();
      
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBoxDelete = (PictureBox)sender;           
            pictureBoxDelete.Cursor = Cursors.Hand;
            Size size = new Size(16, 16);
            pictureBoxDelete.Size = size;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBoxDelete = (PictureBox)sender;           
            pictureBoxDelete.Cursor = Cursors.Default;
            Size size = new Size(15, 15);
            pictureBoxDelete.Size = size;
        }

        private void displayTime()
        {
            label3.Text = DateTime.Now.ToString("f");
        }

        private void SortList_Click(object sender, EventArgs e)
        {
            List<Point> OccuList = new List<Point>();

            ////////////////////////////////////////////////
            foreach (var points in OccupiedList.ToList())
            {
                OccuList.Add(points);
            }
            ///////////////////////////////////////////////

            var sorted = OccupiedList.OrderBy(p => p.Y)
                      .ThenBy(p => p.X);

            OccupiedList.AddRange(sorted);

            ////////////////////////////////////////////////
            foreach (var pointz in OccuList.ToList())
            {
                OccupiedList.Remove(pointz);
            }
            ///////////////////////////////////////////////

            //foreach (var points in OccupiedList)
            //{

            //    MessageBox.Show(points.ToString());

            //}
        }

        private void DeletedListShow_Click(object sender, EventArgs e)
        {
            SortListMethod();
            foreach (var points in DeletedList)
            {
                MessageBox.Show(points.ToString());

            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void OccuListShow_Click(object sender, EventArgs e)
        {
            foreach (var points in OccupiedList)
            {

                MessageBox.Show(points.ToString());

            }
        }

        private void Title1_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Cursor = Cursors.Hand;
            var LblSize = (label.Font.Size +1);
            label.Font = new Font("Microsoft Sans Serif", LblSize, FontStyle.Bold); 
            
        }

        private void Title1_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Cursor = Cursors.Default;
            var LblSize = (label.Font.Size - 1);
            label.Font = new Font("Microsoft Sans Serif", LblSize, FontStyle.Bold | FontStyle.Underline);
           
        }

        private void RemoveEmptyLastSpot()
        {
            Panel lastPanel = this.Controls.OfType<Panel>().Last();
            Point lastLocation = lastPanel.Location;

            int xPoint = lastLocation.X;
            int yPoint = lastLocation.Y;

            if (xPoint < 900)
            {
                xPoint += 259;
            }
            else
            {
                xPoint = xStart;
                yPoint = yPoint + 180;
            }
            Point newLocation = new Point(xPoint, yPoint);
            //if (OccupiedList.Contains(newLocation))
            //{
            //    OccupiedList.Remove(newLocation);
            //}
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            displayTime();
            Xmax.Text = this.Height.ToString(); //tells window height
            Ymax.Text = this.Width.ToString();  //tells window width
        }

        private void UpButton_Click(object sender, EventArgs e)//move panel to previous location and defaults it to start location
        {

            if (DeletedSpots > 0 || Atleast1 == 0)
            {

                PictureBox UpButton = (PictureBox)sender;//Figures out which panel upBtn is clicked to do the action for that panel
                Panel panel = (Panel)UpButton.Parent;//Finds the parent of the Panel
                Point ParentLoc = panel.Location;



                SortListMethod();
                Point lastLocation = OccupiedList.Last();
                if (lastLocation != ParentLoc)
                {
                    DeletedSpots += 1;
                    DeletedList.Add(ParentLoc);
                    LDelSpots.Text = DeletedSpots.ToString();
                }

                if (panel.Location != new Point(this.Height / 25, this.Width / 12))//Some reason doesnt work when put in xPoint Ypoint variables

                {
                    int xPoint = panel.Location.X;
                    int yPoint = panel.Location.Y;
                    CheckAgain:

                    if (OccupiedList.Contains(panel.Location) && Atleast1 != 0)
                    {
                        if (xPoint > 29)
                        {
                            xPoint -= 259;
                        }
                        else
                        {
                            if (yPoint > yStart)
                            {

                                yPoint = yPoint - 180;
                            }
                            xPoint = 1065;
                        }
                        panel.Location = new Point(xPoint, yPoint);
                        goto CheckAgain;

                    }
                    ////////////////////////////////////////////////////
                    else if (Atleast1 == 0)
                    {
                        if (xPoint > 29)
                        {
                            xPoint -= 259;
                        }
                        else
                        {
                            if (yPoint > yStart)
                            {

                                yPoint = yPoint - 180;
                            }
                            xPoint = 1065;
                        }
                        panel.Location = new Point(xPoint, yPoint);

                    }
                    ////////////////////////////////////////////////////
                }
                if (OccupiedList.Count > 0)
                {
                    OccupiedList.Remove(ParentLoc);//new CODE
                }
                NewPanelUpLocation = new Point(panel.Location.X, panel.Location.Y);
                OccupiedList.Add(NewPanelUpLocation);//new CODE



                SortListMethod();
                Point lastPanelLocation = OccupiedList.Last();

                ///////////////////////////////////////////////////////////
                if (DeletedList.Contains(NewPanelUpLocation))
                {
                    DeletedList.Remove(NewPanelUpLocation);//New Code
                    DeletedSpots -= 1;
                    LDelSpots.Text = DeletedSpots.ToString();
                }
                ///////////////////////////////////////////////////////
                if (DeletedSpots == 0)
                {
                    DeletedList.Clear();
                }

                Xlabel.Text = xPoint.ToString();//updates location of panel
                Ylabel.Text = yPoint.ToString();//""
                LDelSpots.Text = DeletedSpots.ToString();
            }
            if (Atleast1 == 0 && NewPanelUpLocation == Home)
            {
                DeletedSpots = 0;//Fix an error When One Panel is Alone
                LDelSpots.Text = DeletedSpots.ToString();
            }

        }

        private void DownButton_Click(object sender, EventArgs e)
        {

            PictureBox DownButton = (PictureBox)sender;//finds out which Panels down btn was clicked
            Panel panel = (Panel)DownButton.Parent;//Makes that Panel the One to be acted upon
            Point ParentLoc = panel.Location;
            //////////////////////////////////////////
            Point DeletedPoint = ParentLoc;



            DeletedList.Add(DeletedPoint);
            DeletedSpots += 1;
            LDelSpots.Text = DeletedSpots.ToString();


            ////////////////////////////////////////////
            int xPoint = panel.Location.X;
            int yPoint = panel.Location.Y;
            CheckAgain:
            ////////////////////////////////////////
            if (OccupiedList.Contains(panel.Location) && Atleast1 != 0)
            {
                if (xPoint < 900)
                {
                    xPoint += 259;
                }
                else
                {
                    xPoint = xStart;
                    yPoint = yPoint + 180;

                }
                Point newLocation = new Point(xPoint, yPoint);
                if (DeletedList.Contains(newLocation))
                {
                    DeletedList.Remove(newLocation);
                    DeletedSpots -= 1;
                    LDelSpots.Text = DeletedSpots.ToString();
                }
                panel.Location = newLocation;
                goto CheckAgain;
            }
            ////////////////////////////////////////////////
            else if (Atleast1 == 0)
            {
                if (xPoint < 900)
                {
                    xPoint += 259;
                }
                else
                {
                    xPoint = xStart;
                    yPoint = yPoint + 180;
                }
            }
            /////////////////////////////////////////////////////////////

            if (OccupiedList.Count >= 1)
            {
                OccupiedList.Remove(ParentLoc);//new CODE
            }

            /////////////////////////////////////////////////////////////
            panel.Location = new Point(xPoint, yPoint);
            pointList.Add(new Point(panel.Location.X, panel.Location.Y));
            OccupiedList.Add(new Point(panel.Location.X, panel.Location.Y));


            Xlabel.Text = xPoint.ToString();
            Ylabel.Text = yPoint.ToString();



        }

        private void ProjectLabel_Click(object sender, EventArgs e)
        {
            ProjectLabel.Hide();
            ProjectBox.Show();
            ProjectButtonOk.Show();
        }

        private void ProjectButtonOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProjectBox.Text))//makes sure user inputs text
            {
                ProjectLabel.Text = ProjectBox.Text;//if text is entered make box txt = label txt
                Settings.Default.ProjectLabel = ProjectLabel.Text;
            }
            
            ProjectBox.Hide();                  
            ProjectButtonOk.Hide();
            ProjectLabel.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Note Mover:\n\n Created By: Joshua Quercia With Special thanks to Tim");
        }

        private void viewHelpLegendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.TopMost = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*" ;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //textBox2.Text = "ok";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }//Work in Progress

        private void ThemePic_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();

           

            //var AllLabels = GetAll(this, typeof(Label));
            //foreach (var xLbl in AllLabels)
            //{
            //    xLbl.ForeColor = Color.Black;
            //}



        }

        private void ThemePic_MouseEnter(object sender, EventArgs e)
        {
            Size size = new Size(22, 20);
            ThemePic.Size = size;
            ThemePic.Cursor = Cursors.Hand;
            Optionslbl.Show();
        }

        private void ThemePic_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(18, 16);
            ThemePic.Size = size;
            ThemePic.Cursor = Cursors.Arrow;
            Optionslbl.Hide();
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            oldstate = this.WindowState;
            oldstyle = this.FormBorderStyle;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            
            ExitFullscreen.Show();
            menuStrip1.Hide();
            Taskbar.Hide();
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ExitFullscreen_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.FormBorderStyle = oldstyle;
            this.WindowState = oldstate;
            menuStrip1.Show();
            ExitFullscreen.Hide();
            Taskbar.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FormSerialisor.Serialise(this, Application.StartupPath + @"\serialise.xml");
            Settings.Default["FormSize"] = this.Size;
            Settings.Default.Save();
        }

       
        public void ChangeTxtColor()//Gets user defined color from form 3 and changes all labels in Form1's color
            {
             var c = GetAll(this, typeof(Label));     //Identify ALL LABELS in Form1
             foreach (var label in c)                 //tell them all to
                label.ForeColor = Form3.Bgcolor;      //Change color to user defined color in form3
            }

        public void ResetTxtColor()//Gets user defined color from form 3 and changes all labels in Form1's color
        {
            var c = GetAll(this, typeof(Label));                     //Identify ALL LABELS in Form1
            foreach (var label in c)                                 //tell them all to
                label.ForeColor = Color.FromArgb(255, 255, 255);     //Change color to default(White)
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl.GetType() == typeof(TextBox))
            {
                TextBox textBox = (TextBox)this.ActiveControl;
                Clipboard.SetText(textBox.Text);

            }
            
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                if (this.ActiveControl.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)this.ActiveControl;
                    String text = Clipboard.GetText();
                    int pos = textBox.SelectionStart;
                    textBox.Text = textBox.Text.Insert(pos, text);
                    //Fix cursor position
                    textBox.Focus();
                    textBox.SelectionStart = pos;
                    textBox.SelectionLength = text.Length;
                }
            }
        }
        ///////////////////////////////////////////
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Label label = (Label)sender;
            if (label.ContainsFocus && e.Control && e.KeyCode == Keys.C)
                Clipboard.SetText(label.Text);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Button ButtonClear = (Button)sender;
            var parent1 = (Panel)ButtonClear.Parent;

            foreach (Control c in parent1.Controls)
            {
                
                    if (c is TextBox)
                    {
                        c.Text = String.Empty;

                    }                   
                
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            PictureBox pictureBoxMinimize = (PictureBox)sender;
            var parent1 = (Panel)pictureBoxMinimize.Parent;

            foreach (Control c in parent1.Controls)
            {
                if (c is Panel && c.Size == new Size(214, 102))
                    if (c.Visible == true)
                    {
                        c.Hide();
                        parent1.BorderStyle = BorderStyle.None;
                    }
                    else
                    {
                        c.Show();
                        parent1.BorderStyle = BorderStyle.FixedSingle;
                    }
            }
        }


        ///////////////////////////////////////////////
    }//Class
}//Namespace