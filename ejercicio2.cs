using System;
using System.IO;
class Program
{
 static void Main()
 {
 string ruta = "generainventario.csv";
 using (StreamWriter sw = new StreamWriter(ruta))
 {
 sw.WriteLine("codigo,producto,valor,cantidad");
 sw.WriteLine("1,horno,135000,10");
 sw.WriteLine("2,sarten,42000,5");
 sw.WriteLine("3,freidora,210000,7");
 sw.WriteLine("4,termo,35000,3");
              
 }
 string[] lineas = File.ReadAllLines(ruta);
 for (int i = 1; i < lineas.Length; i++)
 {
 string[] celdas = lineas[i].Split(',');
 double cantidad = double.Parse(celdas[3]);
 if (cantidad < 10)
 Console.WriteLine($"{celdas[1]} - ${cantidad}");
 }
 }
}
