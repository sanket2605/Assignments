

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * Servlet implementation class MainServ
 */
public class MainServ extends HttpServlet 
{
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		String name=request.getParameter("name");
		String password=request.getParameter("password");
		
		if(name.equals("scott") && password.equals("tiger"))
		{	
			RequestDispatcher rd=request.getRequestDispatcher("Welcome.jsp");
			rd.forward(request,response);		
		}
		else
		{
			RequestDispatcher rd=request.getRequestDispatcher("Fail.jsp");
			rd.forward(request,response);
		}
	}

}
