using System;
using System.IO;
class Program
{
 static void Main()
 {
 string ruta = "universitarios.csv";
 using (StreamWriter sw = new StreamWriter(ruta))
 {
 sw.WriteLine("Nombre,Edad,Nota,Semestre,Programa");
 sw.WriteLine("juan,17,75,segundo,ingenieria informatica");
 sw.WriteLine("natalia,22,90,tercero,ingenieria industrial");
 sw.WriteLine("lucas,30,78,segundo,ingenieria informatica");
 }
 Console.WriteLine("Archivo creado exitosamente.");
 }
}
