using Task3;
Dog dog1 = new Dog();
string dogName = Console.ReadLine();
dog1.SetName(dogName);
Console.WriteLine("Name od the dog : " + dog1.GetName());
dog1.Eat();


