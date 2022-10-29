using PharmacyManagementStudio.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementStudio.MVVM.ViewModel
{
    public class CustomerViewModel : BaseViewModel
    {
        private ObservableCollection<Customer> _customerList;

        public ObservableCollection<Customer> CustomerList
        {
            get { return _customerList; }
            set { _customerList = value; OnPropertyChanged(); }
        }

        public CustomerViewModel()
        {
            CustomerList = new ObservableCollection<Customer>();
        }
    }
}
