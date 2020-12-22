using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Services
{
    class UserSession
    {
        private static User user;

        private static readonly UserSession userSession = new UserSession();

        private UserSession()
        {
           
        }

        public static UserSession GetInstance() => userSession;

        public User GetUser() => user;
    }
}
