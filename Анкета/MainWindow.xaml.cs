using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
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

namespace Анкета
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AplicationContext db;
        
        string ninja = "Донателло";
        public MainWindow()
        {
            InitializeComponent();

            db = new AplicationContext();

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        { 

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Picture(2);
            ninja = "Леонардо";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Picture(3);
            ninja = "Рафаэль";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Picture(1);
            ninja = "Микеланджело";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Picture(4);
            ninja = "Донателло";
        }

        void Picture (int name)
        {
            image.Visibility = Visibility.Collapsed;
            image2.Visibility = Visibility.Collapsed;
            image3.Visibility = Visibility.Collapsed;
            image4.Visibility = Visibility.Collapsed;

            switch (name)
            {
                case 1: image.Visibility= Visibility.Visible; break;
                case 2: image2.Visibility= Visibility.Visible; break;
                case 3: image3.Visibility = Visibility.Visible; break;
                case 4: image4.Visibility = Visibility.Visible; break;
                default:
                    break;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string name = textBoxName.Text;
            bool pol;
            string gender =" ";
            string city = City.Text;
            string age = Vozrast.Text;
            if (Man.IsChecked == true)
            {
                pol = true;
                gender = "Мужской";
            }
            else if (Woman.IsChecked == true)
            {
                pol = true;
                gender = "Женский";
            }
            else
            {
                pol=false;
            }
            

            if (pol == true && name.Length > 1 && City.SelectedIndex > -1)
            {
                MessageBox.Show("Вы прошли анкету\nСпасибо Вам огромное\nВы большой молодец :)\nТеперь вы можете ознакомится с результатми других людей кнопкой ниже\nТихановский Артём 21СИБ2", "Спасибо за прохождение");
                Anketa anketa = new Anketa(name, gender, city, age, ninja);

                db.Anketas.Add(anketa);
                db.SaveChanges();

            }
            else
            {
                MessageBox.Show("Не все поля введены корректно\nПроверьте правильность заполнения анкеты", "Уведомление");

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Results results = new Results();
            results.Show();
            Hide();
        }
    }
}
