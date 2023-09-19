using sysmaintapp.Models;
using System.Collections.Generic;
using System.Linq;

namespace sysmaintapp.Services
{
    public static class UserRegisterService
    {
        static List<UserRegister> UserRegisters { get; }
        static int nextId = 3;

        static UserRegisterService()
        {
            UserRegisters = new List<UserRegister>
            {
                new UserRegister {  Name_user = "jon", Email_user = "admin@q.com", DNI_user = "101", Pass_user = "321"}
            };
        }

        public static List<UserRegister> GetAll() => UserRegisters;

        public static void Add(UserRegister userRegisters)
        {
            
            UserRegisters.Add(userRegisters);
        }
    }
}
