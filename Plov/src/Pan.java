
public class Pan {
	
	private Rice rice;
	private Meat[] meat;
	private Veg[] veg;
	private Spice spice;
	
	
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
		}
	}
	
	public void addRice(Rice r) {
		rice=r;
	}
	
	public boolean meatIsReadyToGo() {
		for(int i=0;i<meat.length;i++) {
			if(meat[i]==null) return false;
		}
		for(int i=0;i<veg.length;i++) {
			if(veg[i]==null) return false;
		}
		if(spice==null) return false;
		
		return true;
	}
	
	
	
	public void heatMeat() {
		
		for(int i=0;i<meat.length;i++) {
			meat[i].heat();
		}
		for(int i=0;i<veg.length;i++) {
			veg[i].heat();
		}
		
	}
	
	public boolean plovIsReadyToGo() {
		for(int i=0;i<meat.length;i++) {
			if(meat[i]==null) return false;
		}
		for(int i=0;i<veg.length;i++) {
			if(veg[i]==null) return false;
		}
		if(spice==null) return false;
		
		if(rice==null) return false;
		
		return true;
	}
	
	public void heatPlov() {
		rice.heat();
	}
	
	
}
