import java.awt.Color;
import java.awt.Graphics;
import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;

import javax.print.DocFlavor.BYTE_ARRAY;

public class Aerodrome implements Serializable {

	ArrayList<ClassArray<ITransport>> aerodromeStages;

	int countPlaces = 20;
	int placeWidth = 210;
	int placeHeight = 80;

	int currentLevel;

	public Aerodrome(int countStages) {
		aerodromeStages = new ArrayList<ClassArray<ITransport>>(countStages);
		for (int i = 0; i < countStages; i++) {
			aerodromeStages.add(new ClassArray<ITransport>(countPlaces, null));
		}
	}

	public int getCurrentLevel() {
		return currentLevel;
	}

	public void levelUp() {
		if (currentLevel + 1 < aerodromeStages.size())
			currentLevel++;
	}

	public void levelDown() {
		if (currentLevel > 0)
			currentLevel--;
	}

	public int putPlaneInAerodrome(ITransport plane) throws AerodromeOverflowException, AerodromeAlreadyHaveException {
		return aerodromeStages.get(currentLevel).plus(aerodromeStages.get(currentLevel), plane);
	}

	public ITransport getPlaneInAerodrome(int index) throws AerodromeIndexOutOfRangeException {
		return aerodromeStages.get(currentLevel).minus(aerodromeStages.get(currentLevel), index);
	}

	public void draw(Graphics g, int width, int height) {
		drawMarking(g);
		int i = 0;
		while (aerodromeStages.get(currentLevel).hasNext()) {
			ITransport plane = aerodromeStages.get(currentLevel).next();
			if (plane != null) {
				plane.setPosition(5 + i / 5 * placeWidth + 5, i % 5 * placeHeight + 15);
				plane.draw(g);
				i++;
			}
		}

	}

	public void drawMarking(Graphics g) {
		g.setColor(Color.BLACK);
		g.drawRect(0, 0, (countPlaces / 5) * placeWidth, 450);
		for (int i = 0; i < countPlaces / 5; i++) {
			for (int j = 0; j < 6; j++) {
				g.drawLine(i * placeWidth, j * placeHeight, i * placeWidth + 110, j * placeHeight);
			}
			g.drawLine(i * placeWidth, 0, i * placeWidth, 400);
		}

	}

	public boolean save(String fileName) throws IOException {

		FileOutputStream save = null;
		try {
			save = new FileOutputStream(fileName);
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		ObjectOutputStream obSave = new ObjectOutputStream(save);
		obSave.writeObject(aerodromeStages);

		return true;
	}

	public boolean load(String filename) {
		try {
			ObjectInputStream obLoad = new ObjectInputStream(new BufferedInputStream(new FileInputStream(filename)));
			try {
				aerodromeStages = (ArrayList<ClassArray<ITransport>>) obLoad.readObject();
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		return true;
	}

	public void sort() {
		Collections.sort(aerodromeStages, new Comparator<ClassArray<ITransport>>() {

			@Override
			public int compare(ClassArray<ITransport> o1, ClassArray<ITransport> o2) {
				// TODO Auto-generated method stub
				return o1.compareTo(o2);
			}
		});
	}
}
