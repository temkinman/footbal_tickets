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

namespace FootballTickets
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void fetch_data_Btn_Click(object sender, RoutedEventArgs e)
        {
            using (AppContext db = new AppContext())
            {
                //List<Stadium> stadiums = db.Stadiums.ToList();
                //List<Match> matches = db.Matches.ToList();
                List<Team> teames = db.Teams.ToList();

                Console.WriteLine("Matches");
                foreach (Team m in teames)
                    Console.WriteLine($"Name: {m.Name} city:");
            }
        }
    }
}
