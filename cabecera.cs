    internal class Program
    {
        static void ImprimirCabecera(string NombreMateria, int grupo, string nombre_apellido)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("      UNIVERSIDAD DEL CARIBE       ");
            Console.WriteLine($" Asignatura: {NombreMateria}");
            Console.WriteLine($" Grupo: {grupo}");
            Console.WriteLine($"Nombre: {nombre_apellido}");
            Console.WriteLine("===================================");


        }
        public static void Main(string[] args)
        {
            ImprimirCabecera("Fundamentos de Programacion",1,"Luis Galan Barbosa");
        }
    }
}
