using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rental_sys_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_sys_project.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Manage mng = new Manage();
            mng.CustomerDelete(1);
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Form2Test()
        {
            Manage mng = new Manage();
            mng.VideoDelete(1);
            Assert.IsTrue(true);
        }


    }
}