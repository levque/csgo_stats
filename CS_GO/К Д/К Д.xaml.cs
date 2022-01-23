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
    /// Interaction logic for SpecialWin.xaml
    /// </summary>
    public partial class OrgWin : Window, INotifyPropertyChanged
    {
        public Org selectedOrg;

        public Org SelectedOrg
        {
            get => selectedOrg;
            set
            {
                selectedOrg = value;
                Signal();
            }
        }

        public ObservableCollection<Org> Orgs
        {
            get => Data.Orgs;
        }
        public OrgWin()
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

        private void AddOrg(object sender, RoutedEventArgs e)
        {
            Orgs.Add(new Org { Title = "Новая Организация" });
        }

        private void DeleteOrg(object sender, RoutedEventArgs e)
        {
            if (SelectedOrg == null)
                return;
            if (MessageBox.Show("Действительно удалить Организацию?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Orgs.Remove(SelectedOrg);
            }
        }
    }
}
