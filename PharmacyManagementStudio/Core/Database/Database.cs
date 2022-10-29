using PharmacyManagementStudio.Core.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementStudio.Core.Database
{
    public class Database
    {
        private PharmacyContext _context;

        public Database()
        {
            _context = new PharmacyContext();
        }

        public void AddMedicine(Core.Model.Medicine medicine)
        {
            _context.Medicine.Add(new Medicine() { Name = medicine.Name, Price = medicine.Price, Count = medicine.StockCount, Type = medicine.Type });
            _context.SaveChanges();
        }

        public IList<Core.Model.Medicine> ReadMedicine()
        {
            var list = new List<Core.Model.Medicine>();

            _context.Medicine.ToList().ForEach(m => list.Add(
                new Core.Model.Medicine()
                {
                    Name = m.Name,
                    Price = m.Price,
                    StockCount = m.Count,
                    Type = m.Type,
                }
            ));

            return list;
        }
    }
}
