
public class Stove {
private boolean isOn;
	
	public boolean getState() {
		return isOn;
	}
	
	public void setState(boolean s) {
		isOn =s;
	}
	
	public void cook(Pan pan) {
		pan.heat();
	}
	
}
