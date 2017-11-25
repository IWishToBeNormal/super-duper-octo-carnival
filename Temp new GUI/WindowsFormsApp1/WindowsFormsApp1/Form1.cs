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
        string bilde = @"C:\Users\ahmed\Pictures\temp.jpg";
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
            CornersTB.Text = corners.Count.ToString();


            if(corners.Count == 4)
            {
                //croper bildet etter hvilke kanter den finner
                SimpleQuadrilateralTransformation filter2 = new SimpleQuadrilateralTransformation(corners);
                bitmap = filter2.Apply(bitmap);
                PB1.Image = bitmap; 
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
            PB1.Image = GrayBM;


            // gather statistics
            ImageStatistics stat = new ImageStatistics(bitmap);
            ImageStatistics stat2 = new ImageStatistics(GrayBM);
            Histogram red = stat.Red;
            Histogram blue = stat.Blue;
            Histogram green = stat.Green;
            Histogram gray = stat2.Gray;


            redTB.Text = Convert.ToString(red.Mean);
            blueTB.Text = Convert.ToString(blue.Mean);
            greenTB.Text = Convert.ToString(green.Mean);
            double Gmean = gray.Mean;
            GavgTB.Text = Convert.ToString(Gmean);
            GminTB.Text = Convert.ToString(gray.Min);
            GmaxTB.Text = Convert.ToString(gray.Max);


            int temp = 0;
            for (int i = 0; i < (Gmean/2); i++)
            {
                temp += gray.Values[i];
            }
            MessageBox.Show(temp.ToString() + " sorte piksel verdier under " + Convert.ToString(Gmean / 2));

            if (temp > 3)
            {
                MessageBox.Show("Feil er detektert");
            }
            else
            {
                MessageBox.Show("Platen har ingen feil");
            }
        }
    }
}
