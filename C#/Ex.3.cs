using System;
using System.IO;
using System.Text;

struct funcionarios{
  public string nome;
  public int idade;
  public string cidNasc;

  public funcionarios(string nome, string cidNasc, int idade){
    this.nome = nome;
    this.idade = idade;
    this.cidNasc = cidNasc;
  }
}
class Program {
  public static void Main (string[] args) {
    funcionarios[] dados = new funcionarios[5];

      for(int n = 0; n < 3; n++){
        Console.WriteLine("Insira o nome do funcionario: ");
        dados[n].nome = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Insira a idade do funcionario: ");
        dados[n].idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira a cidade de nascimento do funcionario: ");
        dados[n].cidNasc = Convert.ToString(Console.ReadLine());
      }
    
      try {
        for(int n = 0; n < 3; n++)
        {
          string[] lines = {
                              dados[n].nome + "; " +
                              dados[n].idade + "; " +
                              dados[n].cidNasc
                            };
            using (StreamWriter sw = new StreamWriter("funcionarios.txt", true)){
              foreach (string line in lines) {  
                Console.WriteLine(line);
                sw.WriteLine(line);
              }
            }
        }
      }
      catch(Exception)
      {
        Console.WriteLine();
      }
  }
}