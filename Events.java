interface Listener extends EventListener {
    void notify(String message);
}

public class Counter {
	private Listener listener;

	public void addListener(Listener listener) {
		this.listener = listener;
	}

	public void RaiseFirstEvent() {
		if(this.listener != null) {
			this.listener.notify("Event!");
		}
	} 
}

public class Program {
    static void Main()
    {
        var counter = new Counter();

        counter.addListener(new Listener() {
    		@Override
            public void notify(String message) {
                System.out.println(message);
            }
        });
    }
}