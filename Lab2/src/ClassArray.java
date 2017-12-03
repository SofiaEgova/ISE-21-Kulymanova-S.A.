import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;

public class ClassArray <T extends ITransport> implements Serializable {
	
	private Dictionary<Integer, T> places;
	int maxCount;
	private T defaultValue;

	public ClassArray(int size, T defVal)
	{
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = size;
	}
	
	public static <T extends ITransport> int plus(ClassArray<T> p, T plane) throws AerodromeOverflowException
	{
		if (p.places.size() == p.maxCount) throw new AerodromeOverflowException();
		for(int i = 0; i < p.places.size(); i++)
		{
			if (p.checkFree(i))
			{
				p.places.put(i, plane);
				return i;
			}
		}
		p.places.put(p.places.size(), plane);
		return p.places.size() - 1;
	}

	public static <T extends ITransport> T minus(ClassArray<T> p, int index) throws AerodromeIndexOutOfRangeException
	{
		if (p.places.get(index) != null)
		{
			T plane = p.places.get(index);
			p.places.remove(index);
			return plane;
		}
		throw new AerodromeIndexOutOfRangeException();
	}

	public boolean checkFree(int index)
	{
		if(places.get(index)==null) return true;
		return false;
	}
	
	
	public T getPlane(int ind) {
		if(places.get(ind)!=null) return places.get(ind);
		return defaultValue;
	}
	
	
}
