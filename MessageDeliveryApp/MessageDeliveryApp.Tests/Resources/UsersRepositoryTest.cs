using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageDeliveryApp.Models.DBObjects;
using MessageDeliveryApp.Models;
using MessageDeliveryApp.Utility;

namespace MessageDeliveryApp.Repository
{
    public class UsersRepositoryTest
    {
        private Models.DBObjects.DeliverySystemModelsDataContext dbContext;
        private string testDbConnectionString;

        private UserRepository userRepository;
        [TestInitialize]
        public void Initialize()
        {
            //initializare setup-ului de test - conexiunea cu db-ul de test 
            testDbConnectionString = ConfigurationManager.ConnectionStrings["MessageDeliveryApp.Tests.Properties.Settings.deliverysystemtestsConnectionString"].ConnectionString;
            dbContext = new Models.DBObjects.DeliverySystemModelsDataContext(testDbConnectionString);
            userRepository = new UserRepository(dbContext);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            //curatarea recordurilor din db dupa rularea testului 
            //dbContext.Users.DeleteAllOnSubmit(dbContext.Users);
            //dbContext.SubmitChanges();
        }

        [TestMethod]
        public void GetAllMembers_TwoRecordsExists()
        {
            //Arrange
            User user1 = new User
            {
                IDUser = Guid.NewGuid(),
                Description = "description1",
                Name = "name1"
                
            };

            User user2 = new User
            {
                IDUser = Guid.NewGuid(),
                Description = "description2",
                Name = "name2"
                
            };
            dbContext.Users.InsertOnSubmit(user1);
            dbContext.Users.InsertOnSubmit(user2);
            dbContext.SubmitChanges();

            //Act 
            List<UsersModel> result = userRepository.GetAllUsers();

            //Assert
            Assert.AreEqual(2, result.Count);
            //utility for checking two objects are the same
            AssertUtility.AssertAreEqual(user1, result[0]);
            AssertUtility.AssertAreEqual(user2, result[1]);
        }
        [TestMethod]
        public void GetUserByID_UserExists()
        {
            //Arrange 
            Guid ID = Guid.NewGuid();
            User expectedUser = new User
            {
                IDUser = ID,
                Description = "description1",
                Name = "name1"
                
            };
            User user2 = new User
            {
                IDUser = Guid.NewGuid(),
                Description = "description2",
                Name = "name2"
             
            };
            dbContext.Users.InsertOnSubmit(expectedUser);
            dbContext.Users.InsertOnSubmit(user2);
            dbContext.SubmitChanges();

            //Act
            UsersModel result = userRepository.GetUserByID(ID);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(ID, result.IDUser);
            AssertUtility.AssertAreEqual(expectedUser, result);
        }
        [TestMethod]
        public void InsertUser()
        {
            //Arrange 
            UsersModel userModel = new UsersModel
            {
                IDUser = Guid.NewGuid(),
                Description = "description1",
                Name = "name1"
               
            };
            //Act
            userRepository.InsertUser(userModel);

            //Assert 
            User dbUser = dbContext.Users.FirstOrDefault(x => x.IDUser == userModel.IDUser);
            Assert.IsNotNull(dbUser);
        }
        
        [TestMethod]
        public void DeleteUser_RecordExists()
        {
            //Arrange 
            Guid ID = Guid.NewGuid();
            User expectedUser = new User
            {
                IDUser = Guid.NewGuid(),
                Description = "description1",
                Name = "name1"
            };
            User user2 = new User
            {
                IDUser = Guid.NewGuid(),
                Description = "description2",
                Name = "name2"
            };
            dbContext.Users.InsertOnSubmit(expectedUser);
            dbContext.Users.InsertOnSubmit(user2);
            dbContext.SubmitChanges();

            //Act 
            //userRepository.DeleteUser(ID);

            //Assert 
            User dbUser = dbContext.Users.FirstOrDefault(x => x.IDUser == ID);
            Assert.IsNull(dbUser);
            User dbUserNotUpdated = dbContext.Users.FirstOrDefault(x => x.IDUser == user2.IDUser);
            Assert.IsNotNull(dbUserNotUpdated);
        }
    }
}
