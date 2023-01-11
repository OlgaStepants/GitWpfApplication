using System.Windows;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace WpfApplication
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            MainFrame.Content = new Menu();
            //Спортсмены.ItemsSource = СоревнованияEntities.GetContext().Спортсмены.ToList();
                //.Альбомы.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
            //Manager.MainFrame
            /*Page1 page1 = new Page1(null);
            page1.Sh*/
            /*Window2 window2 = new Window2(null);
            window2.Sho;*/
            /*Page1 page1 = new Page1(null);
            page1.Sh*/
            //Window2 window2 = new Window2();
            //window2.Sh; 
            /*Window2 w = new Window2();
            w.Show();*/
            /*var window = new System.Windows.Window();
            window.Content = new Window2();
            window.Show();*/
        

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            /*if (Visibility == Visibility.Visible)
            {
                АудиотекаEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Аудиотека.ItemsSource = АудиотекаEntities.GetContext().Альбомы.ToList();
            }*/
            

        }
    }
}
