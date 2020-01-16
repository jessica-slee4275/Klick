using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klick
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Sentence >> ");
            String inputStr = Console.ReadLine();
            string split = generateInput(inputStr);
            if (split.Length > 0)
            {
                printOutput(inputStr, split);
            }
            else
            {
                Console.WriteLine("Invalid input. - Verb can't be found in the repository.");
            }   
        }
        public static string generateInput(string inputStr)
        {
            string split = "";
            
            String[] inputStrList = inputStr.Split(' ');

            String[] splitList = { "likes", "like" };
            
            foreach (var sp in splitList)
            {
                foreach (var input in inputStrList)
                {
                    if (input == sp)
                    {
                        split = sp;
                    }
                }
            }
            return split;
        }
        public static void printOutput(string inputStr, string split)
        {
            if (inputStr[inputStr.Length - 1] == '.')
            {
                inputStr = inputStr.Replace(".", "");
            }
            String[] strlist = inputStr.Split(new String[] { split }, StringSplitOptions.RemoveEmptyEntries);

            //output
            strlist[0] = strlist[0].Trim();
            strlist[1] = strlist[1].Trim();
            string changedStr = strlist[1] + " " + split + " " + strlist[0] + ".";

            Console.WriteLine(changedStr);
            
        }
    }
}
