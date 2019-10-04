using System;
//cultura, sociabilidade, sustentabilidade,
//fazer o posto

class MainClass {
  public static void Main (string[] args) {
    double valor;

    Console.WriteLine ("Quantos litros deseja abastece?");
    valor=Double.Parse(Console.ReadLine());

    if (valor>0){      
      for(int i=0; i<valor; i++){
        for(int j=0; j<10000000; j++){
        }
      Console.WriteLine ("{0} Litros", i );
      }
  }
}