using Note_Mover;
using System.Windows.Forms;

namespace Note_Mover
{
    public class UICloner
    {
        public static Label CloneHeaderLabel(Label source)
        {
            var clone = new Label();
            clone.BackColor = source.BackColor;
            clone.ForeColor = source.ForeColor;
            clone.Location = source.Location;
            clone.Text = source.Text;
            clone.Font = source.Font; 
            clone.TabIndex = source.TabIndex;
            clone.Size = source.Size;
            clone.MaximumSize = source.MaximumSize;
            clone.TextAlign = source.TextAlign;
            return clone;
        }

        public static TextBox CloneTextBox(TextBox source)
        {
            var clone = new TextBox();
            clone.Location = new System.Drawing.Point(19, 8);
            clone.MaxLength = 500;
            clone.Multiline = true;
            clone.Size = new System.Drawing.Size(159, 73);
            clone.TabIndex = 4;
            clone.Visible = source.Visible;
            return clone;
        }

        public static PictureBox CloneAddPicture(PictureBox source)
        {
            PictureBox clone = new PictureBox();
            clone.Location = source.Location;
            clone.Size = source.Size;
            clone.BackColor = source.BackColor;
            clone.BackgroundImage = source.BackgroundImage;
            clone.BackgroundImageLayout = source.BackgroundImageLayout;
            clone.Image = source.Image;
            return clone;
        }

        public static Panel ClonePanel(Panel source)
        {
            Panel copy = new Panel();
            copy.BackColor = source.BackColor;
            copy.BackgroundImage = source.BackgroundImage;
            copy.BackgroundImageLayout = source.BackgroundImageLayout;
            copy.BorderStyle = source.BorderStyle;
            copy.Location = source.Location;
            copy.Size = source.Size;
            return copy;
        }

        public static Label CloneLabel(Label source)
        {
            var clone = new Label();
            clone.BackColor = source.BackColor;
            clone.ForeColor = source.ForeColor;
            clone.Location = source.Location;
            clone.Text = source.Text;
            clone.Font = source.Font; 
            clone.TabIndex = source.TabIndex;
            clone.Size = source.Size;
            clone.MaximumSize = source.MaximumSize;
            clone.TextAlign = source.TextAlign;
            return clone;
        }

        public static Button CloneButton(Button source)
        {
            var clone = new Button();
            clone.BackColor = source.BackColor;
            clone.ForeColor = source.ForeColor;                //Buttons working
            clone.Location = source.Location;
            clone.Text = source.Text;
            clone.Size = source.Size;
            clone.Visible = source.Visible;
            return clone;
        }
    }
}
