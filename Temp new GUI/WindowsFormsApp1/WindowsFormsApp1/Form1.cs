using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Math;
using AForge;
using AForge.Math.Geometry;
using AForge.Imaging.Filters;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string bilde = "C:/temp/temp1.jpg";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PB1.Image = System.Drawing.Image.FromFile(bilde);
            Bitmap bitmap = new Bitmap(bilde);
            // gather statistics
            ImageStatistics stat = new ImageStatistics(AForge.Imaging.Image.FromFile(bilde));
            Histogram red = stat.Red;
            Histogram blue = stat.Blue;
            Histogram green = stat.Green;
            MessageBox.Show(red.Mean.ToString() + "\n" + blue.Mean.ToString() + "\n" + green.Mean.ToString());
            MessageBox.Show(red.Median.ToString() + "\n" + blue.Median.ToString() + "\n" + green.Median.ToString());


            // create filter
            ColorFiltering filter = new ColorFiltering();
            // set color ranges to keep
            filter.Red = new IntRange(200, 255);
            filter.Green = new IntRange(200, 255);
            filter.Blue = new IntRange(200, 255);
            // apply the filter
            filter.ApplyInPlace(bitmap);
            PB1.Image = bitmap;
        }
        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }

            return array;
        }

    }
}
