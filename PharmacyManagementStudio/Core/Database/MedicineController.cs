using PharmacyManagementStudio.Core.Database.Converter;
using PharmacyManagementStudio.Core.Database.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PharmacyManagementStudio.Core.Database
{
    public class MedicineController
    {
        private PharmacyContext _context;
        private MedicineConverter _converter;

        public MedicineController()
        {
            _context = new PharmacyContext();
            _converter = new MedicineConverter();
        }

        public bool AddMedicine(Core.Model.Medicine medicine)
        {
            _context.Medicine.Add((Medicine)_converter.ConvertBack(medicine));
            return _context.SaveChanges() > 0;
        }

        public bool UpdateMedicine(Core.Model.Medicine medicine, string medicineName)
        {
            SqlServerConnection sqlServer = new SqlServerConnection();
            var connection = (SqlConnection)sqlServer.CreateConnection();

            connection.Open();

            var set = new DataSet();
            var adapter = new SqlDataAdapter($"SELECT * FROM Medicine WHERE Name = @string", connection);
            adapter.UpdateCommand = new SqlCommand(
                $"UPDATE Medicine SET Name = @name, Type = @type, Price = @price, Count = @count WHERE Name = @string;",
                connection
            );

            adapter.UpdateCommand.Parameters.Add("@name", SqlDbType.NVarChar, 50, "Name");
            adapter.UpdateCommand.Parameters.Add("@type", SqlDbType.NVarChar, 50, "Type");
            adapter.UpdateCommand.Parameters.Add("@price", SqlDbType.Float);
            adapter.UpdateCommand.Parameters["@price"].SourceColumn = "Price";
            adapter.UpdateCommand.Parameters.Add("@count", SqlDbType.Int);
            adapter.UpdateCommand.Parameters["@count"].SourceColumn = "Count";
            adapter.UpdateCommand.Parameters.AddWithValue("@string", medicineName);
            adapter.SelectCommand.Parameters.AddWithValue("@string", medicineName);

            adapter.Fill(set, "Medicine");

            set.Tables["Medicine"].Rows[0]["Name"] = medicine.Name;
            set.Tables["Medicine"].Rows[0]["Type"] = medicine.Type;
            set.Tables["Medicine"].Rows[0]["Price"] = medicine.Price;
            set.Tables["Medicine"].Rows[0]["Count"] = medicine.StockCount;

            int count = adapter.Update(set, "Medicine");

            connection.Close();

            return count > 0;
        }

        public bool DeleteMedicine(Core.Model.Medicine medicine)
        {
            _context.Medicine.RemoveRange(
                _context.Medicine.Where(m => m.Name == medicine.Name)
            );

            return _context.SaveChanges() > 0;
        }

        public IList<Core.Model.Medicine> ReadMedicine()
        {
            var list = new List<Core.Model.Medicine>();

            _context.Medicine.ToList().ForEach(m => list.Add((Core.Model.Medicine)_converter.Convert(m)));

            return list;
        }
    }
}
