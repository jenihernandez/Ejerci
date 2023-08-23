
//INGRESAR POR PANTALLA DOS NUMEROS Y CALCULAS LAS 4 OPERACIONES ARITMETICAS CON DICHOS NUMEROS: IMPRIMIR EN PANATALLA EL
//RESULTADO DE CADA OPERACION



//1ro definir el nombre de mi clase 
public class MiPrimerPrograma
{
    static void Main(string[] args)
    {
        //2do declaracion de mis variables (datos de entrada y salida)
        int num1, num2, suma, resta, multiplicacion, division;

        //3ro pedir los numeros por pantalla (consola)
        Console.Write("ingrese su primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("ingrese segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //4to procesos (calculos)
        suma = num1 + num2;
        resta = num1 - num2;
        multiplicacion = num1 * num2;
        division = num1 / num2;

        //imprimir los resultados (datos de salidas)
        Console.Write("la suma es: " + suma);
        Console.Write("\n");
        Console.Write("la resta es: " + resta);
        Console.Write("\n");
        Console.Write("la multiplicacion es: " + multiplicacion);
        Console.Write("\n");
        Console.Write("la division es: " + division);

    }

}
