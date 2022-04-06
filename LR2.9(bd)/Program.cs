using LR2._9_bd_;

Context db = new Context();

User user_1 = new()
{
    F_Name = "Вдовкин",
    S_Name = "Арсений",
    L_Name = "Антонович",
    Login = "vdow123",
    Password = "12345",
    Number_Phone = 88005553535
};
db.Users.Add(user_1);
db.SaveChanges();
User user_2 = new()
{
    F_Name = "Рыбалкин",
    S_Name = "Никита",
    L_Name = "Артемович",
    Login = "ryb123",
    Password = "22d22",
    Number_Phone = 89132003232
};
db.Users.Add(user_2);
db.SaveChanges();
User user_3 = new()
{
    F_Name = "Петров",
    S_Name = "Петр",
    L_Name = "Петрович",
    Login = "petr123",
    Password = "ye312",
    Number_Phone = 86567765645
};
db.Users.Add(user_3);
db.SaveChanges();
User user_4 = new()
{
    F_Name = "Сидоров",
    S_Name = "Александр",
    L_Name = "Антонович",
    Login = "sidar123",
    Password = "arr312",
    Number_Phone = 84566767645
};
db.Users.Add(user_4);
db.SaveChanges();
User user_5 = new()
{
    F_Name = "Лашков",
    S_Name = "Сергей",
    L_Name = "Семенович",
    Login = "ser123434",
    Password = "ser556",
    Number_Phone = 88887373456
};
db.Users.Add(user_5);
db.SaveChanges();
Status status1 = new()
{
    Name_Status = "Не готов",
};
db.Statuses.Add(status1);
db.SaveChanges();
Status status2 = new()
{
    Name_Status = "Выполняется",
};
db.Statuses.Add(status2);
db.SaveChanges();
Status status3 = new()
{
    Name_Status = "Готов",
};
db.Statuses.Add(status3);
db.SaveChanges();
Taskk task1 = new()
{
    Name_Task = "Решите уравнение",
    Description_Task = "Нужно решить квадратное уравнение",
    Date_Pub = new DateTime(2020, 01, 10),
    ID_Creator = 2,
    ID_Acceptor = 1,
    ID_Status = 2
};
db.Tasks.Add(task1);
db.SaveChanges();
Taskk task2 = new()
{
    Name_Task = "Решите задачку",
    Description_Task = "Найдите сумму чисел",
    Date_Pub = new DateTime(2021, 10, 20),
    ID_Creator = 1,
    ID_Acceptor = 2,
    ID_Status = 2
};
db.Tasks.Add(task2);
db.SaveChanges();
Taskk task3 = new()
{
    Name_Task = "Решите задачу на c++",
    Description_Task = "Нужно выполнить 10 задач по по строкам",
    Date_Pub = new DateTime(2021, 03, 12),
    ID_Creator = 2,
    ID_Acceptor = 3,
    ID_Status = 3
};
db.Tasks.Add(task3);
db.SaveChanges();
Taskk task4 = new()
{
    Name_Task = "Решите уравнение",
    Description_Task = "Нужно решить кубическое уравнение",
    Date_Pub = new DateTime(2022, 06, 19),
    ID_Creator = 3,
    ID_Acceptor = 2,
    ID_Status = 5
};
db.Tasks.Add(task4);
db.SaveChanges();
Taskk task5 = new()
{
    Name_Task = "Решите неравенство",
    Description_Task = "Нужно решить неравенство",
    Date_Pub = new DateTime(2022, 11, 10),
    ID_Creator = 4,
    ID_Acceptor = 5,
    ID_Status = 2
};
db.Tasks.Add(task5);
db.SaveChanges();