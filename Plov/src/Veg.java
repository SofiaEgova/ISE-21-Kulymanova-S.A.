
public class Veg {
	

	private boolean isDirty = true;
	private boolean needCut=true;
	private boolean ready=false;
	
	
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
	
	
	public boolean getReady() {
		return ready;
	}


	public void heat()
	{
		ready = true;
	}
}
