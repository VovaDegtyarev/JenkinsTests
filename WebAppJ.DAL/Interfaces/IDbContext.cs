using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.DAL.Entity;

namespace WebAppJ.DAL.Interfaces
{
    public interface IDbContext
    {
        User GetUserEntity();
    }
}
