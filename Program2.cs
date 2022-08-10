namespace primerosPasitos
{
    class Program
    {
        static void Main(string[] args)

        {
            int numeroIngresado;
            System.Console.Write("\nIngrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 18)
            {
              System.Console.WriteLine("No puedes farrear, bruh");
            }
            else if (edad > 100)
            {
             System.Console.WriteLine("Demasiada edad, estás muerto bro...✨"); 
            }
            else
            {
             System.Console.WriteLine("Eres mayor de edad."); 
             System.Console.Write("¿Tiene constraseña?: ");
             pass = Convert.ToBool(Console.ReadLine());
            }

            }
        }
    }
}
