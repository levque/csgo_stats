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

namespace CS_GO
{
    /// <summary>
    /// Interaction logic for CuratorWin.xaml
    /// </summary>
    public partial class DevWin : Window, INotifyPropertyChanged
    {
        private Dev selectedDev;

        public Dev SelectedDev
        {
            get => selectedDev;
            set
            {
                selectedDev = value;
                Signal();
            }
        }

        public ObservableCollection<Dev> Devs
        {
            get => Data.Devs;
        }
        public DevWin()
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

        private void AddDev(object sender, RoutedEventArgs e)
        {
            Devs.Add(new Dev { LastName = "Фамилия" });
        }

        private void DeleteDev(object sender, RoutedEventArgs e)
        {
            if (SelectedDev == null)
                return;
            if (MessageBox.Show("Действительно удалить Директора?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Devs.Remove(SelectedDev);
            }
        }
    }
}