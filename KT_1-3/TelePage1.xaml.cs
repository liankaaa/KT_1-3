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
    /// Логика взаимодействия для TelePage1.xaml
    /// </summary>
    public partial class TelePage1 : Page
    {
        public TelePage1()
        {
            InitializeComponent();
            DGridTele.ItemsSource = TelesvEntities.GetContext().Operator.ToList();
            
        }
    }
}
