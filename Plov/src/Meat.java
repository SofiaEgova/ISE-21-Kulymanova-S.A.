
public class Meat {
	
	private int ready = 0;
	
	
	
	private boolean needCut=true;
	private boolean inPan;
	public boolean getInPan() {
		return inPan;
	}
	
	public void setInPan(boolean s) {
		inPan=s;
	}
	
	
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
