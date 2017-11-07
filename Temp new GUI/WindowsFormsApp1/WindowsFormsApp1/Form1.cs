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
        string bilde = "C:/temp/temp3.jpg";
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


            //lager en grey scale av bildet. kan flyttes når vi finner firkant 90%+ av tida
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap GrayBM = filter.Apply(bitmap);
            

            // gather statistics
            ImageStatistics stat = new ImageStatistics(AForge.Imaging.Image.FromFile(bilde));
            ImageStatistics stat2 = new ImageStatistics(GrayBM);
            Histogram red = stat.Red;
            Histogram blue = stat.Blue;
            Histogram green = stat.Green;
            Histogram gray = stat2.Gray;
            MessageBox.Show(red.Mean.ToString() + "\n" + blue.Mean.ToString() + "\n" + green.Mean.ToString() + "\n" + gray.Mean.ToString());
            MessageBox.Show(red.Median.ToString() + "\n" + blue.Median.ToString() + "\n" + green.Median.ToString() + "\n" + gray.Median.ToString());
            MessageBox.Show(gray.Max.ToString() + "\n" + gray.Min.ToString());//bruk disse pluss gray.Median for å sjekke feil
            //må sjekkes med ordentlig bilde og shit



            //finner firkant, funker ikke helt som vi vil
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(bitmap);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            List<IntPoint> edgePoints = new List<IntPoint>();
            List<IntPoint> corners = new List<IntPoint>();
            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                
            }
            corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
            MessageBox.Show(corners.Count.ToString());


            //croper bildet etter hvilke kanter den finner
            SimpleQuadrilateralTransformation filter2 = new SimpleQuadrilateralTransformation(corners);
            PB1.Image = filter2.Apply(bitmap);
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
