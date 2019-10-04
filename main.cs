using System;
//cultura, sociabilidade, sustentabilidade,
//fazer o posto

class MainClass {
  public static void Main (string[] args) {
    double valorgas=4.75 , valoral=3.55, valor=0;
    int pagamento=0, combustivel=0, litros=0;


    Console.WriteLine ("");
    Console.WriteLine ("");
    Console.WriteLine ("VALOR DA GASOLINA = R$ 4.75");
    Console.WriteLine ("VALOR DO ÁLCOOL = R$ 3.55");
    Console.WriteLine ("");
    Console.WriteLine ("");

    Console.WriteLine ("Qual Combustível deseja abastecer?");
    Console.WriteLine ("Digite:");
    Console.WriteLine ("1 - Gasolina");
    Console.WriteLine ("2 - Álcool");
    Console.WriteLine ("");
    combustivel = int.Parse(Console.ReadLine());

    if (combustivel==1){
      valor=valorgas;
    }
    else{
      valor=valoral;
    }

    Console.WriteLine ("");

    Console.WriteLine ("Qual a forma de pagamento?");
    Console.WriteLine ("Digite:");
    Console.WriteLine ("1 - pagamento em Dinheiro");
    Console.WriteLine ("2 - pagamento com Cartao de Crédito");
    Console.WriteLine ("");
    pagamento=int.Parse(Console.ReadLine());

    if (pagamento==1){
      valor = valor - (15.0/100)*valor;
    }

    Console.WriteLine ("");
    
    Console.WriteLine ("Quantos litros deseja abastece?");
    litros=int.Parse(Console.ReadLine());
    Console.WriteLine ("");

    


    if (litros>0){      
      for(int i=0; i<litros; i++){
        for(int j=0; j<10000000; j++){
        }
        Console.WriteLine ("{0} Litros", i+1);        
      }
    }

    Console.WriteLine ("");
    Console.WriteLine ("Valor a pagar R$ {0}", (valor*litros));

  }
}