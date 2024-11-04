using System;
using System.Collections;
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

namespace arraylistApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arraylist;
        public MainWindow()
        {
            InitializeComponent();
            arraylist = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //showall data
            string dataName = string.Empty;

            foreach (string data in arraylist)
            {
                dataName = data.ToString();
            }
            MessageBox.Show("DATA IN ARRAY ARE  " + dataName);


            //Show Data
           
        }

        //Add
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            arraylist.Add(txtShowAll.Text);

            MessageBox.Show("Add " + txtShowAll.Text + " Complete");
        }

        //Remove
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            arraylist.Remove(txtShowAll.Text);

            MessageBox.Show("Remove " + txtShowAll.Text + "Complete");
        }

        
    }
}
