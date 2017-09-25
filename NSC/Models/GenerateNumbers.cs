using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NSC.Models
{
    public static class GenerateNumbers
    {
        //S3.1.1 All numbers up to and including the number entered,
        public static List<int> GetAllNumbers(int number) {
            try
            {
                if (number > 0)
                {
                    List<int> numberList = new List<int>();
                    for (int i = number; i >= 0; i--)
                    {
                        numberList.Add(i);
                    }
                    numberList.Sort();
                    return numberList;
                }
                else
                    return null;
            }
            catch (Exception ex) { ExceptionHandler.HandleError("GetAllNumbers - " + ex.Message); return null; }
        }

        //S3.1.2 All odd numbers up to and including the number entered,
        public static List<int> GetOddNumbers(int number)
        {
            try
            {
                if (number > 0)
                {
                    List<int> numberList = new List<int>();
                    for (int i = 0; i <= number; i++)
                    {
                        if ((i % 2) != 0)
                        {
                            numberList.Add(i);
                        }
                    }
                    return numberList;
                }
                else
                    return null;
            }
            catch (Exception ex) { ExceptionHandler.HandleError("GetOddNumbers - " + ex.Message); return null; }
        }

        //S3.1.3 All even numbers up to and including the number entered,
        public static List<int> GetEvenNumbers(int number)
        {
            try
            {
                if (number > 0)
                {
                    List<int> numberList = new List<int>();
                    for (int i = 0; i <= number; i++)
                    {
                        if (((i % 2) == 0) && i != 0)
                        {
                            numberList.Add(i);
                        }
                    }
                    return numberList;
                }
                else
                    return null;
            }
            catch (Exception ex) { ExceptionHandler.HandleError("GetEvenNumbers - " + ex.Message); return null; }
        }

        //S3.1.4 All numbers up to and including the number entered, except when,
        //S3.1.4.1 A number is a multiple of 3 output C, and when,
        //S3.1.4.2 A number is a multiple of 5 output E, and when,
        //S3.1.4.3 A number is a multiple of both 3 and 5 output Z,
        public static List<string> GetCustomNumbers(int number)
        {
            try
            {
                if (number > 0)
                {
                    List<string> numberList = new List<string>();
                    for (int i = 0; i <= number; i++)
                    {
                        if (i == 0)
                            numberList.Add(i.ToString());
                        else if ((i % 3) == 0 && (i % 5) == 0 && i != 0)
                            numberList.Add("Z");
                        else if ((i % 5) == 0)
                            numberList.Add("E");
                        else if ((i % 3) == 0)
                            numberList.Add("C");
                        else
                            numberList.Add(i.ToString());
                    }
                    return numberList;
                }
                else
                    return null;
            }
            catch (Exception ex) { ExceptionHandler.HandleError("GetCustomNumbers - " + ex.Message); return null; }
        }

        //S3.1.5 All fibonacci number up to and including the number entered.
        public static List<int> GetFibonacciNumbers(int number)
        {
            try
            {
                if (number > 0)
                {
                    List<int> numberList = new List<int>();
                    int num1 = 0, num2 = 1, numResult = 0;
                    numberList.Add(num1);
                    numberList.Add(num2);
                    for (int i = 0; i < number; i++)
                    {
                        numResult = num1 + num2;
                        if (numResult > number - 1)
                            break;
                        numberList.Add(numResult);
                        num1 = num2;
                        num2 = numResult;
                    }
                    return numberList;
                }
                else
                    return null;
            }
            catch (Exception ex) { ExceptionHandler.HandleError("GetFibonacciNumbers - " + ex.Message); return null; }
        }
    }
}