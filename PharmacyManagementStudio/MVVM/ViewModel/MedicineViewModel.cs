using PharmacyManagementStudio.Core.Command;
using PharmacyManagementStudio.Core.Database;
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
        private Database _database;
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


        public Medicine Medicine { get; set; }
        public Command AddCommand { get; set; }

        public void AddElement(object o)
        {
            _database.AddMedicine(Medicine);
        }

        public MedicineViewModel()
        {
            MedicineList = new ObservableCollection<Medicine>();
            Medicine = new Medicine();

            AddCommand = new Command(AddElement);

            _database = new Database();

            var list = _database.ReadMedicine();
            list.ToList().ForEach(m => MedicineList.Add(m));
        }
    }
}
