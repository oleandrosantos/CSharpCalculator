using Classes;

namespace CalculadoraPrograma;
class Program
{
    static void Main(string[] args)
    {
        int numero1 = 0;
        int numero2 = 0;


        while(numero1 == 0 || numero2 == 0){
            string? valorDigitado;
            
            if(numero1 == 0){
                Console.Write("Digite um numero: ");
                valorDigitado = Console.ReadLine();
                try{
                    numero1 = Int32.Parse(valorDigitado);
                    valorDigitado = null;
                }catch{
                    Console.WriteLine("Digite um numero inteiro!");
                }
            }else{
                Console.Write("Digite outro numero: ");
                valorDigitado = Console.ReadLine();
                try{
                    numero2 = Int32.Parse(valorDigitado);
                    valorDigitado = null;
                }catch{
                    Console.WriteLine("Digite um numero inteiro!");
                }
            }            


        }

        Console.WriteLine(Calculadora.somarNumeros(numero1, numero2));
    }
}