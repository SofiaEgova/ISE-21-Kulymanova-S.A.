
public class Rice {
	
	private boolean isDirty=true;
	private boolean ready;
	
	

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
