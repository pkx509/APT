using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace GFCA.Domain.Entities.Organizations
{
    public class Employee : Party
    {

        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public override string Name { get; set; }
        
        public override int CountChild => 0;

        public override decimal Cost => Salary;
        public decimal Salary { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }


        public Employee()
        {

        }
        private Employee(int employeeId, string prefix, string firstName, string lastName, string email)
        {
            this.Id = employeeId;
            this.Prefix = prefix;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Name = $"{prefix} {firstName} {lastName}";
            this.Email = email;
        }

        public static Employee CreateInstant(int employeeId, string employeeName, string email)
        {
            return new Employee(employeeId, "", employeeName, "", email);
        }
        

        public override void Add(Party item) => throw new NotImplementedException();
        public override void Remove(Party item) => throw new NotImplementedException();
    }

    public static class ConvertToDateTimeExtensions
    {
        public static DateTime? ToDateTime(this string strDateTime)
        {
            string format = "yyyy-MM-dd HH:mm";
            DateTime result;

            if (DateTime.TryParseExact(strDateTime, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                return result;

            return null;

        }
    }
}
