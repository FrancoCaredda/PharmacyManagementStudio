using PharmacyManagementStudio.Core.Database.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PharmacyManagementStudio.Core.Database.Converter
{
    public class MedicineConverter : IConverter
    {
        public object Convert(object value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is Medicine medicine)
            {
                Core.Model.Medicine convertedMedicine = new Core.Model.Medicine();

                convertedMedicine.Name = medicine.Name;
                convertedMedicine.Type = medicine.Type;
                convertedMedicine.Price = medicine.Price;
                convertedMedicine.StockCount = medicine.Count;

                return convertedMedicine;
            }

            throw new ArgumentException();
        }

        public object ConvertBack(object value)
        {
            if (value == null)
            {
                return null;
            }

            if (value is Core.Model.Medicine medicine)
            {
                Medicine convertedMedicine = new Medicine();
                convertedMedicine.Name = medicine.Name;
                convertedMedicine.Type = medicine.Type;
                convertedMedicine.Price = medicine.Price;
                convertedMedicine.Count = medicine.StockCount;

                return convertedMedicine;
            }

            throw new ArgumentException();
        }

        public object Map(object value1, object value2)
        {
            if (value1 == null || value2 == null)
            {
                return null;
            }

            if (value1 is Medicine && value2 is Core.Model.Medicine)
            {
                var mappedMedicine = (Medicine)value1;
                var medicine = (Core.Model.Medicine)value2;

                mappedMedicine.Name = medicine.Name;
                mappedMedicine.Type = medicine.Type;
                mappedMedicine.Price = medicine.Price;
                mappedMedicine.Count = medicine.StockCount;

                return mappedMedicine;
            }

            throw new ArgumentException();
        }
    }
}
