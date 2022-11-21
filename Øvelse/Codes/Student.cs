using System;
namespace Øvelse
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateofBird { get; set; }
        public int Age { get; set; }

       

        public int GetAge(DateTime _DateofBird)
        {
            //DateofBird = _DateofBird;
            DateTime today = DateTime.Today;
            var age = today.Year - _DateofBird.Year;
            Age = age;
            //var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            //var b = (_DateofBird.Year * 100 + _DateofBird.Month) * 100 + _DateofBird.Day;

            return age;

        }
    }
}

