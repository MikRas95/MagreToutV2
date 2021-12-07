using Microsoft.VisualStudio.TestTools.UnitTesting;
using MalgreToutV2.Services.EFServices;
using System;
using System.Collections.Generic;
using System.Text;
using MalgreToutV2.Models;
using MalgreToutV2.Services.Interface;
using System.Linq;



namespace MalgreToutV2.Services.EFServices.Tests {
    [TestClass()]
    public class PickupPointServiceTests {
        static MalgretoutDBContext context = new MalgretoutDBContext();
        static IPickupPoint pService = new PickupPointService(context);
        
        [TestMethod()]
        public void TestPickupCRUD() {

            //Får alle vores pickupPoints
            IEnumerable<DemoPickupPoint> pickupPoints = pService.GetAllPickupPoints();

            //Laver testpoint
            DemoPickupPoint newPickupPoint = new DemoPickupPoint() {

                Name = "TestName",
                Address = "Testvej 1b",
                PostalCode = "4000",
                Country = "Denmark",
                PhoneNumber = "28577455",
                NoOfMagazine = 4000,
                OpeningTime = new TimeSpan(10, 0, 0),
                CloseningTime = new TimeSpan(17, 0, 0),
                ContactPerson = null
            };


            ////Tæller liste
            int numberOfPickupPoints = pickupPoints.Count<DemoPickupPoint>();

            ////Tester Add
            //pService.AddPickupPoint(newPickupPoint);

            ////Assert

            DemoPickupPoint newPickupPointTest = pService.GetPickupPoint(newPickupPoint.PickupPointId);

            ////Assert.AreEqual(newPickupPoint, newPickupPointTest, "Testing AddPickupPoint failed");
            ////Assert.AreEqual(numberOfPickupPoints + 1, pickupPoints.Count<DemoPickupPoint>(), "Testing AddPickupPoint failed regarding number of objects in list");


            ////Tester Update
            //DemoPickupPoint toBeUpdated = pService.GetPickupPoint(newPickupPoint.PickupPointId);

            ////Opsætning
            //toBeUpdated.Name = "Nytnavn";
            //pService.Update(toBeUpdated);

            ////Assert
            //Assert.AreEqual("Nytnavn", toBeUpdated.Name, "Testing update failed");





            //Tester Delete

            //Opsætning
            DemoPickupPoint pickupPointToBeDeleted = pService.GetPickupPoint(newPickupPoint.PickupPointId);

            //Sletter
            pService.DeletePickupPoint(newPickupPoint);

            //Assert
            DemoPickupPoint deletedPickupPoint = pService.GetPickupPoint(10);
            Assert.IsNull(deletedPickupPoint, "Testing Delete failed");
            Assert.AreEqual(numberOfPickupPoints, pickupPoints.Count<DemoPickupPoint>(), "Testing Delete failed regarding number of objects in list");

        }
        //public void PickupPointServiceTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void UpdateTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetPickupPointTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void AddPickupPointTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DeletePickupPointTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetAllPickupPointsTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetPickupPointByIdTest() {
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetPickupPointsTest() {
        //    Assert.Fail();
        //}
    }
}