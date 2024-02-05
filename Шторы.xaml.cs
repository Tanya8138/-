using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Версаль
{
    /// <summary>
    /// Логика взаимодействия для Шторы.xaml
    /// </summary>
    public partial class Шторы : Page
    {
        public Шторы()
        {
            InitializeComponent();
            ВерсальEntities db = new ВерсальEntities();
             db = new ВерсальEntities();
            
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        ВерсальEntities db = new ВерсальEntities();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          

        }

        private void productsView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
