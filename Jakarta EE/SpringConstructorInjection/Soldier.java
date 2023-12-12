package mypack;
public class Soldier
{
    private Weapon weapon;
    public Soldier()
    {
        System.out.println("Soldier no-arg constructor");
    }
    public void setweapon(Weapon weapon) 
    {
        System.out.println("inside setter method");
        this.weapon = weapon;
    }  
    public void perform()
    {
        weapon.attack();
    }
}

