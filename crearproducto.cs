using System;
using System.IO;
class Program
{
 static void Main()
 {
 string ruta = "articulos.csv";
 using (StreamWriter sw = new StreamWriter(ruta))
 {
 sw.WriteLine("codigo,producto,valor,");
 sw.WriteLine("1,horno,135000,");
 sw.WriteLine("2,sarten,42000");
 sw.WriteLine("3,freidora,210000");
 }
 string[] lineas = File.ReadAllLines(ruta);
 for (int i = 1; i < lineas.Length; i++)
 {
 string[] celdas = lineas[i].Split(',');
 double valor = double.Parse(celdas[2]);
 if (valor > 100)
 Console.WriteLine($"{celdas[1]} - ${valor}");
 }
 }
}
