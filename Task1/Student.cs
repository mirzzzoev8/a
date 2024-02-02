namespace Task1;

public class Student : Person
{
    public Student(string _name) : base(_name)
    {
        Name = _name;
    }


    public void Study()
    {
        System.Console.WriteLine("The " + Name + " is studying.");
    }

}
