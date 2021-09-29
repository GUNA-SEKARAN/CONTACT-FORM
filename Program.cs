using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CONTATC_FORM_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************CONTATCT LIBRARY*****************************");
            //file path
            string inputFilepath =(@"F:\\.NET PROGRAM\\Project of Contact Library\\sampleinput.txt");
            string loop = "";
            do
            {

                Console.WriteLine("                                   1.ADD NAME & NUMBER");
                Console.WriteLine("                                   2.VIEW CONTATCT BOOK");
                Console.WriteLine("                                   3.SEARCH NUMBER");
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("ENTER THE NAME AND NUMBER");
                        //IDictionary<string, Int32> namenum = new Dictionary<string, Int32>();
                        String input = Console.ReadLine();
                       
                        File.AppendAllText(inputFilepath,input);
                        
                        break;

                    case "2":
                        
                        StreamReader read = new StreamReader(inputFilepath);
                        string temp = read.ReadToEnd();
                        Console.WriteLine(temp);
                        read.Close();
            
                        break;
                    case "3":
                        string[] inputfilepath=File.ReadAllText(@"F:\\.NET PROGRAM\\Project of Contact Library\\sampleinput.txt").Split(' ');
                        Console.WriteLine("ENTER THE NUM");
                        var num=Console.ReadLine();
                        bool condition = false;
                        for (int i = 0; i < inputFilepath.Length; i++)
                        {
                            if (inputfilepath[i].Contains(num) == true)
                            {
                                condition = true;
                                break;

                            }
                            else
                            {
                                condition = false;

                            }
                        }
                        if (condition == true)
                        {
                            Console.WriteLine("{0} found in data",num);
                        }
                        else
                        {

                            Console.WriteLine("{0} not found in data",num);
                        }
                        
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue(y/n)");
                loop = Console.ReadLine();
            } while (loop == "Y" || loop == "y");
      
           
        }
    }
}
