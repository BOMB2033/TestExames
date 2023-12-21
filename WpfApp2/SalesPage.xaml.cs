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
    /// Логика взаимодействия для SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
        public SalesPage()
        {
            InitializeComponent();
            DataGrid1.ItemsSource = Connect.Context.Sales.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new AddEditPage(null));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Nav.Frame.GoBack();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new AddEditPage((Sales)DataGrid1.SelectedItem));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = Connect.Context.Sales.ToList();
        }

        private void btnDelet_Click(object sender, RoutedEventArgs e)
        {
            var seletItems = DataGrid1.SelectedItems.Cast<Sales>().ToList();
            if (MessageBox.Show($"Удалить {seletItems.Count} записей", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Connect.Context.Sales.RemoveRange(seletItems);
            Connect.Context.SaveChanges();
            DataGrid1.ItemsSource = Connect.Context.Sales.ToList();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = Connect.Context.Sales.Where(x => x.Name.Contains(textBoxSearch.Text)).ToList();
        }
    }
}
