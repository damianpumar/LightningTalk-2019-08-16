public class ExplicitOperator
{
    public class Apartment
    {
        public string Name { get; set; }

        public static explicit operator House(Apartment a)
        {
            return new House() { Name = a.Name };
        }
    }

    public class House
    {
        public string Name { get; set; }

        public static explicit operator Apartment(House h)
        {
            return new Apartment() { Name = h.Name };
        }
    }

    public class Program
    {
        static void Main()
        {
            House h = new House();

            h.Name = "Broadway";

            Apartment a = (Apartment)h;

            Console.WriteLine(a.Name);

            //Output

            //Broadway
        }
    }
}


public class Machine
{
    public int Value {get; set;}

    public static implicit operator Widget(Machine m)
    {
        Widget w = new Widget();
        w.Value = m.Value * 2;
        return w;
    }
}

public class Widget
{
    public int Value {get; set;}

    public static implicit operator Machine(Widget w)
    {
        Machine m = new Machine();

        m.Value = w.Value / 2;

        return m;
    }
}

public class Program
{
    static void Main()
    {
        Machine machine = new Machine();
        machine.alue = 5;

        Console.WriteLine(machine.Value);

        // Implicit conversion from machine to widget.
        Widget widget = machine;

        Console.WriteLine(widget.Value);

        // Implicit conversion from widget to machine.
        Machine machine2 = widget;

        Console.WriteLine(machine2.Value);

        //Output
        //5
        //10
        //5
    }
}