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
        public Status()
        {
            Tasks = new HashSet<Taskk>();
        }
        public int ID_Status { get; set; }
        public string Name_Status { get; set; }

        public virtual ICollection<Taskk> Tasks { get; set; } = null!;

        
    }
}
