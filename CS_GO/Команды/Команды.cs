using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_GO
{
    public partial class Команды
    {
        public new string Title { get; set; }
        public int YearJoin { get; set; }
        public Org Org { get; set; }
        public Dev Dev { get; set; }
    }
}
