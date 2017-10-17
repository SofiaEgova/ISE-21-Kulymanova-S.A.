import java.awt.Color;
import java.awt.Graphics;

public class War extends Plane {

	public War(int maxSpeed, int fuel, int maxHeight, int weight, Color colorWar) {
		this.maxSpeed = maxSpeed;
		this.fuel = fuel;
		this.weight = weight;
		this.color = colorWar;
		this.maxHeight = maxHeight;

		startX = 10;
		startY = 100;

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
		// TODO Auto-generated method stub
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
		g.setColor(color);
		g.fillOval(startX + 10, startY, 20, 50);
		g.fillOval(startX, startY + 20, 60, 20);

	}

}
