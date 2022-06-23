using WebAppJ.BL.Interfaces;
using WebAppJ.BL.Models;
using WebAppJ.DAL.Interfaces;

namespace WebAppJ.BL.Implementation
{
    public class UserService : IUserService
    {
        private IDbContext db;

        public UserService(IDbContext dbContext)
        {
            db = dbContext;
        }

        public UserItem GetUser()
        {
            var user = db.GetUserEntity();

            var userItem = new UserItem()
            {
                Id = user.Id,
                Name = user.Name,
            };

            return userItem;
        }
    }
}
