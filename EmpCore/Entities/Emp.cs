using System;
using System.ComponentModel.DataAnnotations;
namespace EmpCore.Entities
{
    public class Emp
    {
        [Required(ErrorMessage = "Identification Number is Required!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is Required!")]
        public DateTime JoinDate { get; set; }

        public string Designation { get; set; }

        public string Address { get; set; }

        
    }
}
