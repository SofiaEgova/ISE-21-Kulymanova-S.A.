import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JLabel;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;

public class Main {

	private JFrame frame;
	private JTextField textMaxSpeed;
	private JTextField textFuel;
	private JTextField textWeight;
	private JTextField textMaxHeight;

	Color color;
	Color colorFight;
	int maxSpeed;
	int weight;
	int maxHeight;
	int fuel;
	boolean bomb;
	boolean gun;

	private ITransport interTran;
	private Frame btnColor;
	private Frame btnSelectFigtherColor;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main window = new Main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Main() {
		color = Color.RED;
		colorFight = Color.BLACK;
		maxSpeed = 2000;
		fuel = 0;
		weight = 30000;
		maxHeight = 5;

		initialize();

	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 526, 398);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		textMaxSpeed = new JTextField();
		textMaxSpeed.setBounds(81, 227, 86, 20);
		frame.getContentPane().add(textMaxSpeed);
		textMaxSpeed.setColumns(10);

		textFuel = new JTextField();
		textFuel.setBounds(81, 261, 86, 20);
		frame.getContentPane().add(textFuel);
		textFuel.setColumns(10);

		textWeight = new JTextField();
		textWeight.setBounds(253, 227, 86, 20);
		frame.getContentPane().add(textWeight);
		textWeight.setColumns(10);

		textMaxHeight = new JTextField();
		textMaxHeight.setBounds(368, 261, 86, 20);
		frame.getContentPane().add(textMaxHeight);
		textMaxHeight.setColumns(10);

		JPanel panel = new JPanel();
		panel.setBounds(10, 11, 357, 195);
		frame.getContentPane().add(panel);

		JCheckBox checkBomb = new JCheckBox("Check Bomb");
		checkBomb.setBounds(378, 288, 97, 23);
		frame.getContentPane().add(checkBomb);

		JCheckBox checkGun = new JCheckBox("Check Gun");
		checkGun.setBounds(382, 314, 97, 23);
		frame.getContentPane().add(checkGun);

		JButton btnDrawPlane = new JButton("Draw Plane");
		btnDrawPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (checkFields()) {
					interTran = new War(maxSpeed, fuel, maxHeight, weight, color);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					interTran.draw(gr);

				}

			}
		});
		btnDrawPlane.setBounds(29, 292, 115, 23);
		frame.getContentPane().add(btnDrawPlane);

		JButton btnDrawFigther = new JButton("Draw Figther");
		btnDrawFigther.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					bomb = checkBomb.isSelected();
					gun = checkGun.isSelected();
					interTran = new Figther(maxSpeed, fuel, maxHeight, weight, color, bomb, gun, colorFight);

					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					interTran.draw(gr);
				}

			}
		});
		btnDrawFigther.setBounds(172, 292, 151, 23);
		frame.getContentPane().add(btnDrawFigther);

		JButton btnColor = new JButton("Select Color");
		btnColor.setForeground(color);
		btnColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = btnColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnColor.setForeground(foreground);
				}
				color = foreground;
			}
		});
		btnColor.setBounds(29, 326, 115, 23);
		frame.getContentPane().add(btnColor);

		JButton btnMove = new JButton("Move");
		btnMove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (interTran != null) {
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					interTran.move(gr);
				}
			}
		});
		btnMove.setBounds(390, 191, 89, 23);
		frame.getContentPane().add(btnMove);

		JButton btnSelectFigtherColor = new JButton("Select Figther Color");
		btnSelectFigtherColor.setForeground(colorFight);
		btnSelectFigtherColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color initialBackground = btnSelectFigtherColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnSelectFigtherColor.setForeground(foreground);
				}
				colorFight = foreground;
			}
		});
		btnSelectFigtherColor.setBounds(172, 326, 151, 23);
		frame.getContentPane().add(btnSelectFigtherColor);

		JLabel lblNewLabel = new JLabel("Max speed");
		lblNewLabel.setBounds(6, 230, 69, 14);
		frame.getContentPane().add(lblNewLabel);

		JLabel lblNewLabel_1 = new JLabel("Fuel");
		lblNewLabel_1.setBounds(29, 264, 46, 14);
		frame.getContentPane().add(lblNewLabel_1);

		JLabel texteight = new JLabel("Weight");
		texteight.setBounds(208, 230, 46, 14);
		frame.getContentPane().add(texteight);

		JLabel lblNewLabel_3 = new JLabel("Max Height (max 100)");
		lblNewLabel_3.setBounds(368, 242, 111, 14);
		frame.getContentPane().add(lblNewLabel_3);

	}

	private boolean checkParse(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		return true;
	}

	private boolean checkFields() {
		if (checkParse(textMaxSpeed.getText()))
			maxSpeed = Integer.parseInt(textMaxSpeed.getText());
		if (checkParse(textFuel.getText()))
			fuel = Integer.parseInt(textFuel.getText());
		if (checkParse(textWeight.getText()))
			weight = Integer.parseInt(textWeight.getText());
		if (checkParse(textMaxHeight.getText()))
			maxHeight = Integer.parseInt(textMaxHeight.getText());

		System.out.println(maxSpeed + " " + fuel + " " + weight + " " + maxHeight);

		return true;
	}
}
