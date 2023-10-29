using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace coursework1_OOSD
{
    public partial class MainWindow : Window
    {
        //Console creation -->
        [DllImport("Kernel32")]
        public static extern void AllocConsole();
        // -- end

        MetroStation metro = new MetroStation();
        public MainWindow()
        {
            InitializeComponent();
            AllocConsole();
            try
            {
                Console.WriteLine("Type ID : ");
                metro.ID = Console.ReadLine();
                Console.WriteLine("Type Name : ");
                metro.Name = Console.ReadLine();
                Console.WriteLine("Type in Line : ");
                metro.Line = Console.ReadLine();
                metro.sellTicket();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("ID is : " + metro.ID);
            Console.WriteLine("Name is : " + metro.Name);
            Console.WriteLine("\nTickets sold: " + metro.TicketSold);
            //Console.WriteLine("ID " + metro.ID);

        }

        private void txtbTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtbMainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbMainTextBox.Text = "Do you want to add a Station? : ";
        }

        private void btnMain_yes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMain_no_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
