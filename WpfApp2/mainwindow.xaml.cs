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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string loginStr = login.Text;
            switch (loginStr)
            {
                case "1":
                    if (password.Password.Equals("1"))
                    {
                        Hide();
                        Window1 w = new Window1();
                        w.ShowDialog();

                    }
                    break;
                default:
                    MessageBox.Show("логин или пароль введены неверно");
                    break;
            }
        }

            void hyperlink_Click(object sender, RoutedEventArgs e)
            {
                Hide();
                Window2 w = new Window2();
                w.ShowDialog();
            }

            private void Close_Click(object sender, RoutedEventArgs e)
            {
                Application.Current.Shutdown();
            }
    }
}

