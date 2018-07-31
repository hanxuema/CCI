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
            var _str = str;
            for (int i = 0; i < str.Length; i++)
            {
                var count = 0;
                for (int k = 0; k < _str.Length; k++)
                {
                    if (str[i].Equals(_str[k]))
                    {
                        count++;
                    }
                    if (count >= 2)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
