// Step 1 create object
using System.ComponentModel.DataAnnotations;
Modelo.Customer cliente = new();
cliente.Name = "ALEXANDER DE LOS SANTOS";

//Step 2
var context = new ValidationContext(cliente, null, null);

//Step 3 ,  mostrar si el nombre cumple con las indicaciones
var result= new List<ValidationResult>();

bool isValid = Validator.TryValidateObject(cliente, context, result, true);
Console.WriteLine(isValid);
foreach (var validationResult in result)
{
    Console.WriteLine(validationResult.ErrorMessage);
}