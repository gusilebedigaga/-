using MaterialDesignColors.Recommended;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Services;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Анкета
{
    /// <summary>
    /// Логика взаимодействия для Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        
        private readonly ObservableCollection<Anketa> ItemsCollection = new ObservableCollection<Anketa>();

    
        public Results()
        {

            InitializeComponent();

            listOfUsers.ItemsSource = ItemsCollection;

            // Заполнение коллекции
            using (AplicationContext db = new AplicationContext())
                foreach(var item in db.Anketas.ToList())
                   ItemsCollection.Add(item);
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();

        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AplicationContext db = new AplicationContext();
            var item = listOfUsers.SelectedItem as Anketa;
            if (item != null)
            {
                 ItemsCollection.Remove(item);
                 db.Anketas.Remove(item);
                 db.SaveChanges();
             }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
