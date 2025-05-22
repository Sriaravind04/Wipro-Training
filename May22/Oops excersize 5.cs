using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Fee { get; set; }
    }

    interface IEnrollable
    {
        void Enroll(Course course);
    }

    class User : IEnrollable
    {
        public string Name { get; set; }
        private List<Course> enrolledCourses = new List<Course>();
        private double totalFee = 0;

        public void Enroll(Course course)
        {
            enrolledCourses.Add(course);
            totalFee += course.Fee;
            Console.WriteLine($"Enrolled in course: {course.Title}, Fee: {course.Fee}");
        }

        public void Enroll(Course course, string couponCode)
        {
            double discount = couponCode == "DISCOUNT10" ? 0.1 : 0; // 10% discount for valid coupon
            double discountedFee = course.Fee - (course.Fee * discount);

            enrolledCourses.Add(course);
            totalFee += discountedFee;
            Console.WriteLine($"Enrolled in course: {course.Title}, Original Fee: {course.Fee}, Discounted Fee: {discountedFee}");
        }

        public void PrintEnrolledCourses()
        {
            Console.WriteLine("\nEnrolled Courses:");
            foreach (var course in enrolledCourses)
            {
                Console.WriteLine($"- {course.Title} (Fee: {course.Fee})");
            }
            Console.WriteLine($"Total Fee: {totalFee}");
        }
    }

    class Program17
    {
        static void Main()
        {
            User user = new User { Name = "Alice" };

            Course c1 = new Course { Id = 1, Title = "C# Basics", Fee = 200 };
            Course c2 = new Course { Id = 2, Title = "Advanced C#", Fee = 300 };

            user.Enroll(c1);
            user.Enroll(c2, "DISCOUNT10");

            user.PrintEnrolledCourses();
        }
    }

}