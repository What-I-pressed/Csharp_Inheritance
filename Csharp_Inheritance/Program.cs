
Builder builder = new Builder("Bob", 40, "Carpentry");
builder.Info();
builder.Build();
Sailor sailor = new Sailor("Alice", 25, "Sailboat");
sailor.Info();
sailor.Sail();
Pilot pilot = new Pilot("David", 35, "Jet");
pilot.Info();
pilot.Fly();

Passport passport = new Passport("Vova", "Frukt", "SF4124124");
passport.Info();
ForeignPassport foreignPassport = new ForeignPassport("Roma", "Vorona", "987654321", "VX409412", 12);
foreignPassport.Info();

Tiger tiger = new Tiger("Sasha", 50);
Crocodile crocodile = new Crocodile("Vova", 3.5);
Kangaroo kangaroo = new Kangaroo("Illya", 2);
tiger.Sound();
crocodile.Sound();
kangaroo.Sound();

Shape[] shapes = new Shape[4];
shapes[0] = new Rectangle(4, 5);
shapes[1] = new Circle(3);
shapes[2] = new RightTriangle(3, 4);
shapes[3] = new Trapezoid(5, 7, 6);
foreach (Shape shape in shapes)
{
    Console.WriteLine($"Area : {shape.Area()}");
}

class Human
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Human(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Info()
    {
        Console.WriteLine($"Name : {Name}\t Age : {Age}");
    }
}

class Builder : Human
{
    private string education;

    public string Education
    {
        get { return education; }
        set { education = value; }
    }

    public Builder(string name, int age, string education) : base(name, age)
    {
        this.education = education;
    }

    public void Build()
    {
        Console.WriteLine($"{Name} is a builder with construction skill: {education}\n");
    }
}

class Sailor : Human
{
    private string shipType;

    public string ShipType
    {
        get { return shipType; }
        set { shipType = value; }
    }

    public Sailor(string name, int age, string shipType): base(name, age)
    {
        ShipType = shipType;
    }

    public void Sail()
    {
        Console.WriteLine($"{Name} is a sailor on a {ShipType}\n");
    }
}

class Pilot : Human
{
    private string aircraftType;

    public string AircraftType
    {
        get { return aircraftType; }
        set { aircraftType = value; }
    }

    public Pilot(string name, int age, string aircraftType): base(name, age)
    {
        AircraftType = aircraftType;
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} is a pilot flying {AircraftType}\n");
    }
}

class Passport
{
    private string firstName;
    private string lastName;
    private string passportNumber;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string PassportNumber
    {
        get { return passportNumber; }
        set { passportNumber = value; }
    }

    public Passport(string firstName, string lastName, string passportNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        PassportNumber = passportNumber;
    }

    public void Info()
    {
        Console.WriteLine("Passport Information:");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Passport Number: {PassportNumber}\n");
    }
}

class ForeignPassport : Passport
{
    private string foreignPassportNumber;
    private int visas;

    public string ForeignPassportNumber
    {
        get { return foreignPassportNumber; }
        set { foreignPassportNumber = value; }
    }

    public int Visas
    {
        get { return visas; }
        set { visas = value; }
    }

    public ForeignPassport(string firstName, string lastName, string passportNumber, string foreignPassportNumber, int numberOfvisas)
        : base(firstName, lastName, passportNumber)
    {
        ForeignPassportNumber = foreignPassportNumber;
        visas = numberOfvisas;
    }

    public void Info()
    {
        base.Info();
        Console.WriteLine($"Foreign Passport Number: {ForeignPassportNumber}");
        Console.Write($"Number of visas : {visas}\n");
    }
}

class Animal
{
    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual void Sound() { }
}

class Tiger : Animal
{
    private int numberOfStripes;

    public Tiger(string name, int numberOfStripes) : base(name)
    {
        this.numberOfStripes = numberOfStripes;
    }

    public int NumberOfStripes
    {
        get { return numberOfStripes; }
        set { numberOfStripes = value; }
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} roaring\n");
    }
}

class Crocodile : Animal
{
    private double length;

    public Crocodile(string name, double length) : base(name)
    {
        this.length = length;
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} Krkrk\n");
    }
}

class Kangaroo : Animal
{
    private int jumpHeight;

    public Kangaroo(string name, int jumpHeight) : base(name)
    {
        this.jumpHeight = jumpHeight;
    }

    public int JumpHeight
    {
        get { return jumpHeight; }
        set { jumpHeight = value; }
    }

    public override void Sound()
    {
        Console.WriteLine($"{Name} NA\n");
    }
}

public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public override double Area()
    {
        return Length * Width;
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class RightTriangle : Shape
{
    private double baseLength;
    private double height;

    public RightTriangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double BaseLength
    {
        get { return baseLength; }
        set
        { baseLength = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value;  }
    }

    public override double Area()
    {
        return 0.5 * BaseLength * Height;
    }
}

public class Trapezoid : Shape
{
    private double topLength;
    private double bottomLength;
    private double height;

    public Trapezoid(double topLength, double bottomLength, double height)
    {
        this.topLength = topLength;
        this.bottomLength = bottomLength;
        this.height = height;
    }

    public double TopLength
    {
        get { return topLength; }
        set
        {
            topLength = value;
        }
    }

    public double BottomLength
    {
        get { return bottomLength; }
        set
        {
            bottomLength = value;
        }
    }

    public double Height
    {
        get { return height; }
        set
        {
            height = value;
        }
    }

    public override double Area()
    {
        return 0.5 * (TopLength + BottomLength) * Height;
    }
}