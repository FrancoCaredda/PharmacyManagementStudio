using PharmacyManagementStudio.Core.Command;
using PharmacyManagementStudio.Core.Database;
using PharmacyManagementStudio.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PharmacyManagementStudio.MVVM.ViewModel
{
    public class MedicineViewModel : BaseViewModel
    {
        private MedicineController _database;
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

        #region PRIVATEDATA
        private string _medicineName;
        private bool _rowSelected = false;
        #endregion

        #region DATAFROMUI
        private Medicine _medicine;
        public Medicine Medicine 
        { 
            get { return _medicine; } 
            set { _medicine = value;  OnPropertyChanged(); } 
        }
        public int RowIndex { get; set; }
        #endregion

        #region COMMAND
        public Command AddCommand { get; set; }
        public Command SelectCommand { get; set; }
        public Command UpdateCommand { get; set; }
        public Command DeleteCommand { get; set; }

        public void AddElement(object o)
        {
            if (_database.AddMedicine(Medicine))
            {
                MessageBox.Show("Row is added!");
                ReadMedicine();
            }
        }

        public void SelectRow(object o)
        { 
            Medicine medicine = _medicineList[RowIndex];

            Medicine = new Medicine()
            {
                Name = medicine.Name,
                Type = medicine.Type,
                Price = medicine.Price,
                StockCount = medicine.StockCount
            };

            _medicineName = medicine.Name;
            _rowSelected = true;
        }

        public void UpdateRow(object o)
        {
            if (!_rowSelected)
            {
                MessageBox.Show("Select row to update");
                return;
            }

            if (_database.UpdateMedicine(Medicine, _medicineName))
            {
                MessageBox.Show("Row is updated!");
                ReadMedicine();
            }

            _rowSelected = false;
        }

        public void DeleteRow(object o)
        {
            if (!_rowSelected)
            {
                MessageBox.Show("Select row to delete");
                return;
            }

            if (_database.DeleteMedicine(Medicine))
            {
                MessageBox.Show("Row is deleted!");
                ReadMedicine();
            }

            _rowSelected = false;
        }
        #endregion

        public void ReadMedicine()
        {
            MedicineList.Clear();
            var list = _database.ReadMedicine();
            list.ToList().ForEach(m => MedicineList.Add(m));
        }

        public MedicineViewModel()
        {
            MedicineList = new ObservableCollection<Medicine>();
            Medicine = new Medicine();

            AddCommand = new Command(AddElement);
            SelectCommand = new Command(SelectRow);
            UpdateCommand = new Command(UpdateRow);
            DeleteCommand = new Command(DeleteRow);

            _database = new MedicineController();

            ReadMedicine();
        }
    }
}
