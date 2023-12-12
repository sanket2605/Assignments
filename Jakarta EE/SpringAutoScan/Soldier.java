package mypack;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Component;

@Component
public class Soldier
{
	@Autowired
	@Qualifier("gun")
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
