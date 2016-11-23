using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core
{
    public class BindableBase : INotifyPropertyChanged
    {
        protected virtual void SetProperty<T>(ref T property, T val, [CallerMemberName] string propertyName = "")
        {
            if (object.Equals(property,val))
            {
                return;
            }
            else
            {
                property = val;
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged=delegate { };
    }
}
