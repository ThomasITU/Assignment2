using System;
using Xunit;
using Assignment2;

namespace Assignment2.Tests
{
    public class StudentTests
    {
        [Fact]
        public void ToString_given_an_instance_of_Student_it_prints_a_string_with_the_student_information()
        {
            //Arrange
            DateTime startDate = new DateTime(2020, 8, 30);
            DateTime endDate = new DateTime(2023, 6, 17);
            DateTime graduationDate = new DateTime(2023, 6, 30);
            var student = new Student{Id = 12345, GivenName= "My", SurName = "Jensen", StartDate = startDate, EndDate = endDate, GraduationDate = graduationDate };
            
            //Act
            
            //Assert
            Assert.Equal("id: 12345, name: My Jensen, status: Active, start date: 30/08/2020, end date: 17/06/2023, graduation date: 30/06/2023", student.ToString());
        }

        [Fact]
        public void ToString_given_an_instance_of_ImmutableStudent_prints_the_ImmutableStudent_information()
        {
            //arrange
            DateTime startDate = new DateTime(2020, 8, 30);
            DateTime endDate = new DateTime(2023, 6, 17);
            DateTime graduationDate = new DateTime(2023, 6, 30);
            var Istudent = new ImmutableStudent(123456, "Thomas", "Wolgast", startDate, endDate, graduationDate);
            
            //Act
            
            //Assert
            Assert.Equal(
                "id: 123456, name: Thomas Wolgast, status: Active, 30/08/2020, end date: 17/06/2023, graduation date: 30/06/2023",
                Istudent.ToString());
        }

        [Fact]
        public void given_two_ImmutabelStudents_began_the_same_day_evaluates_to_true()
        {
            //arrange
            DateTime startDate = new DateTime(2020, 8, 30);
            DateTime endDate = new DateTime(2023, 6, 17);
            DateTime graduationDate = new DateTime(2023, 6, 30);
            var IstudentT = new ImmutableStudent(123456, "Thomas", "Wolgast", startDate, endDate, graduationDate);
            
            DateTime startDateM = new DateTime(2020, 8, 30);
            var IstudentM = new ImmutableStudent(12345, "My", "Jensen", startDateM, endDate, graduationDate);
            
            //Act
            
            //Assert
            Assert.True(IstudentM.StartDate.Date == IstudentT.StartDate.Date);
        }
        
        [Fact]
        public void Accessing_ImmutabelStudents_GraduationDate_ToString_is_30_6_2023()
        {
            //arrange
            DateTime startDate = new DateTime(2020, 8, 30);
            DateTime endDate = new DateTime(2023, 6, 17);
            DateTime graduationDate = new DateTime(2023, 6, 30);
            var IstudentT = new ImmutableStudent(123456, "Thomas", "Wolgast", startDate, endDate, graduationDate);
            //Act
            
            //Assert
            Assert.Equal("30/06/2023",IstudentT.GraduationDate.ToString("dd/MM/yyyy"));
        }
        [Fact]
        public void Accessing_ImmutabelStudents_id_is_123456()
        {
            //arrange
            DateTime startDate = new DateTime(2020, 8, 30);
            DateTime endDate = new DateTime(2023, 6, 17);
            DateTime graduationDate = new DateTime(2023, 6, 30);
            var IstudentT = new ImmutableStudent(123456, "Thomas", "Wolgast", startDate, endDate, graduationDate);
            //Act
                
            //Assert
            Assert.Equal(123456,IstudentT.Id);
        }
    }
}
