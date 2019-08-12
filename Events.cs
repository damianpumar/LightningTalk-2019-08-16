public class Counter
{
    public event EventHandler FirstEvent;

    public void RaiseFirstEvent()
    {
        EventHandler handler = FirstEvent;

        handler?.Invoke(this, EventArgs.empty());
    }
}

public class Program
{
    static void Main()
    {
        var counter = new Counter();

        counter.FirstEvent += (object sender, EventArgs e) => {
			Console.WriteLine("Event!.");
        };
    }
}