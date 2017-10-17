
public class Knife {
	public void cutMeat(Meat m)
	{
		if (m.getNeedCut()) m.setNeedCut(false);
	}

	public void cutVag(Veg v)
	{
		if (v.getNeedCut()) v.setNeedCut(false);
	}
}
