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

namespace Ricerca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_cerca_Click(object sender, RoutedEventArgs e)
        {
            int fare = 2;
            string testolungo = txt_testo.Text;
            string testocercato = txt_cercato.Text;
            bool esistenza = testolungo.Contains(testocercato); 
            if(esistenza)
            {
                int indexof = testolungo.IndexOf(testocercato);
                int indexlast = testolungo.LastIndexOf(testocercato);
                if (indexof >= 0)
                {
                    
                }
            }
            else
            {
                lbl_errore.Content = "Il testo cercato non esiste nel testo corrente ";
            }
        }
    }
}
