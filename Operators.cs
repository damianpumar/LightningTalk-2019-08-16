public class Operators 
{
	public static Box operator+ (Box b, Box c) 
	{
		 Box box = new Box();
		 box.length = b.length + c.length;
		 box.breadth = b.breadth + c.breadth;
		 box.height = b.height + c.height;

		 return box;
	}

	public static bool operator == (Box box1, Box box2) 
	{
         return box1.length == box2.length && 
         		box1.height == box2.height && 
         		box1.breadth == box2.breadth;
    }

	public static bool operator !=(Box box1, Box box2) 
	{
		return !(box1 == box2);	
	}
}