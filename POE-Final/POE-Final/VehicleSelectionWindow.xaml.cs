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
using System.Windows.Shapes;

namespace POE_Final
{
    /// <summary>
    /// Interaction logic for VehicleSelectionWindow.xaml
    /// </summary>
    public partial class VehicleSelectionWindow : Window
    {
        public VehicleSelectionWindow()
        {
            InitializeComponent();
        }

        //Object from the vehicle class
        Vehicle myCar = new Vehicle();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Record the the user is buying
            myCar.setBuying(true);

            //Object for the vehicle window
            VehicleWindow vehicle = new VehicleWindow();

            //Display the window
            vehicle.Show();

            //Hide the current window
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Record the user is not buying
            myCar.setBuying(false);

            //Opening the savings window
            new SavingsWindow().Show();

            //Hiding the current window
            this.Hide();
        }
    }
}
