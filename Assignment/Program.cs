using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //- Realizar un programa que pida la cantidad de salones, y la cantidad de estudiantes por salon y permita ingresar la nota de cada estudiante.
            //El programa debe calcular el promedio de cada salon, y mostrar cual salon tuvo el promedio mas alto.

            // El codigo implementa: Matrices escalonadas, ciclos for anidados, operadores ternarios
            // Para organizar y asegurar el entendimiento del codigo, se recomienda mostrar titulos cuando el usuario deba ingresar datos

             Console.WriteLine("Ingrese la cantidad de salones"); 
            int cantSalones = Convert.ToInt32(Console.ReadLine());  // pide al usuario la cantidad de salones
            double[] notasSalones = new double [cantSalones]; // inicializamos una matriz unidimensional para almacenar el promedio de cada salon
            double sumNotas=0,promedioNotas; //inicializamos un acumulador de la suma de las notas para hacer el promedio

            double[][] notasPorSalon = new double[cantSalones][];
            // pedir notas
            for(int i = 0; i < cantSalones;i++)//(desde que i es 0;hasta que i es menor a (El valor de la variable cantSalones); incrementa 1 en i)
            {
                Console.WriteLine("Salon {0}",(i+1));// imprime el valor de i sumado 1, porque la matriz se lee contando desde 0, entonces seria el salon "0" pero se le muestra 1 al usuario
                Console.WriteLine("Cuantos estudiantes tiene el salon?");
                int cantEstudiantes = Convert.ToInt32(Console.ReadLine());//se pide el numero de estudiantes, para definir el tamaño de la matriz interna
                notasPorSalon[i] = new double[cantEstudiantes]; // hay que inicializar la matriz interna antes del bucle

                for (int j =0; j < cantEstudiantes; j++)//recorre los elementos de las matrices internas, para recorrer matrices escalonadas se requiere de un bucle que recorra la matriz principal y otro que recorra las escalonadas
                {

                    Console.WriteLine("Ingresar nota para estudiante {0}", (j + 1));
                    notasPorSalon[i][j] = Convert.ToDouble(Console.ReadLine()); 
                    sumNotas += notasPorSalon[i][j]; // se acumulan las notas del salon que se evaluo luego de pedir la nota de cada estudiante

                }
                promedioNotas = cantEstudiantes > 0 ? sumNotas / cantEstudiantes : 0; // se evalua si cantEstudiantes es mayor que 0, si es mayor que 0 se evalua el promedio de notas, sino se devuelve que el promedio es 0 (pues no hay estudiantes xd)
                notasSalones[i] = promedioNotas; // se asigna el valor del promedio del salon a otra matriz que contendra cada promedio
                sumNotas = 0; // se vuelve a inicializar sumNotas en 0 para volver a correr el bucle y acumular las notas del proximo salon
                Console.WriteLine("El promedio del salon fue {0}", promedioNotas); 

            }


            // nota mas alta y mas baja

            double notaMasAlta= notasSalones[0], notaMasBaja = notasSalones[0]; //se inicializan las variables notaMasAlta y notaMasBaja en el primer valor de la matriz

            for (int i = 0; i < notasSalones.Length; i++) // se recorre toda la matriz

            {
                notaMasAlta = notaMasAlta < notasSalones[i] ? notasSalones[i] : notaMasAlta; // al recorrer la matriz, comparamos todos los valores de la misma con notaMasAlta y notaMasBaja
                notaMasBaja = notaMasBaja > notasSalones[i] ? notasSalones[i] : notaMasBaja; // la condicion es, que si el valor que se esta evaluando es mayor/menor(segun el caso) que la variable
                                                                                             // se reemplaza el valor en la variable

           

            }
            Console.WriteLine("La nota promedio por salon mas baja fue {0}", notaMasBaja); // despues de terminar el bucle para definir la nota mas alta y mas baja, imprimimos
            Console.WriteLine("La nota promedio por salon mas alta fue {0}", notaMasAlta);




        }
    }
}
