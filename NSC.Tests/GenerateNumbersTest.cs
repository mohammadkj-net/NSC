using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSC.Models;
using NSC.Controllers;

namespace NSC.Tests
{
    [TestClass]
    public class GenerateNumbersTest
    {
        [TestMethod]
        public void GetAllNumbers()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5 };
            List<int> expectedList = arr.ToList<int>();
            
            CollectionAssert.AreEqual(expectedList, GenerateNumbers.GetAllNumbers(5));
        }

        [TestMethod]
        public void GetAllNumbersWithNullArgument()
        {
            Assert.AreEqual(null, GenerateNumbers.GetAllNumbers(-19));
        }

        [TestMethod]
        public void GetOddNumbers()
        {
            int[] arr = { 1,3,5};
            List<int> expectedList = arr.ToList<int>();
            CollectionAssert.AreEqual(expectedList, GenerateNumbers.GetOddNumbers(5));
        }

        [TestMethod]
        public void GetOddNumbersWithNullArgument()
        {
            Assert.AreEqual(null, GenerateNumbers.GetOddNumbers(-19));
        }

        [TestMethod]
        public void GetEvenNumbers()
        {
            int[] arr = { 2, 4 };
            List<int> expectedList = arr.ToList<int>();
            CollectionAssert.AreEqual(expectedList, GenerateNumbers.GetEvenNumbers(5));
        }

        [TestMethod]
        public void GetEvenNumbersWithNullArgument()
        {
            Assert.AreEqual(null, GenerateNumbers.GetEvenNumbers(-19));
        }

        [TestMethod]
        public void GetCustomNumbers()
        {
            string[] arr = { "0","1","2","C","4","E" };
            List<string> expectedList = arr.ToList<string>();
            CollectionAssert.AreEqual(expectedList, GenerateNumbers.GetCustomNumbers(5));
        }

        [TestMethod]
        public void GetCustomNumbersWithNullArgument()
        {
            Assert.AreEqual(null, GenerateNumbers.GetCustomNumbers(-19));
        }

        [TestMethod]
        public void GetFibonacciNumbers()
        {
            int[] arr = { 0,1,1,2,3 };
            List<int> expectedList = arr.ToList<int>();
            CollectionAssert.AreEqual(expectedList, GenerateNumbers.GetFibonacciNumbers(5));
        }

        [TestMethod]
        public void GetFibonacciNumbersWithNullArgument()
        {
            Assert.AreEqual(null, GenerateNumbers.GetFibonacciNumbers(-19));
        }
    }
}
