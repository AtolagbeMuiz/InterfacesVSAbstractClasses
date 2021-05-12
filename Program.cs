using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Student stu = new Student();
            // stu.printStudentName();
            // stu.doSomething();

            // IStudent muiz = new Student();
            // muiz.printName();

            // IStudent IStud = new Student();
            // IStud.printName();

            //for Abstract examples, create an instance of derived class and point to base class as a reference variable
            // Student student = new StudentA();
            // student.printFullName();
            
            // student.doSomething();

            Dogs dog = new Dogs();
            dog.dogs();

            Cats cat = new Cats();
            cat.cats();
        }
    }

    // public interface IStudent
    // {

    //     //Interfaces and its members are public by default
    //     //Interfaces doesnt have fields
    //     //class must inherit an interface members
    //     //The Signature of the method must be equal to the signature of the interface
    //     //classes allow multiple interface inheritance
    //     //you cannot create an instance of interface
    //     //an interfce reference variable can point to a derivative class objets
        
    //     //void printStudentName();
    //     void printName();
        
    // }

    // public interface IMuiz
    // {
    //     //void doSomething();
    //     void printName();
    // }

    // public class Student : IStudent, IMuiz
    // {
    //     // public void printStudentName()
    //     // {
    //     //     System.Console.WriteLine("This is a Student");
    //     // }

    //     // public void doSomething()
    //     // {
    //     //     System.Console.WriteLine("This is a do something");
    //     // }

    //     void IMuiz.printName()
    //     {
    //         System.Console.WriteLine("hey, from Muiz");
    //     }

    //     void IStudent.printName()
    //     {
    //         System.Console.WriteLine("hey, from student");
    //     }

    // }



}
