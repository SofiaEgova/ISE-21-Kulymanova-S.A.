
public class Meat {
	
	private int ready = 0;
	
	
	
	private boolean needCut=true;
	
	
	
	public void setNeedCut(boolean s) {
		needCut=s;
	}
	
	public boolean getNeedCut() {
		return needCut;
	}
	
	public int getReady() {
		return ready;
	}

	public void heat()
	{
		while (ready < 10) ready++;
	}
}
