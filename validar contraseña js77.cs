using System;

public class HelloWordId {
    public static void Main(string[] args) {

        const string passCorrecta = "soy777";
        string clave;
        int intentosfallidos = 0;

        do
        {
            Console.Write("Ingrese la contraseña");
            clave = Console.ReadLine();
            if (clave != passCorrecta)
            {
                intentosfallidos++;
                Console.WriteLine("Contraseña Incorrecta. Intentalo de nuevo.");
            }
        } while (clave != passCorrecta);
        Console.WriteLine($"\n acesso concedido.");
        Console.WriteLine($"Intentos Fallidos: {intentosfallidos}");



    }
}