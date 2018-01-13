import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class War extends Plane implements Serializable, Comparable<War> {

	public War(int maxSpeed, int fuel, int maxHeight, int weight, Color colorWar) {
		this.maxSpeed = maxSpeed;
		this.fuel = fuel;
		this.weight = weight;
		this.colorBody = colorWar;
		this.maxHeight = maxHeight;

		startX = 5;
		startY = 5;

	}

	@Override
	protected void setmaxSpeed(int s) {
		// TODO Auto-generated method stub
		if (s > 0 && s < 2500)
			super.maxSpeed = s;
		else
			super.maxSpeed = 2000;
	}

	@Override
	public int getmaxSpeed() {
		// TODO Auto-generated method stub
		return super.maxSpeed;
	}

	@Override
	protected void setWeight(int w) {
		// TODO Auto-generated method stub
		if (w > 16000 && w < 35000)
			super.weight = w;
		else
			super.weight = 30000;
	}

	@Override
	public int getWeight() {
		// TODO Auto-generated method stub
		return super.weight;
	}

	@Override
	protected void setmaxHeight(int h) {
		// TODO Auto-generated method stub
		if (h > 0 && h < 100)
			super.maxHeight = h;
		else
			super.maxHeight = 5;
	}

	@Override
	public int getmaxHeight() {
		// TODO Auto-generated method stub
		return super.maxHeight;
	}

	@Override
	public void move(Graphics g) {
		if (this.fuel > 0) {
			if (startY > maxHeight)
				startY -= 3;

			startX += 10;
			this.fuel -= 10;
		} else {
			System.out.println("Нету топлива");
		}
		draw(g);
	}

	@Override
	public void draw(Graphics g) {
		// TODO Auto-generated method stub
		drawWarPlane(g);
	}

	protected void drawWarPlane(Graphics g) {
		g.setColor(colorBody);
		g.fillOval(startX + 10, startY, 20, 50);
		g.fillOval(startX, startY + 20, 60, 20);

	}

	@Override
	public String getInfo() {
		// TODO Auto-generated method stub
		return maxSpeed + ";" + fuel + ";" + weight + ";" + maxHeight + ";" + colorBody;

	}

	private void writeObject(ObjectOutputStream s) throws IOException {
		s.defaultWriteObject();
		s.writeInt(colorBody.getRed());
		s.writeInt(colorBody.getGreen());
		s.writeInt(colorBody.getBlue());
	}

	private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
		s.defaultReadObject();
		int red = s.readInt();
		int green = s.readInt();
		int blue = s.readInt();
		colorBody = new Color(red, green, blue);
	}

	public int compareTo(War other) {
		// TODO Auto-generated method stub
		if (other == null)
			return 1;
		if (maxSpeed != other.maxSpeed)
			return maxSpeed + "".compareTo(other.maxSpeed + "");
		if (maxHeight != other.maxHeight)
			return maxHeight + "".compareTo(other.maxHeight + "");
		if (weight != other.weight)
			return weight + "".compareTo(other.weight + "");
		if (colorBody != other.colorBody)
			return colorBody.toString().compareTo(other.colorBody.toString());
		return 0;
	}

	public boolean equals(War other) {
		if (other == null)
			return false;
		if (maxSpeed != other.maxSpeed) {
			return false;
		}
		if (maxHeight != other.maxHeight) {
			return false;
		}
		if (weight != other.weight) {
			return false;
		}
		if (colorBody != other.colorBody) {
			return false;
		}
		return true;
	}

	@Override
	public boolean equals(Object obj) {
		if (obj == null)
			return false;
		War warObj = (War) obj;
		if (warObj == null)
			return false;
		else
			return equals(warObj);
	}

}
