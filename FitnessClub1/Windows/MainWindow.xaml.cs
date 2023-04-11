using FitnessClub1.Windows;
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


namespace FitnessClub1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           Service service = new Service();
            service.Show();
            this.Close();

            var authUser = ClassHelper.EFClass.context.User.ToList()
               .Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password)
               .FirstOrDefault();

            if (authUser != null)
            {
                // сохраняем пользователя
                ClassHelper.UserClass.AuthUser = authUser;

                // переход на нужное окно
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
    
}
