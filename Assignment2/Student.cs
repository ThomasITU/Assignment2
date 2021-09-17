using System;

namespace Assignment2
{
    public class Student
    {
        private Status _status;

        public int Id{get;private set;}
        public string GivenName{get; set;}
        public string SurName{get; set;}
        public Status Status{
            get => _status;
            set => evalStatus()
        ;}

        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}


        public string toString(){
            return $"id: {Id}, name: {GivenName} {SurName}, status: {Status}, start date: {StartDate}, end date: {EndDate}, graduation date: {GraduationDate}";
           
        }

        private Status evalStatus(){
            throw new NotImplementedException();
        }
    }

    public enum Status{
        New,
        Active,
        Dropout,
        Graduated
    }
}
