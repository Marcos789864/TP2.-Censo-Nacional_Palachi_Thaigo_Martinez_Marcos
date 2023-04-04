public static class Funciones
{
    public static string IngresarTexto(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }
    public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero == -1)
        {  
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }


    public static int IngresoOpciones()
    {
        int eleccion = 0;
    Console.WriteLine("(1)Cargar Nueva Persona (2) Obtener Estadísticas del Censo (3)Buscar Persona (4) Modificar Mail de una Persona. (5)Salir ");
     eleccion = Funciones.IngresarEnteroEnRango("Ingrese la opcion que desea realizar",1,5);
    Console.Clear();
    return eleccion;
    }


    public static void IngresarPersona()
    {
           string nom = IngresarTexto("Ingrese el nombre de la persona ");
        string username = IngresarTexto("Ingrese el nombre de la persona ");
        int id = 0;
        id = validarDni(id);
        DateTime nacimiento = IngresarFecha("Ingrese su fecha de nacimiento ");
        string mail = IngresarTexto("Ingrese su email ");
        Persona unPersona= new Persona(id,username,nom,nacimiento,mail);
        Console.WriteLine("Se ha creado la persona" + nom + " " + username + " exitosamente");
        Console.ReadLine();
        Censo.ListaPersona.Add(unPersona);
       
    }


    public static int IngresarEnteroEnRango(string msj, int minimo, int maximo)
    {
        int entero;
        entero = IngresarEntero(msj);
        while (entero < minimo || entero > maximo)
        {
            entero = IngresarEntero("ERROR! " + msj);
        }
        return entero;
    }






    public static DateTime IngresarFecha(string msj)
    {
        DateTime fechaDate;
        string fechaCadena = IngresarTexto(msj);
        while (!DateTime.TryParse(fechaCadena, out fechaDate))
        {
            fechaCadena = IngresarTexto("ERROR! " + msj);
        }
        return fechaDate;
    }




    public static int validarDni(int dni)
    {
        dni= IngresarEntero("Ingrese su DNI");
        bool encontrado = false;
        int i = 0;
        if(Censo.ListaPersona.Count > 0)
        {
            while(i < Censo.ListaPersona.Count || encontrado == true)
       {
            Persona item = Censo.ListaPersona[i];
            if(item.DNI == dni)
            {
                dni= IngresarEntero("Ingrese el nuevo del DNI");
                encontrado = true;
                item.DNI = dni;
            }
            else
            i++;
       }
    }
       return dni;
    }


    public static void ObtenerEstadisticasCenso()
    {
        int contadorValido = 0;
        int edad = 0;
        bool valido;  
        if(Censo.ListaPersona.Count <= 0)
        {
            Console.WriteLine("No se ha ingresado ninguna persona a la lista");
            Console.ReadLine();
        }
        else{
            for(int i = 0; i < Censo.ListaPersona.Count; i++)
        {
            Persona item = Censo.ListaPersona[i];
            edad += item.ObtnerEdad();
            valido = item.PuedeVotar();
            if( valido == true)
            {
                contadorValido++;
            }
        }


        Console.WriteLine("La cantidad de personas: " + Censo.ListaPersona.Count);
   
        Console.WriteLine("Personas habilitadas para votar " + contadorValido );


        Console.WriteLine("El promedio de edad es: " + edad/Censo.ListaPersona.Count);
        Console.ReadLine();
        }        
    }


    public static void BuscarPersona()
    {
       
        bool encontrado = false;
        int edad = 0 ;
        int i = 0;
        if(Censo.ListaPersona.Count <= 0)
        {
            Console.WriteLine("No se ha ingresado ninguna persona a la lista aun");
            Console.ReadLine();
        }
        else
        {
           
            while( i < Censo.ListaPersona.Count && encontrado == false)
         {
           
             int dni = IngresarEntero("Ingrese un DNI ingresado anteriormente, para obtener la informacion de la persona");
            Persona  item = Censo.ListaPersona[i];


            if(item.DNI == dni)
            {  
                encontrado = true;
                edad = item.ObtnerEdad();
                Console.WriteLine("Nombre: " + item.Nombre);
                Console.WriteLine("Apellido: " + item.Apellido);
                Console.WriteLine("Edad: " + edad );
                Console.WriteLine("DNI: " + item.DNI);
                if(edad >= 18)
                Console.WriteLine("Puede votar: SI" );
                else
                {
                    Console.WriteLine("Puede votar: NO");
                }
                Console.ReadLine();
               
            }
            else
            {
                Console.WriteLine("El DNI ingresado no fue ingresado anteriormente");
                Console.ReadLine();
            }
            i++;
         }
        }
    }
    public static void ModificarMail()
    {      


        if(Censo.ListaPersona.Count <= 0)
        {
            Console.WriteLine("No se ha ingresado niungun usuario a la lista");
            Console.ReadLine();
        }
        else
        {
            int dni = IngresarEntero("Ingrese el DNI de un usuario");
            string mail = IngresarTexto("Ingrese un nuevo mail");
            for(int i = 0; i < Censo.ListaPersona.Count; i++)
            {
                Persona objeto = Censo.ListaPersona[i];
               


            if(objeto.DNI == dni)
            {      
                Console.WriteLine("Email viejo:" + objeto.Email);
                objeto.Email = mail;


                Console.WriteLine("Email nuevo: " + objeto.Email);
                Console.ReadLine();
           
            }
           
            }
        }
       
    }
   
}


   

