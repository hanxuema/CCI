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
            Console.WriteLine(TripleStep(10));
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

        public static string StringCompression(string value)
        {
            StringBuilder result = new StringBuilder();
            var count = 1;
            var temp = "";
            var nextIsSame = false;
            for (int i = 0; i < value.Length; i++)
            {
                if (i + 1 == value.Length)
                {
                    nextIsSame = false;
                }
                else
                {

                    if (value[i] == value[i + 1])
                    {
                        if (count == 1)
                        {
                            temp = value[i].ToString();
                        }
                        nextIsSame = true;
                        count++;
                    }
                    else
                    {
                        temp = value[i].ToString();
                        nextIsSame = false;
                    }
                }
                if (!nextIsSame)
                {
                    result.Append(string.Format("{0}{1}", temp, count));

                    count = 1;
                }

            }


            return result.ToString();
        }

        //check if string second is the rotation of string first
        public static bool stringRotation(string first, string second)
        {
            var result = false;
            for (int i = 0; i < first.Length; i++)
            {
                second = shirtString(second, 1);
                if (first == second)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static string shirtString(string value, int d)
        {
            //create new array with same length 
            var newArr = new char[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                if (i + d > value.Length - 1)
                {
                    newArr[i] = value[i + d - value.Length];
                }
                else
                {
                    newArr[i] = value[i + d];
                }
            }

            return new string(newArr);
        }

        public static void removeDuplicateFromLinkedList(LinkedListNode<int> node)
        {
            HashSet<int> hash = new HashSet<int>();
            LinkedListNode<int> previous = null;
            while (node != null)
            {
                if (hash.Contains(previous.Value))
                {
                    previous.Next = node.Next;
                }
                else
                {
                    hash.Add(node.Value);
                    previous = node;
                }
                node = node.Next;
            }
        }

        public static int TripleStep(int numberOfSteps)
        {
            if (numberOfSteps < 0)
            {
                return 0;
            }
            if (numberOfSteps == 0)
            {
                return 1;
            }
            else
            {
                return TripleStep(numberOfSteps - 1) + TripleStep(numberOfSteps - 2) + TripleStep(numberOfSteps - 3);
            }

        }

        public static int TripleStepDynamic(int numberOfSteps)
        {
            int[] memo = new int[numberOfSteps + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }
            return countWays(numberOfSteps, memo);
        }

        private static int countWays(int numberOfSteps, int[] memo)
        {
            if (numberOfSteps < 0)
            {
                return 0;
            }
            else if (numberOfSteps == 0)
            {
                return 1;
            }
            else if (memo[numberOfSteps] > -1)
            {
                return memo[numberOfSteps];
            }
            else
            {
                memo[numberOfSteps] = countWays(numberOfSteps - 1, memo) + countWays(numberOfSteps - 2, memo) + countWays(numberOfSteps - 3, memo);
                return memo[numberOfSteps];
            }
        }

        static int superDigit(string n, int k)
        {
            if (int.Parse(n) <= 10)
            {
                return int.Parse(n);
            }
            else
            {
                var sum = 0;
                for (int i = 0; i < k; i++)
                {
                    var value = int.Parse(n[i].ToString());
                    sum = sum + value;
                }
                return superDigit(sum.ToString(), sum.ToString().Length);
            }
        }

    }
}
