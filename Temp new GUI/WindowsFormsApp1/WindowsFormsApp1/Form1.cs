using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using AForge.Math.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string bilde = @"C:\temp\temp9.jpg";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PB1.Image = System.Drawing.Image.FromFile(bilde);
            Bitmap bitmap = new Bitmap(bilde);

            ColorFiltering colorFilter = new ColorFiltering();
            colorFilter.Red = new IntRange(0, 64);
            colorFilter.Green = new IntRange(0, 64);
            colorFilter.Blue = new IntRange(0, 30);
            colorFilter.FillOutsideRange = false;

            colorFilter.ApplyInPlace(bitmap);
            PB1.Image = bitmap;


            //finner firkant, funker ikke helt som vi vil
            // locate objects using blob counter
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            blobCounter.CoupledSizeFiltering = true;
            blobCounter.MinHeight = bitmap.Height /2;
            blobCounter.MinWidth = bitmap.Width /2;

            blobCounter.ProcessImage(bitmap);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            List<IntPoint> corners = new List<IntPoint>();

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                if (corners.Count < 4)
                {
                    corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
                }
                else
                {
                    break;
                }
            }
            MessageBox.Show(corners.Count.ToString());


            if(corners.Count == 4)
            {
                //croper bildet etter hvilke kanter den finner
                SimpleQuadrilateralTransformation filter2 = new SimpleQuadrilateralTransformation(corners);
                bitmap = filter2.Apply(bitmap);
                PB1.Image = bitmap; 
                MessageBox.Show("temp");
            }

            //fjerner 2% av kantene for å ungå feil.
            int i1 = bitmap.Height / 100;
            int i2 = bitmap.Width / 100;
            Crop Cfilter = new Crop(new Rectangle(i2, i1, bitmap.Width - (2*i2), bitmap.Height - (2*i1)));
            bitmap = Cfilter.Apply(bitmap);
            PB1.Image = bitmap;

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
            MessageBox.Show(red.Mean.ToString() + " Red Mean" + "\n" + blue.Mean.ToString() + " Blue Mean" + "\n" + green.Mean.ToString() + " Green Mean" + "\n" + gray.Mean.ToString() + " Gray Mean");
            MessageBox.Show(red.Median.ToString() + " Red Median" + "\n" + blue.Median.ToString() + " Blue Median" + "\n" + green.Median.ToString() + " Green Median" + "\n" + gray.Median.ToString() + " Gray Median");
            MessageBox.Show(gray.Max.ToString() + " Gray Max" + "\n" + gray.Min.ToString() + " Gray Min");
            //bruk disse pluss gray.Median for å sjekke feil
            //må sjekkes med ordentlig bilde og shit
            PB1.Image = GrayBM;
            int median = gray.Median;
            double mean = gray.Mean;
            int min = gray.Min;
            if((mean - min) >= 100)
            {
                MessageBox.Show("det er feil!!!!");
            }
            else
            {
                //MessageBox.Show("riktig!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            long temp = 0;
            foreach(int i in gray.Values)
            {
                temp++;
            }
            MessageBox.Show(temp.ToString());
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
