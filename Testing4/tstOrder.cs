using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the new Class specified below
            clsOrder AnOrder = new clsOrder();
            // Tests to check existence
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void FulfilledOrderOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = true;
            // assign the data to the property
            AnOrder.Fulfilled = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.Fulfilled, TestData);
        }

        [TestMethod]
        public void FulfilledValid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = true;
            //create error message
            string Error = "";
            Error = AnOrder.FulfilledValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FulfilledMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = false;
            //create error message
            string Error = "";
            Error = AnOrder.FulfilledValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FulfilledMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = true;
            //create error message
            string Error = "";
            Error = AnOrder.FulfilledValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AnOrder.DateAdded = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void DateAddedMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(-1);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NoOfCasesOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.NoOfCases = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.NoOfCases, TestData);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.ProductID = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.ProductID, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "15 Sowe Valley, Leicester, LE1 2NF";
            // assign the data to the property
            AnOrder.Address = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        [TestMethod]
        public void AddressValid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "17 Arminia Street, Leicester, LE4 6ER";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "1";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "17";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(99, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(100, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(101, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(50, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtreme()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(5000, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.CustomerID = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderNoOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.OrderNo = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
    }
   

}
