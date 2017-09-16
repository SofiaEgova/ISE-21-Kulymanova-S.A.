
public class WaterTap {

	private boolean isOpen;
	
	public boolean getState() {
		return isOpen;
	}
	
	public void setState(boolean s) {
		isOpen =s;
	}

	public void washRice(Rice r)
	{
		if (r.getDirty()) r.setDirty(false);
		
	}

	public void washVeg(Veg v)
	{
		if (v.getDirty()) v.setDirty(false);
	}
	
}
