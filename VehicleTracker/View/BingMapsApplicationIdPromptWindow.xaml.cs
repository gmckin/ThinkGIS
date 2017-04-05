using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace ThinkGeo.MapSuite.VehicleTracker
{
    /// <summary>
    /// Interaction logic for BingMapsApplicationIdPromptWindow.xaml
    /// </summary>
    public partial class BingMapsApplicationIdPromptWindow : Window
    {
        public BingMapsApplicationIdPromptWindow()
         { 
             InitializeComponent(); 
         } 
 
 
         public string ApplicationId
         { 
             get { return ApplicationIdTextBox.Text; } 
         } 
 
 
         private void OkButtun_Click(object sender, RoutedEventArgs e)
         { 
             DialogResult = true; 
         } 
 
 
         private void Hyperlink_Click(object sender, RoutedEventArgs e)
         { 
             Process.Start("https://www.bingmapsportal.com/"); 
         } 
     } 
} 
