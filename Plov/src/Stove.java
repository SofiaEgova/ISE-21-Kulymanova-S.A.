
public class Stove {
private boolean isOn;
	
	public boolean getState() {
		return isOn;
	}
	
	public void setState(boolean s) {
		isOn =s;
	}
	
	public void cookMeat(Pan pan) {
		pan.heatMeat();
	}
	
	public void cookPlov(Pan pan) {
		pan.heatPlov();
	}
}
