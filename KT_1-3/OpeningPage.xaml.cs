using KT_1_3.ApplicationData;
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

namespace KT_1_3
{
    /// <summary>
    /// Логика взаимодействия для OpeningPage.xaml
    /// </summary>
    public partial class OpeningPage : Page
    {
        public OpeningPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.model0bd.user.FirstOrDefault(x => x.Login == Login.Text && x.Password == Password.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет", "Ошибка при авторизации",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.Name)
                    {
                        case "Оператор":
                            Appframe.MainFrame.Navigate(new OperatorPage());
                            break;
                        case "Клиент":
                            Appframe.MainFrame.Navigate(new KlientPage());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }

                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка " + Ex.Message.ToString() + "Критическая работа приложения!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
