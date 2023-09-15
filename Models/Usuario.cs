
namespace sysmaintapp.Models{

public class Usuario{
    public int Id  {get;set;}
    public string? Contraseña {get;set;}
    public string? NombreUsuario {get;set;}
    

    public string? validador {get;set;}


    public bool validar(){
    if(NombreUsuario=="negro" && Contraseña == "123456"){
            return true;
        }
        else {
            validador="Datos Incorrectos";
            return false;
        }
    }

    }

        
    }