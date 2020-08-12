using MyNotes.SOLID_Principles.Interface_Segregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotes.SOLID_Principles.Interface_Segregation.Classes
{
    public class UserRepository : IWriteable<User>, IReadable<User>, IRemovable<User>
    {
        public void Add(User entity)
        {
            //code to Add
        }

        public void Delete(int id)
        {
            //code to Delete
        }

        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();
            //Code to retrieve all
            return users;
        }

        public User GetById(int id)
        {
            //Code to get a specific user
            return new User();
        }

        public void Update(User entity)
        {
            //Code to update
        }
    }
}
