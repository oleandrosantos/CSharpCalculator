namespace Classes
{


    class Calculadora{

        public static int somarNumeros(int numero1 = 0, int numero2 = 0){
            if(numero1 == null || numero2 == null){
                return 0;
            }else{
                return (numero1 + numero2);
            }
        }

        public static int subtrairNumeros(int numero1, int numero2){
            return (numero1 + numero2);
        }

        public static double dividirNumeros(int numero1, int numero2){
            return((double)numero1/(double)numero2);
        }

        public static int multiplicarNumeros(int numero1, int numero2){
            return numero1*numero2;
        }

    }
}