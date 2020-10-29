using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            progressBar.Minimum = 0.0;
            progressBar.Maximum = 100.0;
        }

        private void Download(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += DownloadProgressChanged;
            webClient.DownloadFileCompleted += DownloadFileCompleted;
            webClient.DownloadFileAsync(new Uri("https://www.youtube.com/watch?v=QFG_CyuNjZE"), System.IO.Path.Combine("D:\\", System.IO.Path.GetRandomFileName()));
        }

        private void DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            progressBar.Value = 0.0;
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = (double)e.ProgressPercentage;
        }

        private void Abolition(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
