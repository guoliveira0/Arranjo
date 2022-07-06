using System;

class Program {
  public static void Main (string[] args) {
  Discente[] arr1 = new Discente[4];
  /*Discente d1;
  d1 = new Discente(789, "Ana", 16);
  arr1[0] = d1;*\
    
    
  /*Discente d2 = new Discente();
  d2.Matricula = 34;
  d2.Nome = "Esther Fernandes";
  d2.Idade = 23;*/
  arr1[0] = new Discente(90, "Luiz Gustavo", 56);
  arr1[1] = new Discente(45, "Luiz Gustavo", 23);
  arr1[2] = new Discente(89, "Luiz Gustavo", 56);
  arr1[3] = new Discente(546, "Luiz Gustavo", 78);
  /*for(int i = 0; i< arr1.Length; i++){
    Console.WriteLine(arr1[i].Idade);
  }
    Single total = 0f;
    for(int i = 0; i < arr1.Length; i++ ) {
      total += arr1[i].Idade;
    }
    Single media = total / arr1.Length;
    Console.WriteLine("Idade média: " + media);*/
    foreach(Discente n in arr1 ){
      Console.WriteLine(n);
    }
  }
}