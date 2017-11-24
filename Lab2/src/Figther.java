import java.awt.Color;
import java.awt.Graphics;

public class Figther extends War {

	private boolean bomb;
	private boolean gun;

	private Color colorFight;

	public Figther(int maxSpeed, int fuel, int maxHeight, int weight, Color colorWar, boolean bomb, boolean gun,
			Color colorFight) {
		super(maxSpeed, fuel, maxHeight, weight, colorWar);
		// TODO Auto-generated constructor stub
		this.bomb = bomb;
		this.gun = gun;
		this.colorFight = colorFight;

	}

	protected void drawWarPlane(Graphics g) {
		super.drawWarPlane(g);
		g.setColor(colorFight);

		if (bomb) {

			g.fillOval(startX, startY + 10, 15, 10);

		}
		if (gun) {
			g.fillRect(startX + 30, startY + 35, 30, 5);
		}

	}
	
	public void setColorFight(Color f) {
		colorFight = f;
	}
}
