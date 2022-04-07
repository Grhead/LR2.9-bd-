using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2._9_bd_
{
    public class Status
    {
       
        public int StatusШd { get; set; }
        public string Name_Status { get; set; }

        public virtual List<Taskk> Tasks { get; set; };
    }
}
