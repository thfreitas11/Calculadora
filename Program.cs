using System;
using Calculadora.Interfaces;
using Calculadora.Models;

ICalculadora calc = new Calculo();
Console.WriteLine("Multiplicação: " + calc.Multiplicar(3, 9));
Console.WriteLine("Divisão: " + calc.Dividir(10, 2));
Console.WriteLine("Subtração: " + calc.Subtrair(50, 20));
Console.WriteLine("Adição: " + calc.Somar(9, 1));
