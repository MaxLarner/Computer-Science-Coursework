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
            
            pctBox_Hold.Name = "pnl_Hold" + Convert.ToString(HoldCount);
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
            }
            else if (Green == true)
            {
                pctBox_Temp = pctBox_BlueHold;
            }
            else if (Red == true)
            {
                pctBox_Temp = pctBox_GreenHold;
            }

            AddHold(xMouseClick, yMouseClick, pctBox_Temp);
        }
        public void pctBox_GreenHold_Click(object sender, EventArgs e)
        {
            Green = true;
            Red = false;
            Blue = false;
            ///
            PictureBox pctBox_GreenHold = new PictureBox();

            System.Drawing.Drawing2D.GraphicsPath pictureBoxPath = new System.Drawing.Drawing2D.GraphicsPath();

            System.Drawing.Rectangle newRectangle = pctBox_GreenHold.ClientRectangle;

            Point point1 = new Point(50, 0);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(50, 50);
            Point point4 = new Point(0, 25);
            Point[] rhombus = { point1, point2, point3, point4 };

            pictureBoxPath.AddPolygon(rhombus);

            pctBox_GreenHold.Region = new System.Drawing.Region(pictureBoxPath);
            pctBox_GreenHold.BackColor = Color.AliceBlue;

            MessageBox.Show("Green Clicked");
        }

        public void pctBox_BlueHold_Click(object sender, EventArgs e)
        {
            Green = false;
            Blue = true;
            Red = false;
            // Creating a rhombus picture box

            PictureBox pctBox_BlueHold = new PictureBox();

            System.Drawing.Drawing2D.GraphicsPath pictureBoxPath = new System.Drawing.Drawing2D.GraphicsPath();
            
            System.Drawing.Rectangle newRectangle = pctBox_BlueHold.ClientRectangle;
            
            Point point1 = new Point(50, 0); 
            Point point2 = new Point(100, 25); 
            Point point3 = new Point(50, 50); 
            Point point4 = new Point(0, 25); 
            Point[] rhombus = { point1, point2, point3, point4 };
            
            pictureBoxPath.AddPolygon(rhombus);

            pctBox_BlueHold.Region = new System.Drawing.Region(pictureBoxPath);
            pctBox_BlueHold.BackColor = Color.AliceBlue;
            
            MessageBox.Show("Blue Clicked");
        }

        public void pctBox_RedHold_Click(object sender, EventArgs e)
        {
            Green = false;
            Red = true;
            Blue = false;
            ///
            PictureBox pctBox_RedHold = new PictureBox();

            System.Drawing.Drawing2D.GraphicsPath pictureBoxPath = new System.Drawing.Drawing2D.GraphicsPath();

            System.Drawing.Rectangle newRectangle = pctBox_RedHold.ClientRectangle;

            Point point1 = new Point(50, 0);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(50, 50);
            Point point4 = new Point(0, 25);
            Point[] rhombus = { point1, point2, point3, point4 };

            pictureBoxPath.AddPolygon(rhombus);

            pctBox_RedHold.Region = new System.Drawing.Region(pictureBoxPath);
            pctBox_RedHold.BackColor = Color.Red;

            MessageBox.Show("Red Clicked");
        }
    }
}
