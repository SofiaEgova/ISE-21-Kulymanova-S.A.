import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;
import java.util.Iterator;

public class ClassArray<T extends ITransport>
		implements Serializable, Iterable<T>, Iterator<T>, Comparable<ClassArray<T>> {

	private Dictionary<Integer, T> places;
	int maxCount;
	private T defaultValue;

	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = size;
	}

	public static <T extends ITransport> int plus(ClassArray<T> p, T plane)
			throws AerodromeOverflowException, AerodromeAlreadyHaveException {
		boolean isFigther = plane instanceof Figther;
		if (p.places.size() == p.maxCount)
			throw new AerodromeOverflowException();
		int index = p.places.size();
		for (int i = 0; i < p.places.size(); i++) {
			if (p.checkFree(i))
				index = i;
			if (plane.getClass() == p.places.get(i).getClass()) {
				if (isFigther) {
					if (((Figther) plane).equals(p.places.get(i))) {
						throw new AerodromeAlreadyHaveException();
					}
				} else if (((War) plane).equals(p.places.get(i))) {
					throw new AerodromeAlreadyHaveException();
				}
			}
		}
		if (index != p.places.size()) {
			p.places.put(index, plane);
			return index;
		}
		p.places.put(p.places.size(), plane);
		return p.places.size() - 1;
	}

	public static <T extends ITransport> T minus(ClassArray<T> p, int index) throws AerodromeIndexOutOfRangeException {
		if (p.places.get(index) != null) {
			T plane = p.places.get(index);
			p.places.remove(index);
			return plane;
		}
		throw new AerodromeIndexOutOfRangeException();
	}

	public boolean checkFree(int index) {
		if (places.get(index) == null)
			return true;
		return false;
	}

	public T getPlane(int ind) {
		if (places.get(ind) != null)
			return places.get(ind);
		return defaultValue;
	}

	@Override
	public Iterator<T> iterator() {
		return this;
	}

	private int currentIndex;

	@Override
	public boolean hasNext() {
		if (currentIndex + 1 >= places.size()) {
			currentIndex = -1;
			return false;
		}
		currentIndex++;
		return true;
	}

	@Override
	public T next() {
		return (T) places.get(currentIndex);
	}

	@Override
	public int compareTo(ClassArray<T> other) {
		if (places.size() > other.places.size())
			return -1;
		else if (places.size() < other.places.size())
			return 1;
		else {
			for (int i = 0; i < places.size(); i++) {
				if ((places.get(places.keys().nextElement()) instanceof Figther)
						&& (other.places.get(other.places.keys().nextElement()) instanceof Figther)) {
					return (((Figther) places.get(places.keys().nextElement()))
							.compareTo(((Figther) other.places.get(other.places.keys().nextElement()))));
				}
				if ((places.get(places.keys().nextElement()) instanceof War)
						&& (other.places.get(other.places.keys().nextElement()) instanceof Figther))
					return 1;
				if ((places.get(places.keys().nextElement()) instanceof Figther)
						&& (other.places.get(other.places.keys().nextElement()) instanceof War))
					return -1;
				if ((places.get(places.keys().nextElement()) instanceof War)
						&& (other.places.get(other.places.keys().nextElement()) instanceof War)) {
					return (((War) places.get(places.keys().nextElement()))
							.compareTo(((War) other.places.get(other.places.keys().nextElement()))));
				}

			}
		}
		return 0;
	}

}
