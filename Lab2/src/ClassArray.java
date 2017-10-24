
public class ClassArray <T extends ITransport> {
	private T[] places;
	private T defaultValue;

	public ClassArray(int size, T defVal)
	{
		defaultValue = defVal;
		places = (T[]) new ITransport[size];
		for(int i = 0; i < places.length; i++)
		{
			places[i] = defaultValue;
		}
	}
	
	public static <T extends ITransport> int plus(ClassArray<T> p, T plane)
	{
		for(int i = 0; i < p.places.length; i++)
		{
			if (p.checkFree(i))
			{
				p.places[i] = plane;
				return i;
			}
		}
		return -1;
	}

	public static <T extends ITransport> T minus(ClassArray<T> p, int index)
	{
		if (!p.checkFree(index))
		{
			T plane = p.places[index];
			p.places[index] = p.defaultValue;
			return plane;
		}
		return p.defaultValue;
	}

	public boolean checkFree(int index)
	{
		if (index < 0 || index > places.length) return false;
		if (places[index] == null) return true;
		if (places[index].equals(defaultValue)) return true;

		return false;
	}
	
	public T getObject(int index)
	{
		if (index > -1 && index < places.length) return places[index];

		return defaultValue;
	}
	
}
