using System;

// 1- Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
//deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
//caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
//será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.

class MainClass {
  public static void Main (string[] args) {

    int num1, num2;
    char operacao;
    float result;
    
    Console.WriteLine ("Informe o primeiro número:");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Informe o segundo número:");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o tipo de operação: ");
    operacao = char.Parse (Console.ReadLine());
    switch (operacao){
      case '+':
        result = num1 + num2;
      break;
      case '-':
        result = num1 - num2;
      break;
      case '*':
        result = num1 * num2;
      break;
      case '/':
        result = num1 / num2;
      break;
    }
    Console.WriteLine("Resultado: {0}", result);
    //erro de variável não declarada? Tratar!
  }
}