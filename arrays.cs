using System.Runtime.Intrinsics.X86;
using System;
using System.Linq;

class Program{
 static void Main(string[] args){
//Ejercicio #1
/*
double[] numeros = new double[4]; 
double suma=0; 
double media; 
Console.Write("Ingrese cuatro numeros por teclado y se le devolvera la media de esos numeros\n");
for(int i=0; i<4; i++){
Console.Write("Introduzca el valor {0}: ", i+1); 
numeros[i] = Convert.ToDouble(Console.ReadLine()); 
suma += numeros[i];
}
media = suma / 4;
Console.Write("\nLos numeros introducidos fueron: "); 
for(int i=0; i<4; i++){
Console.Write(" ({0}) ", numeros[i]); 
}
Console.Write("\nLa suma de todos los numeros es: {0}", suma);
Console.Write("\nY la media aritmetica es: {0}", media); 
*/
//Ejercicio #2
/*
float[] NumReales= new float [5]; 
for (int i = 0; i <= 4; i++)
{
Console.WriteLine("Ingrese un numero real {0}:",i+1);
NumReales[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine("Lo opuesto a lo ingresado");
for (int i = 4; i >= 0; i--){
Console.WriteLine("Resultado {0}:",NumReales[i]);
}
*/
//Ejercicio #3
/*
int [] dias = {0,31,28,31,30,31,30,31,31,30,31,30,31};
string [] meses = {"","Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};

int mes = 0;
Console.Write("Indique el mes: ");
mes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El mes número {0} tiene {1} dias",mes,dias[mes]);
Console.Write("Mes de {0}",meses[mes]);
*/
//Ejercicio #4
/*
float [] Num_mayor = new float [10];
Console.WriteLine("Debe ingresar 10 numeros\n");
for (int i = 0; i < 10; i++)
{
Console.WriteLine("Ingrese un numero {0}:",i+1);
Num_mayor[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine("El numero mayor es {0}",Num_mayor.Max());
Console.Write("Los numeros introducidos fueron: "); 
for(int i=0; i<10; i++){
Console.Write(" ({0}) ", Num_mayor[i]); 
}
*/

// Ejercicio #5
/*
String[] nombres= new string [100]; 
int print_name = 0;
for (int i = 0; i < 100; i++)
{
Console.WriteLine("Ingrese un nombre {0}:",i+1);
nombres[i] = Console.ReadLine();
print_name++;
if (nombres[i] == ""){
print_name=print_name-1;
Console.WriteLine("Pulse Intro para salir");
break;
}
}    
Console.Write("Lista de  nombres: "); 
for(int i=0; i<print_name; i++){
Console.Write(" ({0}) ", nombres[i]); 
}
*/

}
}
