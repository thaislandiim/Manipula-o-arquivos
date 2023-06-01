using System;
using System.IO;
using System.Text;

class Program 
{
  public static void Main (string[] args) 
  {
    string path = @"teste.txt";
    try 
    {
      using (FileStream fs = File.Create(path)) //criando o arquivo, fs "file stream"
      {
        for (int n = 0; n <= 100; n++)
        {
          Byte[] dado = new UTF8Encoding(true).GetBytes(Convert.ToString(n) + "\n");
          fs.Write(dado, 0, dado.Length); //add informações do iterador dentro do arquivo
        }
      }
      using (StreamReader sr = File.OpenText(path)) 
      {
        for (int n = 0; n <= 100; n++)
        {
          string valor;
          valor = sr.ReadLine(); 
          if(Int64.Parse(valor) % 2 == 0)
          {
            Console.WriteLine(valor);
          }
        }
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.ToString());
    }
  }
}