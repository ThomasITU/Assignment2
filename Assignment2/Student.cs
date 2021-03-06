using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Assignment2
{
    public class Student
    {
        private Status _status;

        public int Id{get;init;}
        public string GivenName{get; set;}
        public string SurName{get; set;}
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}
        
        // unnused should be removed?
        public Status Status
        {
            get => _status;
            private set => _status = EvalStatus(); // Doesn't work :-(
        }


        public string ToString()
        {
            _status = EvalStatus(); 
            return $"id: {Id}, name: {GivenName} {SurName}, status: {_status}, start date: {StartDate.ToString("dd/MM/yyyy")}, end date: {EndDate.ToString("dd/MM/yyyy")}, graduation date: {GraduationDate.ToString("dd/MM/yyyy")}";
        }

        private Status EvalStatus() 
        {
            var now = DateTime.Now;
            
            if (now.Date == StartDate.Date)
            {
                return Status.New;
            }
            else if (GraduationDate.Date <= now.Date)
            {
                return Status.Graduated;
            }
            else if (EndDate.Date < now.Date && GraduationDate.Date > now.Date)
            {
                return Status.Dropout;
            }
            else
            {
                return Status.Active;
            }

        }
    }
    public enum Status{
        New,
        Active,
        Dropout,
        Graduated
    }
    
    public record ImmutableStudent
    {
        private Status _status;
        public ImmutableStudent(int id, string name, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate) 
            => (Id, Name, SurName, StartDate, EndDate, GraduationDate) = (id, name, surName, startDate, endDate, graduationDate);

        public int Id { get; init; }
        public string Name { get; init; }
        public string SurName { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }

        public override string ToString()
        {
            _status = EvalStatus();
            return $"id: {Id}, name: {Name} {SurName}, status: {_status}, {StartDate.ToString("dd/MM/yyyy")}, end date: {EndDate.ToString("dd/MM/yyyy")}, graduation date: {GraduationDate.ToString("dd/MM/yyyy")}";
        }
        
        private Status EvalStatus() 
        {
            var now = DateTime.Now;
            
            if (now.Date == StartDate.Date)
            {
                return Status.New;
            }
            else if (GraduationDate.Date <= now.Date)
            {
                return Status.Graduated;
            }
            else if (EndDate.Date < now.Date && GraduationDate.Date > now.Date)
            {
                return Status.Dropout;
            }
            else
            {
                return Status.Active;
            }

        }
    }

    
}
