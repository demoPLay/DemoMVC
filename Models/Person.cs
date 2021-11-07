using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demomvc.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string  PersonName { get; set; }
        public string  personID { get; set; }
    }
}