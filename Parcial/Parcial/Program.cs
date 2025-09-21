using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//.1. contar las vocales de un string (Con Foreach)
//namespace practice
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //contar las vocales de un string
//            Console.WriteLine("Introduzca una palabra");
//            string palabra = Console.ReadLine();
//            string vocales = "aeiouAEIOU";
//            int contador = 0;
//            string VocEnPalabra = "";

//            foreach (char c in palabra)
//            {
//                if (vocales.Contains(c))
//                    contador++;
//            }
//            Console.WriteLine("La palabra introducida tiene esta cantidad de vocales: " + contador);

//            foreach (char c in palabra)
//            {
//                if (vocales.Contains(c))
//                    VocEnPalabra += c;

//            }
//            Console.WriteLine("La palabra introducida tiene estas vocales: " + VocEnPalabra);



//        }


//    }
//}














// Con For (Como pide el ejercicio)
//namespace practice
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //contar las vocales de un string
//            Console.WriteLine("Introduzca una palabra");
//            string palabra = Console.ReadLine();
//            string vocales = "aeiouAEIOU";
//            int contador = 0;
//            string VocEnPalabra = "";

//            for (int i = 0; i <= palabra.Length - 1; i++)
//            {
//                if (vocales.Contains(palabra[i]))
//                {
//                    contador = contador + 1;
//                }
//            }
//            for (int i = 0; i <= palabra.Length - 1; i++)
//            {
//                if (vocales.Contains(palabra[i]))
//                    VocEnPalabra += palabra[i];
//            }
//            Console.WriteLine("La cantidad de vocales es: " + contador);
//            Console.WriteLine("Las vocales en la palabra son: " + VocEnPalabra);

//        }
//    }
//}


//namespace Parcial
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Introduzca un número:");
//            string num = Console.ReadLine();

//            int suma = 0;

//            for (int i = 0; i < num.Length; i++)
//            {
//                if (char.IsDigit(num[i]))
//                {
//                    suma += int.Parse(num[i].ToString());
//                }
//            }

//            Console.WriteLine("La suma de los dígitos es: " + suma);
//        }
//    }
//}


// 4. Devolver el mayor de 3 numeros usando ciclo for (Porque es mas facil)

//namespace practice
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // recibir 3 numeros y determinar el mayor                                        
//            Console.WriteLine("Introduzca 3 numeros para determinar cual es mayor");
//            int[] numeros;
//            numeros = new int[3];
//            numeros[0] = Convert.ToInt32(Console.ReadLine());
//            numeros[1] = Convert.ToInt32(Console.ReadLine());
//            numeros[2] = Convert.ToInt32(Console.ReadLine());

//            int mayor = 0;

//            for (int i = 0; i < numeros.Length; i++)
//            {
//                if (numeros[i] > mayor)
//                    mayor = numeros[i];

//            }
//            Console.WriteLine("El mayor numero es " + mayor);
//        }


//    }
//}

//namespace Parcial
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Introduzca un número:");
//            string num = Console.ReadLine();

//            Program programa = new Program(); // Instancia de la clase
//            int resultado = programa.Sumadigitos(num, 0, 0); // Llamada al método instanciado
//            Console.WriteLine("La suma de los dígitos es: " + resultado);
//        }

//        // Método instanciado que retorna la suma
//        public int Sumadigitos(string num, int i, int suma)
//        {
//            if (i >= num.Length)
//                return suma;

//            if (char.IsDigit(num[i]))
//                suma += int.Parse(num[i].ToString());

//            return Sumadigitos(num, i + 1, suma); // Recursión con acumulación
//        }
//    }
//}


//----------------------------------------- practica ------------------------------------------------


//.1.contar las vocales de un string 
//namespace practice
//namespace practice
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Introduzca una palabra");
//            string palabra = Console.ReadLine();
//            string vocales = "aeiouAEIOU";
//            int contador = 0;
//            string VocEnPalabra = "";

//            for (int i = 0; i <= palabra.Length - 1; i++)
//            {
//                if (vocales.Contains(palabra[i]))
//                {
//                    contador = contador + 1;
//                }
//                if (vocales.Contains(palabra[i]))
//                {
//                    VocEnPalabra += palabra[i];
//                }

//            }
//            Console.WriteLine("La palabra tiene {0} vocales las cuales son: {1} ", contador, VocEnPalabra);
//        }
//    }
//}
















//2.Parrafo de texto contar palabras y devolver la mas larga
namespace Practice
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una cadena con tres palabras separadas por espacios:");
            string input = Console.ReadLine();

            string palabraMasLarga = ObtenerPalabraMasLarga(input);
            Console.WriteLine("La palabra más larga es: " + palabraMasLarga);


            string ObtenerPalabraMasLarga(string texto)
            {
                // Divide el texto por espacios
                string[] palabras = texto.Split(' ');

                if (palabras.Length != 3)
                {
                    string masLarga = palabras[0];

                    foreach (string palabra in palabras)
                    {
                        if (palabra.Length > masLarga.Length)
                        {
                            masLarga = palabra;
                        }
                    }
                    return masLarga;

                }
            }

        }
    }
}









    //3.Sumar los digitos de un numero con un ciclo for
    //

    //namespace Parcial
    //{
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine("Introduzca un número:");
    //            string num = Console.ReadLine();

    //            int suma = 0;

    //            for (int i = 0; i < num.Length; i++)
    //            {
    //                if (char.IsDigit(num[i]))
    //                {
    //                    suma += int.Parse(num[i].ToString());
    //                }
    //            }

    //            Console.WriteLine("La suma de los dígitos es: " + suma);
    //        }
    //    }
    //}



































    //4.Devolver el mayor de 3 numeros usando recursion(como pide el ej)

    //namespace Parcial
    //{
    //    internal class program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine("Ingrese 3 numeros para evaluar cual es mayor");
    //            int[] numeros = new int[3];
    //            numeros[0] = Convert.ToInt32(Console.ReadLine());
    //            numeros[1] = Convert.ToInt32(Console.ReadLine());
    //            numeros[2] = Convert.ToInt32(Console.ReadLine());
    //            int mayor = Mayornum(numeros, 0, 0);
    //            Console.WriteLine("El mayor numero es: " + mayor);




    //        }
    //        public static int Mayornum(int[] numeros, int mayor, int i)
    //        {
    //            if (i >= numeros.Length)
    //                return mayor;
    //            if (numeros[i] > mayor)
    //                mayor = numeros[i];
    //            return Mayornum(numeros, mayor, i + 1);
    //        }
    //    }
    //}











//    //5.Hacer una clase cuenta bancaria con metodos depositar y retirar

//    namespace Parcial
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            CuentaBancaria CM = new CuentaBancaria(50000);
//            Console.WriteLine("Realizar un retiro");
//            CM.Retirar();
//            Console.WriteLine("Realizar un deposito");
//            CM.Depositar();
//            Console.WriteLine("Consulta su saldo:");
//            CM.Consultar();

//        }
//    }
//}

