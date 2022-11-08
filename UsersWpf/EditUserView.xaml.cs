using Microsoft.Win32;
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
using System.Windows.Shapes;
using UsersClassLibrary.Models;
using UsersWpf.ViewModels;

namespace UsersWpf
{
    /// <summary>
    /// Interaction logic for EditUserView.xaml
    /// </summary>
    public partial class EditUserView : Window
    {
        private EditUserViewModel vm;
        public EditUserView()
        {
            InitializeComponent();
            vm = new EditUserViewModel();
            DataContext = vm;
        }

        public EditUserView(User u) 
        {
            InitializeComponent();
            vm = new EditUserViewModel(u);
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Annulla
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Salva
            vm.Save();
            Close();
        }
    }
}
