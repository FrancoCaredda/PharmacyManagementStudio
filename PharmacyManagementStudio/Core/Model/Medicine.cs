using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementStudio.Core.Model
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
    }
}
