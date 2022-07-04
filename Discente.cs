using System;

public class Discente{
  public Int32 Matricula{get; set;}
  public String Nome{get; set;}
  public Byte Idade {get; set;}
  public Discente(){
  }
  public Discente(Int32 matricula, string nome, byte idade){
    Matricula = matricula;
    Nome = nome;
    Idade = idade;
  }
  public override string ToString(){
    return Matricula + ". " + Nome + "(" + Idade + "anos)";
  }
}