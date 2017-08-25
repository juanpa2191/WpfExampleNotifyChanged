using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExampleNotifyChanged.Model;

namespace WpfExampleNotifyChanged.ViewModel
{
    public class PersonViewModel : ObservableObject
    {

        public string _name { get; set; }


        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    return "Unknown";
                }
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

    }
}
