using System;
namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = "Pavel";
            var lastname = "Rusakovich";
            var fullname = firstname + " " + lastname;
            var myfullname = string.Format("My name is {0} {1}", firstname, lastname);

            var names = new string[3] { "John", "Jack", "mary" };
            var formattednames = string.Join(",", names);



            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
       Console.WriteLine(text);
        }

    }
}
