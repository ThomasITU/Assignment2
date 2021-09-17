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
            var student = new Student(12345, "My", "Jensen", "Active", startDate, endDate, graduationDate);
            
            //Act
            
            
            //Assert
            Assert.Equal("id: 12345, name: My Jensen, status: Active, start date: 30/8/2020, end date: 17/6/2023, graduation date: 30/6/2023", student.toString());
        }
    }
}
