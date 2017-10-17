using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ImageProcessingGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //File Dialog
        OpenFileDialog file = new OpenFileDialog();

        /// <summary>
        /// Handles the Click event of the CheckFail control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void CheckFail_Click(object sender, RoutedEventArgs e)
        {
            //more to do here...
            if(File_path_txt.Text != "")
            {
                Bilde.Source = new BitmapImage(new Uri(File_path_txt.Text));
            }
            else
            {
                Image_results_txt.Text = " Check fail.... try again!";
            }
           
        }

        /// <summary>
        /// Handles the Click event of the file_Path control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void file_Path_Click(object sender, RoutedEventArgs e)
        {
            file.Title = "Select a picture";
            file.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if(file.ShowDialog() == true)
            {
                File_path_txt.Text = file.FileName;
            }

        }
    }
}
