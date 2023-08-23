using ClubMemberShip_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMemberShip_App.Data
{
    public interface ILogin
    {
        User Login(string emailAddress, string password);

    }
}
