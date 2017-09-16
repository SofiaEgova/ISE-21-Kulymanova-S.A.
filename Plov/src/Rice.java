
public class Rice {
	
	private boolean isDirty=true;
	private boolean ready;
	
	
	private boolean inPan;
	public boolean getInPan() {
		return inPan;
	}
	
	public void setInPan(boolean s) {
		inPan=s;
	}

	public boolean getDirty() {
		return isDirty;
	}
	
	public void setDirty(boolean d) {
		isDirty = d;
	}
	
	public boolean getReady() {
		return ready;
	}
	

	public void heat()
	{
		ready=true;
	}


}
