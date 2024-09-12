using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleAPP
{
    public class Test
    {
        private List<string> list = null;
        public Test()
        {
            Console.WriteLine("List Generated:");
            list = new List<string>() {
                "Paul","Mark"
            };
        }
        public List<string> Names
        {
            get
            {
                return list;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Lazy Initialization - this will not call the constructor of this class until the value is accessed
            Lazy<Test> lazy = new Lazy<Test>();
            // Check if the data is loaded or not - it is not
            Console.WriteLine("Data Loaded : " + lazy.IsValueCreated);
            // Access the data - this will call the constructor of the class
            Test t = lazy.Value;
            // Output the data
            foreach (string tmp in t.Names)
            {
                Console.WriteLine(tmp);
            }
            Console.ReadLine();
        }
    }
}