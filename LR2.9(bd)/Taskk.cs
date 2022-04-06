namespace LR2._9_bd_;

public class Taskk
{
    public Taskk()
    {

    }
    public int Taskid { get; set; }
    public string Name_Task { get; set; }
    public string Description_Task { get; set; }
    public DateTime Date_Pub { get; set; }

    public int CreatorID { get; set; }

    //public int AcceptorID { get; set; }
    public int Statusid { get; set; }

    public virtual Status Statuses { get; set; }
    public virtual User Users { get; set; }
}