using System.Globalization;

namespace ConppPostgreSQLEF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Start!");
            //ReadPostgreSQL();
            //InsertData();
            //UpdateDate(10);
            Delete(1);
        }
        //public static void ReadPostgreSQL()
        //{
        //    TestContext context = new TestContext();
        //    var result = from r in context.People select r;
        //    foreach (Person r in result)
        //    {
        //        Console.WriteLine(r.FirstName); Console.WriteLine(r.LastName);
        //    }
        //}

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

        public static void UpdateDate(int id)
        {
            TestContext context = new TestContext();
            //Retrieve record
            var result = (from r in context.People where (r.Id == id) select r).FirstOrDefault();
            //Edit record
            result.FirstName = "Yuki";
            //Save record
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            //int localid = id;
            TestContext context = new TestContext();
            var result = (from r in context.People where (r.Id == id) select r).FirstOrDefault();
            context.People.Remove(result);
            context.SaveChanges();

        }
    }
}