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
using FitnessClub1.Pages.DirectorsPages;

namespace FitnessClub1.Pages.DirectorsPages
{ 
    public partial class Vedro : Window
    {
        public Vedro()
        {

            InitializeComponent();

            lvCartService.ItemsSource = ClassHelper.CartClass.serviceCart.ToList();
        }

        private void BtnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var service = button.DataContext as BD.Service;
            ClassHelper.CartClass.serviceCart.Remove(service);
        }

        private void lvCartService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
