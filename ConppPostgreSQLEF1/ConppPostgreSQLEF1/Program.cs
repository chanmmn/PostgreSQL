using System.Globalization;

namespace ConppPostgreSQLEF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Start!");
            ReadPostgreSQL();
        }
        public static void ReadPostgreSQL()
        {
            TestContext context = new TestContext();
            var result = from r in context.People select r;
            foreach (Person r in result)
            {
                Console.WriteLine(r.FirstName); Console.WriteLine(r.LastName);
            }
        }

    }
}