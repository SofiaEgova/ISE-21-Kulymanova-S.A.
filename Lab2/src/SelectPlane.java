import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.SystemColor;
import java.awt.datatransfer.DataFlavor;
import java.awt.datatransfer.UnsupportedFlavorException;
import java.awt.dnd.DnDConstants;
import java.awt.dnd.DropTarget;
import java.awt.dnd.DropTargetDragEvent;
import java.awt.dnd.DropTargetDropEvent;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.IOException;

import javax.swing.JButton;
import javax.swing.JComponent;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.TransferHandler;

public class SelectPlane extends JDialog {

	ITransport plane = null;
	JPanel panel;
	boolean r;

	public SelectPlane(JFrame parent) {
		super(parent, true);
		main();
	}

	public boolean res() {
		setVisible(true);
		return r;
	}

	public void main() {
		this.getContentPane().setBackground(SystemColor.controlHighlight);
		this.setBounds(100, 100, 450, 300);
		this.setDefaultCloseOperation(JDialog.DISPOSE_ON_CLOSE);
		this.getContentPane().setLayout(null);

		JLabel lblPlane = new JLabel("Plane");
		lblPlane.setBounds(44, 29, 46, 14);
		this.getContentPane().add(lblPlane);

		JLabel lblFighter = new JLabel("Fighter");
		lblFighter.setBounds(44, 64, 46, 14);
		this.getContentPane().add(lblFighter);

		panel = new JPanel();
		FlowLayout flowLayout = (FlowLayout) panel.getLayout();
		panel.setBounds(144, 29, 120, 76);
		this.getContentPane().add(panel);

		MouseListener mouseL = new MouseListener() {

			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub

			}

			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				JComponent jc = (JComponent) e.getSource();
				TransferHandler th = jc.getTransferHandler();
				th.exportAsDrag(jc, e, TransferHandler.COPY);
			}

			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub

			}

		};

		lblPlane.addMouseListener(mouseL);
		lblFighter.addMouseListener(mouseL);
		lblFighter.setTransferHandler(new TransferHandler("text"));
		lblPlane.setTransferHandler(new TransferHandler("text"));

		panel.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {

				try {

					for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
						if (e.getTransferable().getTransferData(df) == "Plane") {
							plane = new War(100, 10, 100, 100, Color.WHITE);
						} else if (e.getTransferable().getTransferData(df) == "Fighter") {
							plane = new Figther(100, 10, 100, 100, Color.WHITE, true, true, Color.BLACK);
						}
						draw(panel, plane);
					}
				} catch (Exception ex) {
					System.out.println(ex);
				}

			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (Exception e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});

		JLabel lblMainColor = new JLabel("Main Color");
		lblMainColor.setBounds(154, 116, 90, 27);
		this.getContentPane().add(lblMainColor);

		JLabel lblDopColor = new JLabel("Dop Color");
		lblDopColor.setBounds(154, 154, 90, 27);
		this.getContentPane().add(lblDopColor);

		lblMainColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (plane != null) {
					try {
						for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
							plane.setMainColor((selectColor(e.getTransferable().getTransferData(df).toString())));
							draw(panel, plane);
						}
					} catch (Exception ex) {
						System.out.println(ex + "FF");
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});
		lblDopColor.setDropTarget(new DropTarget() {

			public void drop(DropTargetDropEvent e) {
				if (plane != null) {
					try {

						for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
							((Figther) plane)
									.setColorFight((selectColor(e.getTransferable().getTransferData(df).toString())));
							draw(panel, plane);
						}
					} catch (Exception ex) {
						System.out.println(ex);
					}
				}
			}

			public void dragEnter(DropTargetDragEvent e) {
				for (DataFlavor df : e.getTransferable().getTransferDataFlavors()) {
					try {
						if (e.getTransferable().getTransferData(df) instanceof String)
							e.acceptDrag(DnDConstants.ACTION_COPY);
						else
							e.acceptDrag(DnDConstants.ACTION_NONE);
					} catch (UnsupportedFlavorException | IOException e1) {
						// TODO Auto-generated catch block
						e1.printStackTrace();
					}
				}
			}
		});

		JPanel panelYellow = new JPanel();
		panelYellow.setName("yellow");
		panelYellow.setBackground(Color.YELLOW);
		panelYellow.setBounds(289, 29, 46, 39);
		this.getContentPane().add(panelYellow);

		JPanel panelBlue = new JPanel();
		panelBlue.setName("blue");
		panelBlue.setBackground(Color.BLUE);
		panelBlue.setBounds(357, 29, 46, 39);
		this.getContentPane().add(panelBlue);

		JPanel panelRed = new JPanel();
		panelRed.setName("red");
		panelRed.setBackground(Color.RED);
		panelRed.setBounds(289, 83, 46, 39);
		this.getContentPane().add(panelRed);

		JPanel panelGreen = new JPanel();
		panelGreen.setName("green");
		panelGreen.setBackground(Color.GREEN);
		panelGreen.setBounds(357, 83, 46, 39);
		this.getContentPane().add(panelGreen);

		JPanel panelBlack = new JPanel();
		panelBlack.setName("black");
		panelBlack.setBackground(Color.BLACK);
		panelBlack.setBounds(289, 133, 46, 39);
		this.getContentPane().add(panelBlack);

		JPanel panelPink = new JPanel();
		panelPink.setName("pink");
		panelPink.setBackground(Color.PINK);
		panelPink.setBounds(357, 133, 46, 39);
		this.getContentPane().add(panelPink);

		JPanel panelMagenta = new JPanel();
		panelMagenta.setName("magenta");
		panelMagenta.setBackground(Color.MAGENTA);
		panelMagenta.setBounds(289, 187, 46, 39);
		this.getContentPane().add(panelMagenta);

		JPanel panelCyan = new JPanel();
		panelCyan.setName("cyan");
		panelCyan.setBackground(Color.CYAN);
		panelCyan.setBounds(357, 187, 46, 39);
		this.getContentPane().add(panelCyan);

		panelYellow.addMouseListener(mouseL);
		panelYellow.setTransferHandler(new TransferHandler("name"));

		panelBlue.addMouseListener(mouseL);
		panelBlue.setTransferHandler(new TransferHandler("name"));

		panelRed.addMouseListener(mouseL);
		panelRed.setTransferHandler(new TransferHandler("name"));

		panelGreen.addMouseListener(mouseL);
		panelGreen.setTransferHandler(new TransferHandler("name"));

		panelBlack.addMouseListener(mouseL);
		panelBlack.setTransferHandler(new TransferHandler("name"));

		panelPink.addMouseListener(mouseL);
		panelPink.setTransferHandler(new TransferHandler("name"));

		panelMagenta.addMouseListener(mouseL);
		panelMagenta.setTransferHandler(new TransferHandler("name"));

		panelCyan.addMouseListener(mouseL);
		panelCyan.setTransferHandler(new TransferHandler("name"));

		JButton btnAdd = new JButton("ADD");
		btnAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				r = true;
				System.out.println("ADD" + r);
				dispose();
			}
		});
		btnAdd.setBounds(27, 133, 89, 23);
		this.getContentPane().add(btnAdd);

		JButton btnNO = new JButton("NO");
		btnNO.setBounds(27, 187, 89, 23);
		this.getContentPane().add(btnNO);
		btnNO.addActionListener((ActionEvent e) -> {
			r = false;
			dispose();
		});
	}

	public ITransport getPlane() {
		return plane;
	}

	public void draw(JPanel panel, ITransport plane) {
		if (plane != null) {
			Graphics gr = panel.getGraphics();
			gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
			plane.setPosition(5, 5);
			plane.draw(gr);
		}
	}

	public Color selectColor(String s) {
		switch (s) {
		case "yellow":
			return Color.yellow;
		case "blue":
			return Color.blue;
		case "red":
			return Color.red;
		case "green":
			return Color.green;
		case "black":
			return Color.black;
		case "pink":
			return Color.pink;
		case "magenta":
			return Color.magenta;
		case "cyan":
			return Color.cyan;
		}

		return null;
	}

}
