using Microsoft.Win32;
using OfficeArrangament.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

namespace OfficeArrangement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Map _map;

        public MainWindow()
        {
            InitializeComponent();
            _map = new Map();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == true)
            {
                string fileName = fileDialog.FileName;
                string content = Utility.LoadFile(fileName);
                _map.LoadData(content);
                Bitmap bmp = _map.Draw();
                imageMap.Source = bmp.ToBitmapImage();
            }
        }
    }
}
