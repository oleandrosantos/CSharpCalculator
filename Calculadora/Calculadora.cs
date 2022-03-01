using System;
using System.Collections;
using System.Globalization;

namespace CalculadoraClasse
{
  public static class Calculadora
  {
    public static double somarNumeros(List<double> numero)
    {
      return (numero[0] + numero[1]);
    }

    public static double subtrairNumeros(List<double> numero)
    {
      return (numero[0] - numero[1]);
    }

    public static double dividirNumeros(List<double> numero)
    {
      return (numero[0] / numero[1]);
    }

    public static double multiplicarNumeros(List<double> numero)
    {
      return numero[0] * numero[1];
    }

    public static void menuCalculadora()
    {
      bool repetirMenu = true;
      ushort? comandos = null;

      while (repetirMenu)
      {
        Console.Clear();
        Console.WriteLine("Bem vindo a calculadora!!");
        Console.WriteLine("Abaixo segue a lista de comandos, digite conforme o numero");
        Console.WriteLine("1 => Somar");
        Console.WriteLine("2 => Subtrair");
        Console.WriteLine("3 => Dividir");
        Console.WriteLine("4 => Multiplicar");
        Console.WriteLine("0 => Sair");
        Console.Write("O que deseja? ");

        var EntradaDeDados = Console.ReadLine();
        try
        {
          comandos = ushort.Parse(EntradaDeDados);
          if (comandos > 4)
          {
            throw new Exception("comando invalido, porfavor, digite um comando valido!");
          }
          CalcularEExibir(comandos);
          comandos = 0;
        }
        catch (Exception e)
        {
          Console.WriteLine(e);
        }

      }
    }

    public static void CalcularEExibir(ushort? comando)
    {
      double resultado = 0;
      if (comando < 1)
      {
        Console.WriteLine("Obrigado! aperte Enter para encerrar!");
        Console.ReadLine();
        System.Environment.Exit(10);
      }
      List<double> numeros = capturarNumeros();
      switch (comando)
      {
        case 1: resultado = somarNumeros(numeros); break;
        case 2: resultado = subtrairNumeros(numeros); break;
        case 3: resultado = dividirNumeros(numeros); break;
        case 4: resultado = multiplicarNumeros(numeros); break;
      }

      string specifier = "G";
      Console.WriteLine($"O resultado da operacao é " + resultado.ToString(specifier, CultureInfo.InvariantCulture));
      Console.ReadLine();
    }

    public static List<double> capturarNumeros()
    {
      List<double> listaDeNumeros = new List<double>();
      double numero;
      bool temosDoisNumeros = false;

      while (!temosDoisNumeros)
      {
        string position = "primeiro";

        if (listaDeNumeros.Count > 0)
          position = "segundo";


        try
        {
          Console.Write($"Digite o {position} numero da equação: ");
          numero = double.Parse(Console.ReadLine());
          listaDeNumeros.Add(numero);
        }
        catch
        {
          Console.WriteLine("O Numero digitado é invalido, digite novamente outro numero!");
          Thread.Sleep(300);
        }

        if (listaDeNumeros.Count > 1)
          temosDoisNumeros = true;

      }

      return listaDeNumeros;
    }
  }
}