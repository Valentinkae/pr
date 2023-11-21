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

namespace poidet2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string[]> data = new List<string[]>();
            data.Add(new string[] { "Дабл-декер", "Детский куш","Вок с курицей", "Детская зона" });
            data.Add(new string[] { "Райская Гавайская", "Вечеринка", "Ролы запечённые", "Ночной зал" });
            data.Add(new string[] { "Красотка", "Деловое собрание", "Сендвич с тунцом", "Офисное" });
            ListView.ItemsSource = data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = tabControl1.Items[1];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tabControl1.SelectedItem = tabControl1.Items[0];
        }

        private void Text1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ принят.");
        }
    }
}
