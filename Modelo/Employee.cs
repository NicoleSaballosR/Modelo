using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Employee
    {
        private int _idNumber;
        private string _FirstName;
        private string _LastName;

        //propiedades publicas 
        
        [Display(Name ="Name", Description = "First Name + Last Name ")]
        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
         ErrorMessage = "Numbers and special characters are not allowed in the name ")]
        public string FirstName
        {
            get { return _FirstName; }
            set {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "FirstName" });

                _FirstName = value; }
        }


        [Display(Name = "Name", Description = "First Name + Last Name ")]
        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
        ErrorMessage = "Numbers and special characters are not allowed in the name ")]
        [StringLength(8, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 8 characters long")]
        public string LastName
        {
            get { return _LastName; }
            set {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "LastName" });
                _LastName = value; }
        }



        [Display(Name = "IDNumber", Description = "Enter an integer between 0 and 99999")]
        [Range(0, 99999)]
        public int IdNumber
        {
            get { return _idNumber; }
            set {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "IDNumber" });
               
                    }
        }
    }
}
