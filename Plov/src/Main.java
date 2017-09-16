import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JRadioButton;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JSlider;
import javax.swing.JCheckBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

public class Main {

	private Rice rice;
	private Meat[] meat;
	private Veg[] veg;
	private Spice spice;
	private WaterTap waterTap;
	private Water water;

	private Knife knife;
	private Pan pan;
	private Stove stove;

	private boolean cook = false;
	private boolean finish = false;

	private JFrame frame;
	private JTextField textField;
	private JTextField textField_1;
	private JRadioButton rdbtnNewRadioButton;
	private JRadioButton rdbtnNewRadioButton_1;
	private JButton btnNewButton_3;
	private JButton btnNewButton_4;
	private JButton btnNewButton_5;
	private JButton btnNewButton_6;
	private JButton btnNewButton_7;
	private JButton btnNewButton_8;
	private JButton btnNewButton_9;
	private JButton btnNewButton_10;
	private JButton btnNewButton_12;

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
		initialize();

		waterTap = new WaterTap();
		knife = new Knife();
		pan = new Pan();
		rice = new Rice();
		spice = new Spice();
		stove = new Stove();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 417);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JButton btnNewButton = new JButton("Wash Veg");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (cook) {
					if (waterTap.getState()) {
						for (int i = 0; i < veg.length; i++) {
							if (!veg[i].getDirty()) {
								System.out.println("����� ��� ������, ����� ������");
								return;
							}
							waterTap.washVeg(veg[i]);
						}
						System.out.println("����� ������, ����� ������");
					} else {
						System.out.println("������ ����");
					}
				} else {
					System.out.println("������ ����");
				}
			}
		});
		btnNewButton.setBounds(56, 23, 122, 23);
		frame.getContentPane().add(btnNewButton);

		JButton btnNewButton_1 = new JButton("Wash Rice");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (waterTap.getState()) {
					if (!rice.getDirty()) {
						System.out.println("��� �����, ������");
						return;
					}
					waterTap.washRice(rice);
					System.out.println("������ ���");
				} else {
					System.out.println("������ ����");
				}
			}
		});
		btnNewButton_1.setBounds(56, 53, 122, 23);
		frame.getContentPane().add(btnNewButton_1);

		textField = new JTextField();
		textField.setBounds(205, 24, 86, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);

		textField_1 = new JTextField();
		textField_1.setBounds(205, 54, 86, 20);
		frame.getContentPane().add(textField_1);
		textField_1.setColumns(10);

		JButton btnNewButton_2 = new JButton("Start");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (!"".equals(textField.getText()) && !"".equals(textField_1.getText())) {
					cook = true;

					pan.init(Integer.parseInt(textField.getText()), Integer.parseInt(textField_1.getText()));

					meat = new Meat[Integer.parseInt(textField.getText())];
					veg = new Veg[Integer.parseInt(textField_1.getText())];

					System.out
							.println("���� " + textField.getText() + " ����, ������ " + textField.getText() + " ����");

					for (int i = 0; i < meat.length; i++) {
						meat[i] = new Meat();
					}
					for (int i = 0; i < veg.length; i++) {
						veg[i] = new Veg();
					}

					textField.setEditable(false);
					textField_1.setEditable(false);
				}

				else {
					System.out.println("����� ����� ���� � ����� ");
				}
			}

		});
		btnNewButton_2.setBounds(205, 85, 89, 23);
		frame.getContentPane().add(btnNewButton_2);

		rdbtnNewRadioButton = new JRadioButton("On");
		rdbtnNewRadioButton.setBounds(6, 23, 44, 23);
		frame.getContentPane().add(rdbtnNewRadioButton);

		rdbtnNewRadioButton_1 = new JRadioButton("Off");
		rdbtnNewRadioButton_1.setBounds(6, 53, 44, 23);
		frame.getContentPane().add(rdbtnNewRadioButton_1);

		ButtonGroup group = new ButtonGroup();
		group.add(rdbtnNewRadioButton);
		group.add(rdbtnNewRadioButton_1);

		btnNewButton_3 = new JButton("Cut Meat");
		btnNewButton_3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (cook) {
					for (int i = 0; i < meat.length; i++) {
						if (!meat[i].getNeedCut()) {
							System.out.println("���� ��� ��������, ����� � ����������");
							return;
						} else {
							knife.cutMeat(meat[i]);
						}
					}
					System.out.println("���� ��������, ����� ������");
				} else {
					System.out.println("������ ������, ��� ����?");
				}

			}
		});
		btnNewButton_3.setBounds(319, 23, 89, 23);
		frame.getContentPane().add(btnNewButton_3);

		btnNewButton_4 = new JButton("Cut Veg");
		btnNewButton_4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (cook) {
					for (int i = 0; i < veg.length; i++) {
						if (veg[i].getDirty()) {
							System.out.println("����� �������, ����� ��");
							return;
						}
						if (!veg[i].getNeedCut()) {
							System.out.println("����� ��� ��������, ����");
							return;
						}
						knife.cutVag(veg[i]);
					}
					System.out.println("����� ��������, ����� ������");
				}

				else {
					System.out.println("������ ������, ��� �����?");
				}

			}
		});
		btnNewButton_4.setBounds(319, 53, 89, 23);
		frame.getContentPane().add(btnNewButton_4);

		btnNewButton_5 = new JButton("Add Meat");
		btnNewButton_5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (cook) {
					for (int i = 0; i < meat.length; i++) {
						if (meat[i].getNeedCut()) {
							System.out.println("���� �� �������� ");
							return;
						}
					}
					pan.addMeat(meat);
					for (int i = 0; i < meat.length; i++) {
						meat[i].setInPan(true);
					}

					System.out.println("���� � ����������");
				} else {
					System.out.println("���� ����?");
				}

			}
		});
		btnNewButton_5.setBounds(26, 145, 89, 23);
		frame.getContentPane().add(btnNewButton_5);

		btnNewButton_6 = new JButton("Add Rice in Pan");
		btnNewButton_6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (rice.getReady()) {
					pan.addRice(rice);
					rice.setInPan(true);
					pan.setPlov(true);
					System.out.println("��� ������ � �����, �������� ������");
				} else {
					System.out.println("��� � ����� ��� �� �����");
				}

			}
		});
		btnNewButton_6.setBounds(26, 312, 136, 23);
		frame.getContentPane().add(btnNewButton_6);

		btnNewButton_7 = new JButton("Add Veg");
		btnNewButton_7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (cook) {
					for (int i = 0; i < veg.length; i++) {
						if (veg[i].getDirty()) {
							System.out.println("����� �������, ����� ��");
							return;
						}
						if (veg[i].getNeedCut()) {
							System.out.println("����� �� ��������");
							return;
						}
					}

					pan.addVeg(veg);
					for (int i = 0; i < veg.length; i++) {
						veg[i].setInPan(true);
					}
					System.out.println("����� � ����������");
				}

				else {
					System.out.println("���� ������");
				}

			}
		});
		btnNewButton_7.setBounds(26, 179, 89, 23);
		frame.getContentPane().add(btnNewButton_7);

		btnNewButton_8 = new JButton("Add Spice");
		btnNewButton_8.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				System.out.println("�������� ������");
				spice.setInPan(true);

			}
		});
		btnNewButton_8.setBounds(26, 213, 103, 23);
		frame.getContentPane().add(btnNewButton_8);

		btnNewButton_9 = new JButton("Fry");
		btnNewButton_9.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (stove.getState()) {
					if (cook) {
						for (int i = 0; i < meat.length; i++) {
							if (!meat[i].getInPan()) {
								System.out.println("���� ���!");
								return;
							}
						}
						for (int i = 0; i < veg.length; i++) {
							if (!veg[i].getInPan()) {
								System.out.println("������ ���!");
								return;
							}

						}
						if (!spice.getInPan()) {
							System.out.println("������ ��� :(");
							return;
						}
						pan.heatMeat();
						System.out.println("���� ������, ����� ���");

					}

					else {
						System.out.println("��� ���������");
					}
				} else {
					System.out.println("������ �����!! ");
				}
			}
		});
		btnNewButton_9.setBounds(125, 145, 89, 23);
		frame.getContentPane().add(btnNewButton_9);

		JLabel lblNewLabel = new JLabel("Water Tap");
		lblNewLabel.setEnabled(false);
		lblNewLabel.setBounds(26, 11, 67, 14);
		frame.getContentPane().add(lblNewLabel);

		JLabel lblNewLabel_1 = new JLabel("Pan");
		lblNewLabel_1.setEnabled(false);
		lblNewLabel_1.setBounds(79, 126, 62, 14);
		frame.getContentPane().add(lblNewLabel_1);

		JLabel lblNewLabel_2 = new JLabel("Count");
		lblNewLabel_2.setEnabled(false);
		lblNewLabel_2.setBounds(219, 11, 46, 14);
		frame.getContentPane().add(lblNewLabel_2);

		JLabel lblNewLabel_3 = new JLabel("Stove");
		lblNewLabel_3.setEnabled(false);
		lblNewLabel_3.setBounds(349, 112, 46, 14);
		frame.getContentPane().add(lblNewLabel_3);

		JLabel lblNewLabel_4 = new JLabel("Rice");
		lblNewLabel_4.setEnabled(false);
		lblNewLabel_4.setBounds(26, 253, 46, 14);
		frame.getContentPane().add(lblNewLabel_4);

		JButton btnNewButton_11 = new JButton("Rice cook");
		btnNewButton_11.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (stove.getState()) {
					if (rice.getDirty()) {
						System.out.println("����� ���, �� �������");
						return;
					}
					pan.addRice(rice);
					rice.heat();
					System.out.println("� ��� �����, ����� � ���� ;)");
				} else {
					System.out.println("������ �����!");
				}

			}
		});
		btnNewButton_11.setBounds(26, 278, 136, 23);
		frame.getContentPane().add(btnNewButton_11);

		JRadioButton rdbtnNewRadioButton_2 = new JRadioButton("ON");
		rdbtnNewRadioButton_2.setBounds(319, 133, 109, 23);
		frame.getContentPane().add(rdbtnNewRadioButton_2);

		JRadioButton rdbtnNewRadioButton_3 = new JRadioButton("OFF");
		rdbtnNewRadioButton_3.setBounds(319, 159, 109, 23);
		frame.getContentPane().add(rdbtnNewRadioButton_3);

		ButtonGroup group1 = new ButtonGroup();
		group1.add(rdbtnNewRadioButton_2);
		group1.add(rdbtnNewRadioButton_3);

		btnNewButton_10 = new JButton("Finish");
		btnNewButton_10.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (stove.getState()) {
					if (cook) {
						
						if(!pan.getPlov()) {
							System.out.println("� ��� ���� ��?!");
							return;
						}
						
						finish = true;
						System.out.println("��� ������, ����� ������ ");
						
						
						
					} else {
						System.out.println("��� ���������");
					}
				} else {
					System.out.println("������ �����!! ");
				}
			}
		});
		btnNewButton_10.setBounds(202, 249, 89, 23);
		frame.getContentPane().add(btnNewButton_10);
		
		btnNewButton_12 = new JButton("Eat!!! :D");
		btnNewButton_12.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(finish) {
					if(waterTap.getState()) {
						System.out.println("������ ����");
						return;
					}
					if(stove.getState()) {
						System.out.println("������� �����");
						return;
					}
					JOptionPane.showMessageDialog(null, "��������� ��������!!!");
					System.exit(0);
					
				}
				else {
					System.out.println("��� ������ ������");
				}
				
			}
		});
		btnNewButton_12.setBounds(205, 287, 203, 81);
		frame.getContentPane().add(btnNewButton_12);

		rdbtnNewRadioButton_2.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				stove.setState(true);
				System.out.println("����� ��������!");
			}
		});

		rdbtnNewRadioButton_3.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				stove.setState(false);
				System.out.println("����� ���������!");
			}
		});

		rdbtnNewRadioButton.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				// TODO Auto-generated method stub
				waterTap.setState(true);
				System.out.println("���� ������");
			}

		});

		rdbtnNewRadioButton_1.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent arg0) {
				// TODO Auto-generated method stub
				waterTap.setState(false);
				System.out.println("���� ������");
			}

		});

	}
}
