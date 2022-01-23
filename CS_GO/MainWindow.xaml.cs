
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
using CS_GO;

namespace CS_GO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Player selectedPlayer;

        public Player SelectedPlayer
        {
            get => selectedPlayer;
            set
            {
                selectedPlayer = value;
                Signal();
            }
        }
        public ObservableCollection<Player> Players
        {
            get => Data.Players;
        }
        public ObservableCollection<Команды> Commands
        {
            get => Data.Commands;
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddPlayer(object sender, RoutedEventArgs e)
        {
            Players.Add(new Player
            {
                LastName = "Новый Игрок",
                Birthday = DateTime.Today
            });
        }

        private void DeletePlayer(object sender, RoutedEventArgs e)
        {
            if (SelectedPlayer == null)
                return;
            if (MessageBox.Show("Действительно удалить Игрока?",
            "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Players.Remove(SelectedPlayer);
                SelectedPlayer = null;
            }
        }

        private void ClickOrg(object sender, RoutedEventArgs e)
        {
            OrgWin win = new OrgWin();
            win.ShowDialog();
        }

        private void ClickCommand(object sender, RoutedEventArgs e)
        {
            CommandWin win = new CommandWin();
            win.ShowDialog();
        }

        private void ClickDev(object sender, RoutedEventArgs e)
        {
            DevWin win = new DevWin();
            win.ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

