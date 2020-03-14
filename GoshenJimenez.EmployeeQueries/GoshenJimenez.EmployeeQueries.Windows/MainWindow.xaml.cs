using GoshenJimenez.EmployeeQueries.Windows.BLL;
using GoshenJimenez.EmployeeQueries.Windows.DAL;
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

namespace GoshenJimenez.EmployeeQueries.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var employees = EmployeesBLL.SearchEmployees(2,3);
            grEmployees.ItemsSource = employees.Items;

        }

        private void CmdSearch_Click(object sender, RoutedEventArgs e)
        {
            var employees = EmployeesBLL.SearchEmployees(1, 10, txtKeyword.Text);
            grEmployees.ItemsSource = employees.Items;
        }
    }
}
