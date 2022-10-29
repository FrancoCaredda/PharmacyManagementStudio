using PharmacyManagementStudio.Core.Command;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementStudio.MVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _viewModel;
        public BaseViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; OnPropertyChanged(); }
        }

        #region
        private MedicineViewModel _medicineViewModel;
        private CustomerViewModel _customerViewModel;
        private SalerViewModel _salerViewModel;
        #endregion

        #region COMMAND
        public Command MedicineSwitch { get; set; }
        public Command CustomerSwitch { get; set; }
        public Command SalerSwitch { get; set; }
        #endregion

        public MainViewModel()
        {
            _medicineViewModel = new MedicineViewModel();
            _customerViewModel = new CustomerViewModel();
            _salerViewModel = new SalerViewModel();
            ViewModel = _medicineViewModel;

            MedicineSwitch = new Command(
               (o) => { ViewModel = _medicineViewModel; }
            );

            CustomerSwitch = new Command(
                (o) => { ViewModel = _customerViewModel; }
            );

            SalerSwitch = new Command(
                (o) => { ViewModel = _salerViewModel; }
            );
        }
    }
}
