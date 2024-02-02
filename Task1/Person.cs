namespace Task1;

public class Person
{
    public string Name { get; set; }
    public Person(string _name)
    {
        Name = _name;
    }
    public override string ToString()
    {
        return Name;
    }
    
}
