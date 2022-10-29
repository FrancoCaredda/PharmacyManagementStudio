using PharmacyManagementStudio.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementStudio.MVVM.ViewModel
{
    public class SalerViewModel : BaseViewModel
    {
        private ObservableCollection<Saler> _salerList;
        public ObservableCollection<Saler> SalerList
        {
            get { return _salerList; }
            set { _salerList = value; OnPropertyChanged(); }
        }

        public SalerViewModel()
        {
            SalerList = new ObservableCollection<Saler>();
        }
    }
}
