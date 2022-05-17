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

namespace OODMay2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RentalProperty> allProperties;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RentData db = new RentData();

            var query = from p in db.RentalProperties
                        orderby p.Price
                        select p;

            allProperties = query.ToList();

            lbxProperties.ItemsSource = allProperties;
        }

        private void lbxProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Determine what was selected 
            RentalProperty selected = lbxProperties.SelectedItem as RentalProperty;

            //check not null
            if (selected != null)
            {
                //update display
                tblkPropertyDetails.Text = selected.GetDetails();
            }

        }
    }
}
