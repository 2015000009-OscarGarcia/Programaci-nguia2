

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos valores numericos: ");
        double num1=Convert.ToDouble(Console.ReadLine());
        double num2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n****MENU PRINCIPAL****");
        Console.WriteLine("1- suma");
        Console.WriteLine("2- resta");
        Console.WriteLine("3- multiplicación");
        Console.WriteLine("4- división");
        Console.WriteLine("5- salir");
        Console.Write("Digite el valor segun sea la Operación: []");
        int opc = Convert.ToInt32(Console.ReadLine());


        string msj = "";
        double result=0;
        switch (opc)
        {
            case 1:
                msj = "\nSUMA\nLa suma es: ";
                result = num1 + num2;
                break;
            case 2:
                msj = "\nRESTA\nLa resta es: ";
                result = num1 - num2;
                break;
            case 3:
                msj = "\nMULTIPLICACIÓN\nLa multiplicación es: ";
                result = num1 * num2;
                break;
            case 4:
                msj = "\nDIVISIÓN\nLa división es: ";
                result = num1 / num2;
                break;
            case 5:
                msj = "Saliendo del sistema";
                break;
            default:
                msj = "Digite una Opción valida!!!";
                break;

        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(msj);
        Console.WriteLine(result);
    }
}