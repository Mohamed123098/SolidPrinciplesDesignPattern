namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FullTimeEmployee = new FullTimeEmployee(7500) { Name = "Muhammad", Address = "Beni-suef", Age = 26};
            Console.WriteLine(FullTimeEmployee);
            PartTimeEmployee partTimeEmployee = new(800) { Name = "Eng.BASBOSA", Age = 22, Address = "Cairo"};
            Console.WriteLine(partTimeEmployee);
        }
    }
}
