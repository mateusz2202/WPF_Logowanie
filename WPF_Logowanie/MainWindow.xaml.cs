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

namespace WPF_Logowanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Uzytkownik> Uzytkownicy;
        public MainWindow()
        {
            InitializeComponent();
            Uzytkownicy = new List<Uzytkownik>()
            {
                new Uzytkownik(){Id=0,Login="admin",Haslo="1234",Rola=1},
                new Uzytkownik(){Id=1,Login="admin12",Haslo="1234",Rola=1},
                new Uzytkownik(){Id=2,Login="testN",Haslo="1234",Rola=2},
                new Uzytkownik(){Id=3,Login="testU",Haslo="1234",Rola=3},
            };
        }

        private void BT_Zaloguj_Click(object sender, RoutedEventArgs e)
        {
            var login = TB_Login.Text;
            var haslo = PB_Haslo.Password;
            var uzytkownik = Uzytkownicy.Find(x => x.Login == login && x.Haslo == haslo);

            if (uzytkownik != null)
            {
                if (uzytkownik.Rola == 1)
                {
                    var okno = new OknoAdmina(login);
                    okno.Show();
                    this.Close();
                }
                else if (uzytkownik.Rola == 2)
                {
                    MessageBox.Show("Tutaj powinno wyskoczyc okno z panelem dla uzytkownik z rola=2");
                }
                else
                {
                    MessageBox.Show("Tutaj powinno wyskoczyc okno z panelem dla uzytkownik z rola=3");
                }


            }
            else
            {
                MessageBox.Show("blad logowania");
            }

        }
        class Uzytkownik
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Haslo { get; set; }
            public int Rola { get; set; }//1-admin 2-nauczyciel 3-uczen
        }
    }
}
