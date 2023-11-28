using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.KasenovAE.Sprint5.TaskReview.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileExists()
        {
            string path = @"C:\Users\kasen\source\repos\Tyuiu.KasenovAE.Sprint5.Review\Tyuiu.KasenovAE.Sprint5.TaskReview.V1\bin\Debug\OutPutDataFileTask7V1.txt";
            bool res = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
