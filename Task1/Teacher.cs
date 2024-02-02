namespace Task1;

public class Teacher : Person
{
    public Teacher(string _name) : base(_name)
    {
        Name = _name;
    }


    public void Explain()
    {
        System.Console.WriteLine("The " + Name + " is explaining.");
      
    }
}
