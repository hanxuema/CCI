using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        //1.1 in chapter 1, arrays and strings
        public static bool CheckUniqueCharactersInString(string stringValue)
        {
            var str = stringValue.ToLower();
            var result = true;
            var dic = new Dictionary<char, char>();
            foreach (var c in str)
            {
                if (dic.ContainsKey(c))
                {
                    result = false;
                    break;
                }
                else
                {
                    dic.Add(c, c);
                }
            }
            return result;
        }
    }
}
