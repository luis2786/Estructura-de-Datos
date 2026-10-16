using System;
using System.IO;
class Program
{
 static void Main()
 {
 string ruta = "universitarios.csv";
if (File.Exists(ruta))
{
 string[] lineas = File.ReadAllLines(ruta);
 foreach (string linea in lineas)
 {
 string[] campos = linea.Split(',');
 Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[2]}");
 }
}
using (StreamWriter sw = new StreamWriter("universitarios.csv", append: true))
{
 sw.WriteLine("juan,30,85");

}
 }
}
