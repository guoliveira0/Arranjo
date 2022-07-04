using System;

class Program {
  public static void Main (string[] args) {
  Discente[] arr1 = new Discente[3];
  /*Discente d1;
  d1 = new Discente(789, "Ana", 16);
  arr1[0] = d1;*\
    
    
  /*Discente d2 = new Discente();
  d2.Matricula = 34;
  d2.Nome = "Esther Fernandes";
  d2.Idade = 23;*/

  arr1[0] = new Discente(789, "Ana", 16); 
  Console.WriteLine(arr1[0]);
  }
}