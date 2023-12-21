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
            DataGrid1.ItemsSource = Connect.Context.Sales.ToList();//Обновить
            foreach (var item in DataGrid1.Columns)
            {
                ComboBoxSort.Items.Add(item.Header.ToString());
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new AddEditPage(null)); //Открыть страницу добавления 
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Nav.Frame.GoBack();//Назад
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Nav.Frame.Navigate(new AddEditPage((Sales)DataGrid1.SelectedItem));//Открыть страницу редактирования 
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = Connect.Context.Sales.ToList(); //Обновить
        }

        private void btnDelet_Click(object sender, RoutedEventArgs e)
        {
//       Удаление
            var seletItems = DataGrid1.SelectedItems.Cast<Sales>().ToList(); //Получение выделенных ячеек
            if (MessageBox.Show($"Удалить {seletItems.Count} записей", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)//Запросное сообщение
                Connect.Context.Sales.RemoveRange(seletItems);//Удалить массив
            Connect.Context.SaveChanges();//Сохранить
            DataGrid1.ItemsSource = Connect.Context.Sales.ToList();//Обновить
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            DataGrid1.ItemsSource = Connect.Context.Sales.Where(x => x.Name.Contains(textBoxSearch.Text)).ToList(); //Поиск
        }

        private void ComboBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid1.ItemsSource = Connect.Context.Sales.OrderBy(x => x.Name).ToList();
        }
    }
}
