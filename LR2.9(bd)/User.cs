using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LR2._9_bd_
{
    public class User
    {
        public User()
        {
            Tasks = new HashSet<Task>();
        }
        [Key]
        public int ID_User { get; set; }
        public string F_Name { get; set; }
        public string S_Name { get; set; }
        public string L_Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long Number_Phone { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
