using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max (5, 10));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Round(9.99));
            string greeting = "Hello World";
            Console.WriteLine(greeting);
            string txt = "Abacada";
            Console.WriteLine("The length of txt is: "+txt.Length);
            string txt1 = "Abacado";
            Console.WriteLine(txt1.ToUpper());
            Console.WriteLine(txt1.ToLower());
            string myText = "HINTS OF cs";
            Console.WriteLine(myText.ToLower());
            string total_Text = txt1 +" "+ myText;
            Console.WriteLine(total_Text);


            string name = "Joy";
            string lname = "Sarker";
            string fulName = string.Concat(name + lname);
            Console.WriteLine(fulName);
             
            
            string name1= $"My fullname is: {name} {lname}";

            Console.WriteLine(fulName.IndexOf("r"));
            Console.WriteLine(fulName[5]);

            string name3 = "My Name is Joy";
            string pr = $"My name:{name3}";
            Console.WriteLine(pr);



            string jo = "John Doe";
            int charPos = jo.IndexOf("h");

            string la = jo.Substring(charPos);
            Console.WriteLine(la);


            string pc = "My Personal Computer Name is Samsung Computer";
            int find = pc.IndexOf("P");
            string con = pc.Substring(find);
            Console.WriteLine(con);



        }
    }
}
