namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Manager manager = new Manager();
            manager.Name = "Вася";
            manager.Days = 21;
            manager.Print();
            Console.WriteLine();
            HeadDepartment headDepartment = new HeadDepartment();
            headDepartment.Name = "Петя";
            headDepartment.Days = 30;
            headDepartment.Print();
            Accounting accounting = new Accounting();   
            Console.WriteLine("\nНалоги у " + manager.Name + " = " + accounting.Taxes(manager, 21));
            Console.WriteLine("Налоги у " + headDepartment.Name + " = " + accounting.Taxes(headDepartment, 30));
        }
    }
}
