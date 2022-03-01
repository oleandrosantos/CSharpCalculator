using System;
using System.Collections.Generic;
using CalculadoraClasse;
using Xunit;

namespace CalculadoraTest;

public class CalculadoraTeste
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Testando_Se_A_Calculadora_Esta_Somando(List<double> numeros)
    {
        var resultadoEsperado = numeros[0] + numeros[1];

        Assert.Equal(resultadoEsperado, Calculadora.somarNumeros(numeros));
    }
    
    [Theory]
    [MemberData(nameof(Data))]
    public void Testando_Se_A_Calculadora_Esta_Subtraindo(List<double> numeros)
    {
        var resultadoEsperado = numeros[0] - numeros[1];
        
        
        Assert.Equal(resultadoEsperado, Calculadora.subtrairNumeros(numeros));
    }
    
    [Theory]
    [MemberData(nameof(Data))]
    public void Testando_Se_A_Calculadora_Esta_Multiplicando(List<double> numeros)
    {
        var resultadoEsperado = numeros[0] * numeros[1];
        
        
        Assert.Equal(resultadoEsperado, Calculadora.multiplicarNumeros(numeros));
    }
    
    [Theory]
    [MemberData(nameof(Data))]
    public void Testando_Se_A_Calculadora_Esta_Dividindo(List<double> numeros)
    {
        var resultadoEsperado = numeros[0] / numeros[1];
        
        
        Assert.Equal(resultadoEsperado, Calculadora.dividirNumeros(numeros));
    }
    
    private static List<double> GeradorDeNumeros()
    {
        var lista = new List<double>();
        var rand = new Random();

        for (int indice = 0; indice < 2; indice++)
        {
            lista.Add(rand.NextDouble());           
        }

        return lista;
    }
    
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { GeradorDeNumeros() },
            new object[] { GeradorDeNumeros() },
            new object[] { GeradorDeNumeros() },
        };
}