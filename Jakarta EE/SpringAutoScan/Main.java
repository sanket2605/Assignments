package mypack;

import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Main 
{
	public static void main(String[] args) 
	{
       
		ClassPathXmlApplicationContext bf = new ClassPathXmlApplicationContext("weapon.xml");
		 Soldier soldier=(Soldier)bf.getBean("soldier");
	        soldier.perform();
	}

}
