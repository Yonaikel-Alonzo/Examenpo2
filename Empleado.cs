class Empleado
{
    public string Nombre {get;set;}
    public int Edad {get;set;}
    public double Salario {get;set;}
    public int PLUS=300;
    public Empleado ( string Nombre , int Edad, double Salario)
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Salario = Salario;
    }
   
}
