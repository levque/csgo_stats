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
    //класс-хранилище общих данных, доступных везде
    static class Data
    {

        public static ObservableCollection<Player> Players = new ObservableCollection<Player>();
        public static ObservableCollection<Команды> Commands = new ObservableCollection<Команды>();
        public static ObservableCollection<Dev> Devs = new ObservableCollection<Dev>();
        public static ObservableCollection<Org> Orgs = new ObservableCollection<Org>();
    }
}
