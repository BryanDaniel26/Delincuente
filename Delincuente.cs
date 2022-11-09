using System;

//definir una struct

struct Delincuente 
{
    //public string x;
    public ulong x;
    public double y;
    public void delincuente (ulong numeroCedula, double montoRobado)
    {
        x = numeroCedula;
        y = montoRobado;
    }

    public void mostrarDelincuente()
    {
        Console.WriteLine("Hola soy {0}",x);
        Console.WriteLine("Y estoy aqui interno por un robito de {0}",y);
    }
}

class MyClient
{
    public unsafe static void Main()
    {
        //MiStruct ms = new MiStruct(); //Asi es OK, tambien
        Delincuente ms;
        Delincuente * ps = &ms; //Declara un puntero a la struct y lo inicializa con su direccion.
        ps->delincuente(99999, 1234.56); //accede a los miembros de la struct con el operador de punteros ->
        ps->mostrarDelincuente();
    }
}