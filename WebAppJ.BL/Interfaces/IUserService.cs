using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.BL.Models;

namespace WebAppJ.BL.Interfaces
{
    public interface IUserService
    {
        UserItem GetUser();
    }
}
