class Program {
    static double fazerMedia(double n1, double n2, double n3, double n4){
    double media = (n1 + n2 + n3 + n4) / 4;
    return media;
  }

  static void operacao(double media){
    if (media > 5){
      Console.WriteLine("Você foi aprovado");
    } else {
      Console.WriteLine("Você foi reprovado");
    }
  }
  public static void Main (string[] args) {
    string arquivo = @"aprovacao.txt";
    try {
      using (FileStream fs = File.Create(arquivo)) 
      {
        string nome;
        double n1, n2, n3, n4, media;

        Console.WriteLine("Insira seu nome: ");
        nome = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Insira sua primeira nota: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira sua segunda nota: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira sua terceira nota: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira sua quarta nota: ");
        n4 = Convert.ToInt32(Console.ReadLine());

        media = fazerMedia(n1, n2, n3, n4);
        operacao(media);
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.ToString());
    }
  }
}