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

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            Альбомы.ItemsSource = АудиотекаEntities1.GetContext().Альбомы.ToList();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                АудиотекаEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Альбомы.ItemsSource = АудиотекаEntities1.GetContext().Альбомы.ToList();
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());



        }
    }
}

