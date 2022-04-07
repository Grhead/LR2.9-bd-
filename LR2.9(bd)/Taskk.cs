namespace LR2._9_bd_;

public class Taskk
{
    public Taskk()
    {

    }
    public int TaskId { get; set; }
    public string Name_Task { get; set; }
    public string Description_Task { get; set; }
    public DateTime Date_Pub { get; set; }

    public int UsersID { get; set; }

    //public int AcceptorID { get; set; }
    public int StatusId { get; set; }

    public virtual Status Statuses { get; set; }
    public virtual User Users { get; set; }
}
