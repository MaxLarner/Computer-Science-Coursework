using DocumentFormat.OpenXml.InkML;
using GemBox.Document.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Computer_Science_Coursework
{
    public partial class Form1 : Form
    {
        int HoldCount = 0;
        bool Red = false;
        bool Green = false;
        bool Blue = false;
        Panel WallPanel = new Panel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_WallSubmit_Click(object sender, EventArgs e)
        {
            int WallWidth = int.Parse(txt_WallWidth.Text);
            int WallHeight = int.Parse(txt_WallHeight.Text);

            MessageBox.Show(txt_WallWidth.Text + ", " + txt_WallHeight.Text, "Wall Size");

            CreateWall(WallWidth, WallHeight);
        }

        private void CreateWall(int X, int Y)
        { 
            WallPanel.Location = new System.Drawing.Point(300, 50);
            WallPanel.Name = "pnl_ClimbingWall";
            WallPanel.Size = new System.Drawing.Size(X, Y);
            WallPanel.BackColor = Color.LightGreen;
            WallPanel.MouseClick+=WallPanel_Click;
            Controls.Add(WallPanel);
        }

        private void AddHold(int x, int y, PictureBox pctBox_Hold)
        {
            
            pctBox_Hold.Name = "pctBox_Hold" + Convert.ToString(HoldCount);
            pctBox_Hold.Location = new Point(x, y);
            HoldCount++;
            WallPanel.Controls.Add(pctBox_Hold);
        }

        private void WallPanel_Click(object sender, MouseEventArgs e)
        {
            int xMouseClick = e.X;
            int yMouseClick = e.Y;

            MessageBox.Show(Convert.ToString(xMouseClick), Convert.ToString(yMouseClick));

            PictureBox pctBox_Temp = new PictureBox();

            if (Blue == true)
            {
                pctBox_Temp = pctBox_BlueHold;
                pctBox_Temp.Paint += new PaintEventHandler(pctBox_BlueHold_Paint);
            }
            else if (Green == true)
            {
                pctBox_Temp = pctBox_GreenHold;
                pctBox_Temp.Paint += new PaintEventHandler(pctBox_GreenHold_Paint);
            }
            else if (Red == true)
            {
                pctBox_Temp = pctBox_RedHold;
                pctBox_Temp.Paint += new PaintEventHandler(pctBox_RedHold_Paint);
            }

            AddHold(xMouseClick, yMouseClick, pctBox_Temp);
        }

        public void pctBox_GreenHold_Click(object sender, EventArgs e)
        {
            // Creates a picturebox called pctBox_GreenHold
            PictureBox pctBox_GreenHold = new PictureBox();
            Green = true;
            Red = false;
            Blue = false;
        }

        private void pctBox_GreenHold_Paint(object sender, PaintEventArgs e)
        {
            pctBox_GreenHold.BackColor = Color.Green;

            GraphicsPath pctBox_Path = new GraphicsPath();

            // The points of the rhombus in n array, creates the polygon
            Point[] Rhombus =
                {
                    new Point(23, 20),
                    new Point(40, 10),
                    new Point(57, 20),
                    new Point(50, 40),
                    new Point(30, 40)
                    };

            // Adds the rhombus to the graphics path
           
            pctBox_Path.AddPolygon(Rhombus);

            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_GreenHold.Region = new Region(pctBox_Path);

            MessageBox.Show("Green Clicked");
        }

        public void pctBox_BlueHold_Click(object sender, EventArgs e)
        {
            PictureBox pctBox_BlueHold = new PictureBox();
            Green = false;
            Blue = true;
            Red = false;
            // Creating a rhombus picture box
            
            MessageBox.Show("Blue Clicked");
        }

        public void pctBox_BlueHold_Paint(object sender, PaintEventArgs e)
        {
            // Creates a picturebox called pctBox_GreenHold
            pctBox_BlueHold.BackColor = Color.Blue;

            GraphicsPath pctBox_Path = new GraphicsPath();

            // The points of the rhombus in n array, creates the polygon
            Point[] Rhombus =
                {
                    new Point(23, 20),
                    new Point(40, 10),
                    new Point(57, 20),
                    new Point(50, 40),
                    new Point(30, 40)
                    };

            // Adds the rhombus to the graphics path

            pctBox_Path.AddPolygon(Rhombus);

            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_BlueHold.Region = new Region(pctBox_Path);

            MessageBox.Show("Blue Clicked");
        }

        public void pctBox_RedHold_Click(object sender, EventArgs e)
        {
            PictureBox pctBox_RedHold = new PictureBox();
            Green = false;
            Red = true;
            Blue = false;
        }

        public void pctBox_RedHold_Paint(object sender, PaintEventArgs e)
        {
            // Creates a picturebox called pctBox_GreenHold
            pctBox_RedHold.BackColor = Color.Red;

            GraphicsPath pctBox_Path = new GraphicsPath();

            // The points of the rhombus in n array, creates the polygon
            Point[] Rhombus =
                {
                    new Point(23, 20),
                    new Point(40, 10),
                    new Point(57, 20),
                    new Point(50, 40),
                    new Point(30, 40)
                    };

            // Adds the rhombus to the graphics path

            pctBox_Path.AddPolygon(Rhombus);

            //the region of the picturebox is now set to the shape of the graphics path
            pctBox_RedHold.Region = new Region(pctBox_Path);

            MessageBox.Show("Red Clicked");
        }
    }
}
