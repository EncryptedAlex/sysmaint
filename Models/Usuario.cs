
namespace sysmaintapp.Models{

public class Usuario{

    public string? passUser {get;set;}
    public string? emailUser {get;set;}
    

    public bool validar(){
    if(emailUser=="admin@q.com" && passUser == "123"){
            return true;
        }
        else {
            
            return false;
        }
    }

    }
        
    }