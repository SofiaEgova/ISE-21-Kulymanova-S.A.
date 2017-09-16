
public class Veg {
	

	private boolean isDirty = true;
	private boolean needCut=true;
	private int ready = 0;
	private boolean inPan;
	public boolean getInPan() {
		return inPan;
	}
	
	public void setInPan(boolean s) {
		inPan=s;
	}
	
	public void setDirty(boolean s) {
		isDirty = s;
	}
	
	public boolean getDirty(){
		return isDirty;
	}

	public void setNeedCut(boolean cut) {
		needCut = cut;
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
