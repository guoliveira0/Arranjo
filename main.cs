using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
  List <string> nomes = new List<string>();
  nomes.Add("Luiz Gustavo");
  Boolean contem = nomes.Contains("Luiz Gustavo");
  Console.WriteLine("Luiz Gustavo encontrado: " + contem);
  foreach(string nome in nomes){
    Console.WriteLine(nome);
  }

  }
}