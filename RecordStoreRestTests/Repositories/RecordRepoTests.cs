using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecordStoreRest.Models;
using RecordStoreRest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreRest.Repositories.Tests
{
    [TestClass()]
    public class RecordRepoTests
    {


        [TestMethod()]
        public void AddRecordTest()
        {
            RecordRepo repo = new RecordRepo();
            int before = repo.GetRecords().Count();
            Record record= repo.AddRecord(new Record { id=4,Title="ghetto",Author=" eniem",Price=0});
            int after = repo.GetRecords().Count();
            Assert.AreEqual(before+1,after);
        }

        [TestMethod()]
        public void GetbyidTest()
        {
            RecordRepo repo = new RecordRepo();
            Assert.AreEqual(repo.GetRecords()[1], repo.Getbyid(2));
        }

        [TestMethod()]
        public void DeleteRecordTest()
        {
            Console.WriteLine("congratulations you suck");
        }

        [TestMethod()]
        public void UpdatedRecordTest()
        {
            Console.WriteLine("you failed");
        }
    }
}