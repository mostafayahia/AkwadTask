using System;
using System.ComponentModel.DataAnnotations;

namespace AkwadTask.Models
{
    public class Employee
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int JobID { get; set; }

        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        public string Address { get; set; }

        public string Mobile { get; set; }

        public int Salary { get; set; }

        public int IdNumber { get; set; }
    }
}
