public class Persona
{
    public int DNI {get;set;}
    public string Apellido{get;set;}
    public string Nombre{get;set;}
    public DateTime FechadeNacimiento{get;set;}
    public string Email{get;set;}




    public Persona (int dni,string apellido,string nombre,DateTime fnac,string email)
    {
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        FechadeNacimiento = fnac;
        Email = email;
    }


      public bool PuedeVotar()
    {  
        int Edad = ObtnerEdad();
        if(Edad >= 18) return true;
        else return false;
    }




    public int ObtnerEdad()
    {  
        int Edad = 0;
                 DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechadeNacimiento.Month, FechadeNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  Edad = DateTime.Today.Year - FechadeNacimiento.Year;
            else   Edad = DateTime.Today.Year - FechadeNacimiento.Year -1;
       return Edad;
    }
}



