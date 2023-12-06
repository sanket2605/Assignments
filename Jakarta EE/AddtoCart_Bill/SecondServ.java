import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;
import java.io.IOException;
import java.sql.Connection;
import java.util.*;

/**
 * Servlet implementation class SecondServ
 */
public class SecondServ extends HttpServlet 
{
	private static final long serialVersionUID = 1L;     
    /**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		// TODO Auto-generated method stub
		
		String[] name=request.getParameterValues("ch");
		List<String> mystr=new ArrayList<String>();

		for(int i=0;i<name.length;i++) 
		{
			mystr.add(name[i]);
		}
		
		HttpSession session=request.getSession();
		session.setAttribute("pname", mystr);
		response.sendRedirect("Bill.jsp");
	}
}
