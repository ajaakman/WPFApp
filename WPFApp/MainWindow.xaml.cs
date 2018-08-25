using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace WPFApp
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

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        private void MenuFontTimes_Click(object sender, RoutedEventArgs e)
        {
            menuFontCourier.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Times New Roman");
        }

        private void MenuFontCourier_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Courier");
        }

        private bool comboFSClosed = true;

        private void ComboFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboFSClosed) ChangeTPFontSize();
            comboFSClosed = true;
        }

        private void ComboFontSize_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            comboFSClosed = !combobox.IsDropDownOpen;
            ChangeTPFontSize();
        }

        private void ChangeTPFontSize()
        {
            string fontsize = ComboFontSize.SelectedItem.ToString();
            fontsize = fontsize.Substring(fontsize.Length - 2);

            switch(fontsize)
            {
                case "10":
                    txtBoxDoc.FontSize = 10;
                    break;
                case "12":
                    txtBoxDoc.FontSize = 12;
                    break;
                case "14":
                    txtBoxDoc.FontSize = 14;
                    break;
                case "16":
                    txtBoxDoc.FontSize = 16;
                    break;
            }
        }

    }
}
