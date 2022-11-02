using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersWpf.ViewModels
{
    internal class CalcolatriceViewModel: BaseViewModel
    {
        private string _display = "0";
        public string Display
        {
            get
            {
                return _display;
            }
            set
            {
                _display = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Display"));
                NotifyPropertyChanged("Display");
            }
        }

        public void ButtonPressed(string s)
        {
            Display += s;
        }
    }
}
