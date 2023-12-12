package mypack;

import org.springframework.stereotype.Component;

@Component
public class Missiles implements Weapon
{

	@Override
	public void attack() 
	{
		System.out.println("Attack with Missiles");	
	}

}
