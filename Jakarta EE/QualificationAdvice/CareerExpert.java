package mypack;

public class CareerExpert 
{
	public String getAdvice(String qualification) {
		if(qualification.equalsIgnoreCase("be")) {
				return "Nahi Karna Tha";
		}else 
			if(qualification.equalsIgnoreCase("12th Pass"))
			{
				return "Engineering hi Karlo";
			}
			else 
				if(qualification.equalsIgnoreCase("BSC"))
				{
					return "Prepare for UPSC";
				}
				else
					return "no choice";	
	}

}
