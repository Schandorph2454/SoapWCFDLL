using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapWCFDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapWCFDLL.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetNameSoapTest()
        {
            //Arrange
            Service1 myName = new Service1();
            //Act
            string hallo = myName.GetNameSoap();
            //Assert
            Assert.AreEqual("Linda", hallo);
        }
    }
}