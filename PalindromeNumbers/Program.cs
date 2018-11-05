using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumbers
{
    public class Program
    {
        static void getStringReversed(char[] charArr) => Array.Reverse(charArr);
        //static void getIntReversed(int[] intArr) => Array.Reverse(intArr);

        static void Main(string[] args)
        {
            int counter = 1;


            try
            {
                 while (true)
                 {
                    string palnum = "";
                    string basenum = "";

                    char[] charArr = counter++.ToString().ToCharArray();

                    foreach (char ch in charArr)
                    {
                        basenum += ch;
                        //Console.WriteLine(ch);
                    }

                    getStringReversed(charArr);
                    foreach (char cha in charArr)
                    {
                        palnum += cha;
                        //Console.WriteLine(cha);
                    }

                    if (basenum == palnum)
                    {
                        Console.WriteLine(basenum + " is a Palindrome");
                        Console.ReadLine();
                    }
                 }
            }

            catch (IndexOutOfRangeException IOREx)
            {
                Console.WriteLine("Index Out of Range Exception Caught!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception Thrown " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

