using System;

namespace AssigmentNumbah2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreAr, apellidoAr, direccionAr, nitAr;
            double saldoAr;
            Console.Write("Bienvenido, identifiquese con su nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("\nApellido: ");
            apellidoAr = Console.ReadLine();
            Console.Write("\nDireccion de facturacion: ");
            direccionAr = Console.ReadLine();
            Console.Write("\nDigite su NIT: ");
            nitAr = Console.ReadLine();
            saldoAr = 0; //decidi inicializar saldo en 0 simplemente porque es una cuenta nueva, pero segun las condiciones del ejercicio se puede iniciar con cualquier valor y adaptar el programa

            // Como esta clase tiene un constructor con parametros, nos es necesario darle los argumentos desde la clase Main() para poder crear un objeto de la
            //clase CuentaBancaria, asi que en main pedimos los datos al usuario(A eso me refiero con argumentos), y los ingresamos como parametros para crear el objeto


            CuentaBancaria cuentaNueva = new CuentaBancaria(nombreAr, apellidoAr, direccionAr, nitAr, saldoAr);







        }

    }

    // Clase
    public class CuentaBancaria
    {
        // Campos
        private string nombre, apellido, direccion, nit; // se crean los campos de la clase (Por la naturaleza del ejercicio, estos datos son Private, ya eque es una cuenta bancaria)
        private double saldo;



        // Constructor de la clase cuenta bancaria

        //Constructor: en terminos simples, seria crear un una especie de metodo (no es un metodo en si, pero es similar visualmente) del nombre de la clase
        // de esta forma cuando se instancie la clase cuenta bancaria, lo primero que hara sera ejecutar el bloque de codigo en el constructor.

        //Como mencione antes, en estructura es PARECIDO pero no igual a un metodo
        //                                         ex(      Public             int              suma(int num));           
        //La estructura de un metodo seria algo como: Modificador_de_acceso Tipo_que_devuelve Identificador/nombre (parametros)
        // un constructor unicamente tiene el modificador de acceso, identificador y parametros, no debe devolver un tipo de dato
        public CuentaBancaria(string nombrePa, string apellidoPa, string direccionPa, string nitPa, double saldoPa)
        {      // inicializamos los campos con los valores que reciban los parametros en el constructor de la clase CuentaBancara
            nombre = nombrePa;
            apellido = apellidoPa;
            direccion = direccionPa;
            nit = nitPa;
            saldo = saldoPa;
            int continua; // esta variable se usa mas tarde para ejecucion de un menu, el usuario ingresa un dato y segun el dato que introduzca sigue ejecutandose el programa
            bool cont = true; //se define una variable boolena para ejecutar el do-while que ejecuta el menu
            Console.WriteLine("----------PORTAL TRANSACCIONAL CESARBANK----------");
            Console.WriteLine("Hola! Bienvenido señor(a) {0} {1}", nombre, apellido);
            //Menu
            do
            {

                Console.WriteLine("Escoja la transaccion que desea realizar \n1.Deposito \n2.Retiro \n3.Consultar saldo \n4.Consultar informacion de cuenta");
                // los "\n" representan saltos de linea, para que se vea mas organizado 
                int option = Convert.ToInt32(Console.ReadLine()); // la variable con nombre option la uso para pedir un dato, y segun el dato (en este caso un numero) el usuario elige el tipo de transaccion que desea hacer

                switch (option) // el switch entre parentesis tiene una "variable de coindicencia" o sea, si el dato que ingresemos coincide con alguno de los casos ejecutara el bloque de codigo correspondiente
                {
                    case 1: // ex. Aqui el usuario ingreso en Option el numero "1", entonces se ejecuta el caso que hace coincidencia con ese valor  "case 1:"
                        Deposito();
                        break; // el break se utiliza en cada case para indicar que ahi termina la ejecucion de ese case y continuar con el resto del codigo
                    case 2:
                        Retiro();
                        break;
                    case 3:
                        consultaSaldo();
                        break;
                    case 4:
                        ToString();
                        break;
                }
                Console.WriteLine("Desea realizar otra transaccion? \n1: Si \nCualquier numero: No "); // cuando termina la ejecucion del switch, se le pide al usuario ingresar un dato numerico, 1 para seguir ejecutando o acabar el programa con cualquier otro numero
                continua = Convert.ToInt32(Console.ReadLine());
                cont = continua == 1 ? true : false; // el operador ternario evalua si el dato que ingreso el usuario es igual a 1, en caso de que si, el valor de cont sera true (recordemos que es un bool lol) sino, entonces se le asigna false
            } while (cont);
        }
        // Metodos
        public double Deposito()
        {
            Console.Write("Monto a depositar: ");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            saldo += valorDeposito; // el operador compuesto += almacena en saldo su valor agregandole el valor del deposito
            Console.WriteLine("Transaccion realizada \nSu nuevo saldo es de {0}", saldo);
            return saldo + valorDeposito;
        }
        public double Retiro()
        {
            Console.Write("Monto a retirar: ");
            double valorRetiro = Convert.ToDouble(Console.ReadLine());
            if (valorRetiro > saldo)
            {
                Console.WriteLine("El valor del retiro no puede ser mayor a su saldo actual \nPor favor intente denuevo");
                return saldo;
            }
            else
            {
                if (valorRetiro >= 2000000) // se hace una condicion que implica que si la transaccion es de un valor mayor a 2 millones, se solicita un codigo de seguridad
                {
                    OTP(); // se ejecuta el metodo OTP para el codigo de seguridad cuando se cumple esta condicion (btw OTP es One Time Passcode)
                    saldo -= valorRetiro; // el operador compuesto -= guarda en saldo el valor restandole el valor del retiro
                    Console.WriteLine("Transaccion realidada \nSu nuevo saldo es de: {0}", saldo);
                    return saldo - valorRetiro;

                }
                else
                {
                    saldo -= valorRetiro;
                    Console.WriteLine("Transaccion realidada \nSu nuevo saldo es de: {0}", saldo);
                    return saldo - valorRetiro;
                }
            }
        }
        public void consultaSaldo()
        {
            Console.WriteLine($"Su saldo actual: {saldo}");
        }
        public override string ToString() //override se usa para crear una sobrecarga u override(XD) de un metodo. la estructura es la misma que un metodo cualquiera, pero ponemos override antes del tipo que devuelve el metodo
        {
            Console.WriteLine("Informacion de la cuenta");
            Console.WriteLine($"Nombre: {nombre} \nApellido: {apellido} \nDireccion: {direccion} \nNIT: {nit}");
            return nombre;
            //esta sobrecarga del metodo ToString() simplemente imprime algunos datos que se hayan asignado al objeto de la clase
        }
        public void OTP()
        {
            int code, otp;
            do
            {
                Random passcode = new Random();   //aqui instanciamos una clase llamada Random, y creamos un objeto passcode de esa clase
                Console.WriteLine("Va a obetenr un codigo de seguridad para esta transaccion");
                code = passcode.Next(100000, 999999); //eso nos permite usar un metodo de la clase Random llamado Next(), con ese metodo podemos generar un numero aleatorio
                                                      // dato: El Next() tiene 3 formas de uso, o 2 sobrecargas. Next() para generar un numero aleatorio entero no negativo. Next(num) para generar un numero aleatorio menor al numero entre parentesis
                                                      // y Next(num1,num2) para generar un numero aleatorio entre el rango establecido entre num1 y num2 (Estos pueden ser numeros enteros negativos)
                Console.WriteLine(code); // imprimimos un numero aleatorio que se usa como codigo de seguridad
                Console.Write("Ingrese el codigo de seguridad: ");
                otp = Convert.ToInt32(Console.ReadLine());//se le solicita ingresar el codigo de seguridad al usuario, si este no coincide vuelve a generar un codigo y solicitarlo

                if (otp != code) // el operador compuesto != significa "es diferente a" se leeria como "Otp es diferente a lo que esta en code"
                {
                    Console.WriteLine("Los datos no coinciden con su codigo de seguridad. \nIntentelo nuevamente");
                }

            } while (otp != code);

        }

    }
}
