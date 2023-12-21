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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Sales sales;
        bool checkNew;
        public AddEditPage(Sales s)
        {
            InitializeComponent();
            if (s == null)
            {
                s = new Sales();
                checkNew = true;
            }
            else
                checkNew = false;

            DataContext = sales = s;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
                Connect.Context.Sales.Add(sales);
            Connect.Context.SaveChanges();
            Nav.Frame.GoBack();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Nav.Frame.GoBack();
        }
    }
}
