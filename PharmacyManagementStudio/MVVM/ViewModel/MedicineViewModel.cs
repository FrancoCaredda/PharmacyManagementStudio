using PharmacyManagementStudio.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PharmacyManagementStudio.MVVM.ViewModel
{
    public class MedicineViewModel : BaseViewModel
    {
        private ObservableCollection<Medicine> _medicineList;
        public ObservableCollection<Medicine> MedicineList
        {
            get { return _medicineList; }
            set
            {
                _medicineList = value;
                OnPropertyChanged();
            }
        }

        public MedicineViewModel()
        {
            MedicineList = new ObservableCollection<Medicine>();

            //Database database = new Database();

            //var list = database.ReadMedicine();
            //list.ToList().ForEach(m => MedicineList.Add(m));
        }
    }
}
