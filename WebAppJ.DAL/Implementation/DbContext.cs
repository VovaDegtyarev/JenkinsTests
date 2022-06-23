using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.DAL.Entity;
using WebAppJ.DAL.Interfaces;

namespace WebAppJ.DAL.Implementation
{
    public class DbContext : IDbContext
    {
        public User GetUserEntity()
        {
            var user = new User() 
            {
                Id = 1,
                Name = "Vova"
            };

            return user;
        }
    }
}
