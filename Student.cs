public abstract class Student
{
    //Differences between Interfaces and Abstract classes
    //Abstract class can have implementations while Interfaces cant
    //Interfaces are public by default while abstract classes are not
    //You can Inherit multiple interfaces but you cant inherit multiple classes
    //Interface cannot have fields but abtract classes can

    public int Id;

    public virtual void doSomething()
    {
        System.Console.WriteLine("My Name");
    }

    public abstract void printFullName();

}