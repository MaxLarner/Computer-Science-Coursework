using DocumentFormat.OpenXml.InkML;
using GemBox.Document.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Science_Coursework
{
    public partial class Form1 : Form
    {
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

            MessageBox.Show(txt_WallWidth.Text +", " + txt_WallHeight.Text, "Wall Size");

            CreateWall(WallWidth, WallHeight);
        }

        private void CreateWall(int X, int Y)
        {
            Canvas WallCanvas = new Canvas();

            WallCanvas.Background = new SolidColorBrush(Color.LightCyan);


        }
    }
}
