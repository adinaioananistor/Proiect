using MessageDeliveryApp.Mappers;
using MessageDeliveryApp.Models;
using MessageDeliveryApp.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageDeliveryApp.Repository
{
    public class UserRepository
    {
        private Models.DBObjects.DeliverySystemModelsDataContext dbContext;
        public UserRepository()
        {
            this.dbContext = new Models.DBObjects.DeliverySystemModelsDataContext();
        }
        public UserRepository(Models.DBObjects.DeliverySystemModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<UsersModel> GetAllUsers()
        {
            List<UsersModel> users = new List<UsersModel>();
            foreach (Models.DBObjects.User user in dbContext.Users)
            {
                users.Add(user.ObjectMap<UsersModel>());
            }
            return users;
        }
        public UsersModel GetUserByID(Guid ID)
        {
            Models.DBObjects.User existingUser = dbContext.Users.FirstOrDefault(x => x.IDUser == ID);
            if (existingUser != null)
                return existingUser.ObjectMap<UsersModel>();
            else
                return null;
        }
        public void InsertUser(UsersModel userModel)
        {
            userModel.IDUser = Guid.NewGuid(); //generate new ID for the new record 

            dbContext.Users.InsertOnSubmit(MapModelToDbObject(userModel));//add to ORM layer 

            dbContext.SubmitChanges(); //commit to db 
        }

        private User MapModelToDbObject(UsersModel userModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UsersModel userModel)
        {
            Models.DBObjects.User existinguser = dbContext.Users.FirstOrDefault(x => x.IDUser == userModel.IDUser);
            if (existinguser != null)
            {
                existinguser.UpdateObject(userModel);
                dbContext.SubmitChanges();
            }
        }
        public void DeleteMember(Guid ID)
        {
            Models.DBObjects.User memberToDelete = dbContext.Users.FirstOrDefault(x => x.IDUser == ID);
            if (memberToDelete != null)
            {
                dbContext.Mesajes.DeleteAllOnSubmit(memberToDelete.Mesajes);
                dbContext.Users.DeleteOnSubmit(memberToDelete);
                dbContext.SubmitChanges();
            }
        }

        internal void UpdateUser(object userModelToUpdate)
        {
            throw new NotImplementedException();
        }

        internal void DeleteUser(Guid iD)
        {
            throw new NotImplementedException();
        }

        public static void DeleteUser(Guid guid, Guid iD)
        {
            throw new NotImplementedException();
        }
    }
}
        
