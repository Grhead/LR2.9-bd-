using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LR2._9_bd_
{
    public class Task
    {
        public int ID_Task { get; set; }
        public string Name_Task { get; set; }
        public DateTime Date_Pub { get; set; }
        public int ID_Creator { get; set; }
        public int ID_Acceptor { get; set; }
        public int ID_Status { get; set; }

        public virtual User User { get; set; }
        public virtual Status Status { get; set; }
    }
}
