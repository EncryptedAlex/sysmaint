using sysmaintapp.Services;
using System.Collections.Generic;

namespace sysmaintapp.Models
{
    public class Usuario
    {
        public string? passUser { get; set; }
        public string? emailUser { get; set; }

        public bool validar()
        {
            // Obtener la lista de usuarios desde UserRegisterService
            List<UserRegister> userRegisters = UserRegisterService.GetAll();
            /*
            Console. WriteLine("Correo: "+emailUser);
            Console. WriteLine("contra: "+passUser);
            Console. WriteLine("------------------: ");
            */

            foreach (var userRegister in userRegisters)
            {
                /*
                Console. WriteLine("Correo: "+userRegister.Email_user);
                Console. WriteLine("contra: "+userRegister.Pass_user);
                Console. WriteLine("Correo: "+userRegister.Name_user);
                Console. WriteLine("contra: "+userRegister.DNI_user);
                */
                if (emailUser == userRegister.Email_user && passUser == userRegister.Pass_user)
                {
                    return true; // Credenciales válidas
                }
            }

            return false; // Credenciales inválidas
        }
    }
}
