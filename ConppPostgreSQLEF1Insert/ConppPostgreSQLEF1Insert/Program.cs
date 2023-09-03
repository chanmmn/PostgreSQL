using System.Globalization;

namespace ConppPostgreSQLEF1Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Start!");
            ReadPostgreSQL();
            InsertData();
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
        public static void InsertData()
        {
            TestContext context = new TestContext();
            Person person = new Person();
            person.Id = 10;
            person.FirstName = "Yuk";
            person.LastName = "Ki";
            context.People.Add(person);
            context.SaveChanges();
        }


    }
}