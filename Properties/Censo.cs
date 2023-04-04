public static class Censo
{
    public static List<Persona> ListaPersona {get;set;}

    public static void Menu()
    {
        ListaPersona = new List<Persona>();
        int eleccion = Funciones.IngresoOpciones();
while(eleccion != 5)
{
    switch (eleccion)
{
    case 1:
      Funciones.IngresarPersona();
    break;
    case 2:
       Funciones.ObtenerEstadisticasCenso();
    break;
    case 3:
        Funciones.BuscarPersona();
    break;
    case 4:
    Funciones.ModificarMail();
    break;
}
Console.Clear();
 eleccion = Funciones.IngresoOpciones();
}
    }
}
