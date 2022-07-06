using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
  List <string> nomes = new List<string>();
  nomes.Add("Luiz Gustavo");
  foreach(string nome in nomes){
    Console.WriteLine(nome);
  }

  }
}