import java.awt.Color;
import java.awt.Graphics;

public abstract class Plane implements ITransport {

	protected int startX;
	protected int startY;
	public int maxSpeed;
	public int weight;
	public int maxHeight;
	public int fuel;
	public Color color;

	protected abstract void setmaxSpeed(int s);

	public abstract int getmaxSpeed();

	protected abstract void setWeight(int w);

	public abstract int getWeight();

	protected abstract void setmaxHeight(int h);

	public abstract int getmaxHeight();

	public abstract void move(Graphics g);

	public abstract void draw(Graphics g);

	public void setPosition(int x, int y) {
		startX = x;
		startY = y;
	}

	public void setMainColor(Color c) {
		color = c;
	}
}
