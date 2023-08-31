// Este programa muestra el uso de ,etodos de extensión 
using Modelo;

int numero = 55;
bool par = numero.EsPar(); //Acá encontramos la extension 

Console.WriteLine("{0} , {1}", numero, par);

//Extension del double 

double valor = 55.18;

Console.WriteLine(valor.Duplica());
