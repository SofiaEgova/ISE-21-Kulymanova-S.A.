
public class Pan {
	
	private Rice rice;
	private Meat[] meat;
	private Veg[] veg;
	private Spice spice;
	
	private boolean plov=false;
	
	public void init(int countMeat,int countVeg)
	{
		meat = new Meat[countMeat];
		veg = new Veg[countVeg];
	}
	
	public Meat getMeat() {
		return meat[0];
	}
	
	public Rice getRice() {
		return rice;
	}
	
	public void addSpice (Spice s)
	{
		spice = s;
		spice.setInPan(true);
	}

	public void addMeat(Meat[] m)
	{
		for (int i = 0; i < meat.length; i++)
		{
			if (meat[i] == null)
			{
				meat[i] = m[i];
			}
		}
	}
	
	public void addVeg(Veg[] v) {
		for(int i=0;i<veg.length;i++) {
			if(veg[i]==null) {
				veg[i]=v[i];
				return;
			}
			veg[i].setInPan(true);
		}
	}
	
	public void addRice(Rice r) {
		rice=r;
		rice.setInPan(true);
	}
	
	
	
	public void heatMeat() {
		
		for(int i=0;i<meat.length;i++) {
			meat[i].heat();
		}
	}
	
	public void setPlov(boolean s) {
		plov=s;
	}
	
	public boolean getPlov() {
		return plov;
	}
	
}
