class Repartidor:Empleado,Iplus
{
    string zona {get;set;}
    public Repartidor(string Nombre,int Edad, double Salario, string zona ):base (Nombre, Edad, Salario)
    {
      this.zona = zona;
    }

    public void toString()
    {

        Console.WriteLine("----------------Datos de los empleados:----------------");
        Console.WriteLine();
        Console.WriteLine("Cargo : Emplead@s Repartidor");
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Edad: "+Edad);
        Console.WriteLine("Salario: "+Salario);    
        Console.WriteLine("Zona: "+zona);
        Console.WriteLine();    
    }

    public void Calcular_Iplus()
    {
         double salarioT=0;
        if(Edad<25 && zona == "zona 3")
        {
            salarioT=Salario+PLUS;
            Console.WriteLine("--Aplico al PLUS--");
            Console.WriteLine("El emplead@ repartidor "+Nombre+  " tendra un salario total de: $"+ salarioT);
            Console.WriteLine("tiene que ir a la zona:"+zona);
            Console.WriteLine();
          
        }
        else
        {
            Console.WriteLine("--No plico al PLUS--");
            Console.WriteLine("El emplead@ repartidor "+Nombre+" tendra un salario total de: $"+Salario);
            Console.WriteLine("tiene que ir a la zona: "+zona);
            Console.WriteLine();
          
        }
    }
}