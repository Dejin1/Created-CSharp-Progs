
using Note_Mover.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Note_Mover
{
    public partial class Form3 : Form
    {
        Form1 frm1;
        public static Color Bgcolor;


        public Form3(Form1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void BgImage_Click(object sender, EventArgs e)//User Changes Program Wallpaper
        {
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "Image files|*.bmp;*.jpg;*.png";
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                frm1.BackgroundImage = Image.FromFile(FD.FileName);

                


            }

        }


        private void BgColorBtn_Click(object sender, EventArgs e)//User Changes BackGround Color
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                if (BackgroundImage != null) frm1.BackgroundImage = null;//before changing color remove background
                frm1.BackColor = colorDlg.Color;//change color
                
            }
        }

        private void TxtColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                Bgcolor = colorDlg.Color;
                frm1.ChangeTxtColor();               
            }
          }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            frm1.BackgroundImage = Properties.Resources.Default;
            frm1.ResetTxtColor();
        }
    }//Class
}//Namespace
