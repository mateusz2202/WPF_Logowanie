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

namespace WPF_Logowanie
{
    /// <summary>
    /// Logika interakcji dla klasy OknoAdmina.xaml
    /// </summary>
    public partial class OknoAdmina : Window
    {
        public OknoAdmina(string login)
        {
            InitializeComponent();
            L_Info.Content = $"Zalogowoano jako: {login}";
        }

        private void BT_Wyloguj_Click(object sender, RoutedEventArgs e)
        {
            var okno = new MainWindow();
            okno.Show();
            this.Close();
        }
    }
}
