namespace primerosPasitos
{
    class Program
    {
        static void Main(string[] args)

        {
            int numeroIngresado;
            System.Console.Write("Ingrese un number: ");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("El número ingresado es: " + numeroIngresado);
        }
    }
}
