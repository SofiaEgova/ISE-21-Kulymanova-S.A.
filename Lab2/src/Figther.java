import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Figther extends War implements Serializable {

	private boolean bomb;
	private boolean gun;

	transient private Color colorFight;

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
	
	private void writeObject(ObjectOutputStream s) throws IOException {
        s.defaultWriteObject();
        s.writeInt(colorBody.getRed());
        s.writeInt(colorBody.getGreen());
        s.writeInt(colorBody.getBlue());
        s.writeInt(colorFight.getRed());
        s.writeInt(colorFight.getGreen());
        s.writeInt(colorFight.getBlue());
    }

    private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
        s.defaultReadObject();
        int red = s.readInt();
        int green = s.readInt();
        int blue = s.readInt();
        colorBody = new Color(red, green, blue);
        int red1 = s.readInt();
        int green1 = s.readInt();
        int blue1 = s.readInt();
        colorFight = new Color(red1, green1, blue1);
    }

	@Override
	public String getInfo() {
		// TODO Auto-generated method stub

		return maxSpeed + ";" + fuel + ";" + weight + ";" + colorBody + ";" + maxHeight + ";" + bomb + ";" + gun + ";"
				+ colorFight;

	}
}
