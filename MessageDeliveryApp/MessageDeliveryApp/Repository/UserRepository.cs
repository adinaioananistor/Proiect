using System;
using System.Collections.Generic;
using System.Linq;
using MessageDeliveryApp.Models;


namespace MessageDeliveryApp.Repositories
{
    public class UserRepository
    {
        //injectam container-ul ORM 
        private Models.DBObjects.DeliverySystemModelsDataContext dbContext;

        public UserRepository()
        {
            this.dbContext = new Models.DBObjects.DeliverySystemModelsDataContext();
        }

        //injectam un dbContext pentru a face repository noastra testabila 
        public UserRepository(Models.DBObjects.DeliverySystemModelsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<UsersModel> GetAllUsers()
        {
            List<UsersModel> userList = new List<UsersModel>();
            foreach (Models.DBObjects.User dbUser in dbContext.Users)
            {
                userList.Add(DbObjectMapToModel(dbUser));
            }
            return userList;
        }

        public UsersModel GetUserByID(Guid ID)
        {
            return DbObjectMapToModel(dbContext.Users.FirstOrDefault(x => x.IDUser == ID));
        }
        
        public void InsertUser(UsersModel userModel)
        {
            userModel.IDUser = Guid.NewGuid(); //generate new ID for the new record

            dbContext.Users.InsertOnSubmit(MapModelToDbObject(userModel));
            //add to ORM layer 
            dbContext.SubmitChanges(); //commit to db 
        }

        public void UpdateUser(UsersModel userModel)
        {
            //get existing record to update
            Models.DBObjects.User existingUser = dbContext.Users.FirstOrDefault(x => x.IDUser == userModel.IDUser);
            if (existingUser!= null)
            {
                //map updated values with keeping the ORM 
                existingUser.IDUser = userModel.IDUser;
                existingUser.Name = userModel.Name;
                existingUser.Mail = userModel.Mail;
                existingUser.Description = userModel.Description;
                existingUser.JoinDate = userModel.JoinDate;
                dbContext.SubmitChanges();//commit to db 
            }
        }
        public void DeleteUser(Guid ID)
        {
            //get existing record to delete 
            Models.DBObjects.User userToDelete = dbContext.Users.FirstOrDefault(x => x.IDUser == ID);
            if (userToDelete != null)
            {
                dbContext.Users.DeleteOnSubmit(userToDelete); //mark for deletion 

                dbContext.SubmitChanges(); //commit to db 
            }
        }

        //map ORM model to Model object – mapper method
        private UsersModel DbObjectMapToModel(Models.DBObjects.User dbUser)
        {
            UsersModel userModel = new UsersModel();
            if (dbUser != null)
            {
                userModel.IDUser = dbUser.IDUser;
                userModel.Name = dbUser.Name;
                userModel.Mail = dbUser.Mail;
                userModel.Description = dbUser.Description;
                userModel.JoinDate = dbUser.JoinDate;
                return userModel;
            }
            return null;
        }

        //map Model object to ORM model – mapper method
        private Models.DBObjects.User MapModelToDbObject(UsersModel userModel)
        {
            Models.DBObjects.User dbUserModel = new Models.DBObjects.User();
            if (userModel != null)
            {
                dbUserModel.IDUser = userModel.IDUser;
                dbUserModel.Name = userModel.Name;
                dbUserModel.Mail = userModel.Mail;
                dbUserModel.Description = userModel.Description;
                dbUserModel.JoinDate = userModel.JoinDate;
                return dbUserModel;
            }
            return null;
        }


    }
}
