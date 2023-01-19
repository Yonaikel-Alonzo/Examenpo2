class Comercial:Empleado,Iplus
{
    public double comision {get;set;}
     public Comercial(string Nombre,int Edad, double Salario,double comision):base (Nombre, Edad, Salario)
    {
        this.comision=comision;
    }
     public void toString()
    {
        Console.WriteLine("----------------Datos de los empleados:----------------");
        Console.WriteLine();
        Console.WriteLine("Cargo :Empleados Comercial");
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Edad: "+Edad);
        Console.WriteLine("Salario: "+Salario);  
        Console.WriteLine("Comision: "+comision);  
        Console.WriteLine();    
    }
    public  void Calcular_Iplus()
    {
         double salarioT=0;
        if(Edad>30 && comision>200)
        {
            salarioT=Salario+comision+PLUS;
            Console.WriteLine("--Aplico al PLUS--");
            Console.WriteLine("El emplead@ comercial "+Nombre+" tendra un salario total de: $ "+salarioT);
            Console.WriteLine();
           
        }
            else
            {
                Console.WriteLine("--No aplico al PLUS--");          
                Console.WriteLine("El emplead@ comercial "+Nombre+ " tendra un salario total de: $ "+Salario);
                Console.WriteLine();
            }
    }
}