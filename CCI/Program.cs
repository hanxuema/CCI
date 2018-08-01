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

        public static bool CheckPermutation(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }
            var result = true;
            var i = 0;
            var k = second.Length - 1;
            do
            {
                if (first[i] != second[k])
                {
                    result = false;
                    break;
                }
                else
                {
                    i++;
                    k--;
                }
            } while (!result && i < first.Length);

            return result;
        }

        public static bool OneAway(string first, string second)
        {
            var result = false;

            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return result;
            }
            if (first.Length == second.Length)
            {
                return checkIfOneCharacterReplace(first, second);
            }
            if (first.Length < second.Length)
            {
                return checkIfOnecharacterRemoved(first, second);
            }
            if (second.Length < first.Length)
            {
                return checkIfOnecharacterRemoved(second, first);
            }
            return result;
        }

        public static bool checkIfOnecharacterRemoved(string small, string big)
        {
            var result = true;
            var count = 0;
            for (int i = 0; i < small.Length; i++)
            {
                if (i == small.Length - 1)
                {
                    return true;
                }
                if (small[i] != big[i])
                {
                    count++;
                }
                if (count > 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public static bool checkIfOneCharacterReplace(string first, string second)
        {
            var result = true;
            var count = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    count++;
                }
                if (count > 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public static string URLify(string value)
        {
            var spaceChar = "%20";

            StringBuilder sb = new StringBuilder();
            var isPreSpace = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != ' ')
                {
                    sb.Append(value[i]);
                    isPreSpace = false;
                }
                else
                {
                    if (isPreSpace)
                    {
                        continue;
                    }
                    sb.Append(spaceChar);
                    isPreSpace = true;
                }
            }
            return sb.ToString();
        }
    }
}
