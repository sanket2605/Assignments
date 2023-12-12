package mypack;

import org.springframework.context.support.ClassPathXmlApplicationContext;

public class MyApp 
{
	public static void main(String[] args) 
	{ 
        ClassPathXmlApplicationContext appContext=new ClassPathXmlApplicationContext(args[0]);  // dynamically we can configure
        System.out.println("ClassPathXmlApplicationContext instantiated");
        Soldier sol=(Soldier)appContext.getBean("soldier");
        sol.perform();
	}

}
