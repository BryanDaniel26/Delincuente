using System;

class Tarjeta{
    private ulong numeroTarjeta;
    private string clave;
    private double balance;

    private Tarjeta(ulong nt, double ba){
        numeroTarjeta = nt;
        balance = ba;
        Console.WriteLine("Se ha emitido la tarjeta numero " + nt " con balance ="+ba);
    }

    public void setClave(string clave){
        this.clave = clave;
    }

    public void depositar(double de){
        balance = balance + de;
        Console.WriteLineLine("Usted ha realizado un deposito de "+ de + "Su balance ahora es de: "+ balance);
    }

    public void retirar(double re){
        if((balance > 100 && re < balance) && (!(balance - re)<100)) balance = balance - re;

        else{
            Console.WriteLine("No es posible hacer su transacion, su balance actual es "+ balance);
        }
    }

    public double getBalance() {return balance;}
    public ulong getNumeroT() {return numeroTarjeta;}
    public string getBalance() {return clave;}
    //fin clase tarjeta
}

class Empleado
{
    private ulong codigoEmpleado;
    private string nombreCompleto;
    private double salarioSemanal;
    private Tarjeta t; // para que un objeto Empleado pueda usar un objeto tarjeta.

    public Empleado(ulong ce, string nc, double sa){
        codigoEmpleado =ce;
        nombreCompleto = nc;
        salarioSemanal = sa;
    }

    public void setTarjeta(ulong num, double ba){
        t = new Tarjeta(num, ba);
    }
    public void setMiClave(string clave){
        t.setClave(clave);
    }

    public ulong getCodigoEmpleado(){return codigoEmpleado;}
    public string getNombreCompleto(){return nombreCompleto;}
    public double getSalarioSemanal(){return salarioSemanal;}

    public void verMiBalance()
    {
        Console.WriteLine("Su balance actual es de: " + t.getBalance() + " RD$");
    }
    public void hacerDeposito(double dep)
    {
        t.depositar(dep);
    }

    public void hacerRetiro(double ret)
    {
        t.retirar(ret);
        Console.WriteLine("Usted acaba de retirar"+ret);
    }

    public void verNumeroT(){
        Console.WriteLine("Su numero de tarjeta es: {0}", t.getNumeroT());
    }

    public void verMiClave(){
        Console.WriteLine("Su clave actual es: "+t.getClave() + "NO LA PIERDA NI LA COMPARTA...");
    }


}

//tester-class

class Prueba{
    public static void Main(){
        Empleado e1 = new Empleado(1234567, "Luisito Ford", 9112.33);
        e1.setTarjeta(89873452, 112.33);
        e1.verMiBalance();
        e1.hacerRetiro(500);
        e1.hacerDeposito(2000);
        e1.verNumeroT();
        e1.verMiClave();
        e1.hacerRetiro(454.87);
        e1.verMiBalance();
    }
}