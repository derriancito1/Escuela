namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            Console.WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string titulo)
        {   
            var tam = titulo.Length + 4;
            DibujarLinea(tam);
            Console.WriteLine($"| {titulo} |");
            DibujarLinea(tam);
        }

        public static void Beep (int hz = 2000, int time = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, time);
            }
        }

    }
}