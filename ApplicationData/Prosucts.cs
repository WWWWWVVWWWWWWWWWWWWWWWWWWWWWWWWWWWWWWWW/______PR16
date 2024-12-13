using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16.ApplicationData
{
    public class Prosucts
    {

            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int CategoryID { get; set; }
            public int MaterialID { get; set; }
            public int ColorID { get; set; }
            public int CountryID { get; set; }
        
    }
}
