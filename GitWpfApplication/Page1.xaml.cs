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

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private Альбомы _текущийАльбом = new Альбомы();



        public Page1(Альбомы выбранныйАльбом)
        {
            InitializeComponent();

            if (выбранныйАльбом != null)
                _текущийАльбом = выбранныйАльбом;
            DataContext = _текущийАльбом;

            //Альбомы.ItemsSource = АудиотекаEntities1.GetContext().Альбомы.ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());



        }

        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

    }
}
