using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    //customer can have a note attached for special instructions. Normally I would
    //extend the Store Customer object but do not want to mess up Fabricare
    public partial class NoteForCustomer
    {
        public int id { get; set; }
        public int? CustID { get; set; }
        public string note { get; set; }
    }
}
