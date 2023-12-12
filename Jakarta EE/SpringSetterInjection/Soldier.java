package mypack;
public class Soldier
{
    private Weapon weapon;
    
    public void setweapon(Weapon weapon) 
    {
        this.weapon = weapon;
    }  
    public void perform()
    {
        weapon.attack();
    }
}
