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
using UsersAdo.ViewModels;

namespace UsersAdo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowViewModel();
            DataContext = vm;
        }

        private void DropTables_Click(object sender, RoutedEventArgs e)
        {
            vm.Droptables();
        }
        private void CreateTables_Click(object sender, RoutedEventArgs e)
        {
            vm.CreateTables();
        }
        private void DeleteFromTables_Click(object sender, RoutedEventArgs e)
        {
            vm.DeleteFromTables();
        }
        private void LoadDataOnTables_Click(object sender, RoutedEventArgs e)
        {
            vm.LoadDataOnTables();
        }
    }
}
