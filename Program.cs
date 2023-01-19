internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");

        Comercial c1 = new Comercial("Leandro",38,150,250);
        
        Comercial c2 = new Comercial("Henry",20,150,120);
        
        Repartidor r1= new Repartidor("Yonaikel",23,150,"zona 3");
       
        Repartidor r2 = new Repartidor("Solange",30,150,"zona 3");

        List <Empleado> Empleado = new List<Empleado>();
        Empleado.Add(c1);
        Empleado.Add(c2);
        Empleado.Add(r1);
        Empleado.Add(r2);
        foreach (Iplus item in Empleado)
        {
            item.toString();
            item.Calcular_Iplus();
            
        }
  
        }
    }
