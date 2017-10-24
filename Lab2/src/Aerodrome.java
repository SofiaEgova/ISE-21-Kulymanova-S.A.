import java.awt.Color;
import java.awt.Graphics;

public class Aerodrome {
	ClassArray<ITransport> aerodrome;

	int countPlaces = 20;
	int placeWidth = 210;
	int placeHeight = 80;

	public Aerodrome()
	{
		aerodrome = new ClassArray<ITransport>(countPlaces, null);
	}

	public int putPlaneInAerodrome(ITransport plane)
	{
		return aerodrome.plus(aerodrome, plane);
	}

	public ITransport getPlaneInAerodrome(int index)
	{
		return aerodrome.minus(aerodrome, index);
	}

	public void draw(Graphics g,int width,int height)
	{
		drawMarking(g);
		for(int i = 0; i < countPlaces; i++)
		{
			ITransport plane = aerodrome.getObject(i);
			if (plane != null)
			{
				plane.setPosition(5 + i / 5 * placeWidth + 5, i % 5 * placeHeight + 15);
				plane.draw(g);
			}
		}
		
	}

	public void drawMarking(Graphics g)
	{
		g.setColor(Color.BLACK);
		g.drawRect( 0, 0, (countPlaces / 5) * placeWidth, 450);
		for(int i = 0; i < countPlaces / 5; i++)
		{
			for(int j = 0; j < 6; j++)
			{
				g.drawLine( i * placeWidth,j* placeHeight,i*placeWidth+110,j*placeHeight);
			}
			g.drawLine( i * placeWidth, 0, i * placeWidth,400);
		}
		
	}


}
