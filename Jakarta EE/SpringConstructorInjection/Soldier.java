package mypack;
public class Soldier
{
    private Weapon weapon;

    public Solider (Weapon weapon)
    {
        this.weapon=weapon;
    }
    
    public void perform()
    {
        weapon.attack();
    }
}

