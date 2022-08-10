namespace condicionales
{
    class Program
    {
        static void Main(string[] args)

        {
            int edad;
            bool pass, id;
            string option;
            option = "y";

            while (option == "y")
            {

                System.Console.Write("\nIngrese su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad < 18)
                {
                    System.Console.WriteLine("No puedes farrear, bruh");
                }
                else if (edad >= 100)
                {
                    System.Console.WriteLine("Demasiada edad, estás muerto bro...✨");
                }
                else
                {
                    System.Console.WriteLine("Eres mayor de edad.");
                    System.Console.Write("¿Tiene constraseña?: ");
                    pass = Convert.ToBoolean(Console.ReadLine());
                    if (pass == true)
                    {
                        System.Console.WriteLine("Puede ir.");
                    }
                    else
                    {
                        System.Console.Write("¿Tiene cédula?: ");
                        id = Convert.ToBoolean(Console.ReadLine());
                        if (id == true)
                        {
                            System.Console.WriteLine("Puede ir");
                        }
                        else
                        {
                            System.Console.WriteLine("No puede ir");
                        }
                    }
                }

                for (int i = 0; i == 0;)
                {
                    System.Console.Write("¿Quiere repetir? (y/n): ");
                    option = Console.ReadLine();
                    if (option == "y" || option == "n")
                    {
                        break;
                    }
                }

            }
            for (int j = 1; j <= 10; j++)
            {
                System.Console.WriteLine(j);
            }
        }
    }
}
