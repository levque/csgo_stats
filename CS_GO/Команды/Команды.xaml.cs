using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace CS_GO
{
    /// <summary>
    /// Interaction logic for GroupWin.xaml
    /// </summary>
    public partial class CommandWin : Window, INotifyPropertyChanged
    {
        private Команды selectedCommand;

        public Команды SelectedCommand
        {
            get => selectedCommand;
            set
            {
                selectedCommand = value;
                Signal();
            }
        }
        public ObservableCollection<Команды> Commands
        {
            get => Data.Commands;
        }
        public ObservableCollection<Org> Orgs
        {
            get => Data.Orgs;
        }
        public ObservableCollection<Dev> Devs
        {
            get => Data.Devs;
        }
        public CommandWin()
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

        private void AddCommand(object sender, RoutedEventArgs e)
        {
            Commands.Add(new Команды { Title = "Новая команда" });
        }

        private void DeleteCommand(object sender, RoutedEventArgs e)
        {
            if (SelectedCommand == null)
                return;
            if (MessageBox.Show("Действительно удалить команду?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Commands.Remove(SelectedCommand);
            }
        }

    }
}
