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
        public void AddPickupPoint() {
            //Får alle vores pickupPoints
            IEnumerable<DemoPickupPoint> pickupPoints = pService.GetAllPickupPoints();

            //Arrange
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

            int numberOfPickupPoints = pickupPoints.Count<DemoPickupPoint>();

            //Act
            pService.AddPickupPoint(newPickupPoint);
            
            //Assert
            DemoPickupPoint newPickupPointTest = pService.GetPickupPoint(newPickupPoint.PickupPointId);
            Assert.AreEqual(newPickupPoint, newPickupPointTest, "Testing AddPickupPoint failed");
            Assert.AreEqual(numberOfPickupPoints + 1, pickupPoints.Count<DemoPickupPoint>(), "Testing AddPickupPoint failed regarding number of objects in list");
        }

        [TestMethod()]
        public void UpdateTest() {

            //Vi bruger denne function da vi ellers får problemer med tracking i databasen
            context.ChangeTracker.Clear();

            //Arrange
            IEnumerable<DemoPickupPoint> pickupPoints1 = pService.GetAllPickupPoints();
            int numberOfPickupPoints = pickupPoints1.Count<DemoPickupPoint>();
            int id = pickupPoints1.Max<DemoPickupPoint>(p => p.PickupPointId);
            DemoPickupPoint pickupPoint1 = pService.GetPickupPoint(id);
            pickupPoint1.Name = "Testnavnnytnytnyt";

            //Act
            pService.Update(pickupPoint1);

            //Assert
            Assert.AreEqual("Testnavnnytnytnyt", pickupPoint1.Name, "Testing update failed");
        }

        [TestMethod()]
        public void DeletePickupPointTest() {
            //Tester Delete

            //Arrange
            IEnumerable<DemoPickupPoint> pickupPoints = pService.GetAllPickupPoints();
            int numberOfPickupPoints = pickupPoints.Count<DemoPickupPoint>();
            int id = pickupPoints.Max<DemoPickupPoint>(p => p.PickupPointId);
            DemoPickupPoint pickupPointToBeDeleted = pService.GetPickupPoint(id);

            //Act
            pService.DeletePickupPoint(pickupPointToBeDeleted);

            //Assert
            DemoPickupPoint deletedPickupPoint = pService.GetPickupPoint(pickupPointToBeDeleted.PickupPointId);
            Assert.IsNull(deletedPickupPoint, "Testing Delete failed");
            Assert.AreEqual(numberOfPickupPoints -1, pickupPoints.Count<DemoPickupPoint>(), "Testing Delete failed regarding number of objects in list");
        }
    }
}