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


using FitnessClub1.BD;
using FitnessClub1.Windows;
using FitnessClub1.ClassHelper;

namespace FitnessClub1.Windows
{
    /// <summary>
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Service : Window
    {
        List<string> listSort = new List<string>()
        {
            "По умолчанию",
            "По названию (по возрастанию)",
            "По названию (по убыванию)"
        };
        public Service()
        {
            InitializeComponent();

            GetServiceList();

            CMBTypeSearch.ItemsSource = listSort;
            CMBTypeSearch.SelectedIndex = 0;
        }
        private void GetServiceList()
        {
            List<BD.Service> serviceList = new List<BD.Service>();

            serviceList = ClassHelper.EFClass.context.Service.ToList();
            // фильтрация, поиск и сортировку

            //поиск
            serviceList = serviceList.Where(i => i.ServicesName.ToLower().Contains(TbSearch.Text.ToLower())).ToList();


           

            lvService.ItemsSource = serviceList;
        }
        private void CMBTypeSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var service = button.DataContext as Service;


            //AddEditServiceWindow addEditServiceWindow = new AddEditServiceWindow(service);       Создать Добавление услуги
            //addEditServiceWindow.ShowDialog();

            GetServiceList();
        }
         private void BtnCartService_Click(object sender, RoutedEventArgs e)
        {
            //var button = sender as Button;
            //if (button == null)
            //{
            //    return;
            //}

            //var service = button.DataContext as Service; 

            //ClassHelper.CartClass.serviceCart.Add(service);
            //MessageBox.Show($"Услуга {service.ServicesName.ToString()} добавлена");
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lvService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
