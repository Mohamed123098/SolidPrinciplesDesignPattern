namespace SingleReposibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine(EmailModifier.ModifyEmail("Hello,Muhammad "));
            Console.WriteLine(EmailSender.SendEmail("Hello,Muhammad" ));
        }
    }
}
