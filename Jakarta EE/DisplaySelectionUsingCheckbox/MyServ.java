

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;

/**
 * Servlet implementation class MyServ
 */
public class MyServ extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		String selection=request.getParameter("module");
		
		if(selection.equals("java"))
		{
			RequestDispatcher rd=request.getRequestDispatcher("j2va.jsp");
			rd.forward(request,response);
		}
		else if(selection.equals("c++"))
		{
			RequestDispatcher rd=request.getRequestDispatcher("cplus.jsp");
			rd.forward(request,response);
		}
		else
		{
			RequestDispatcher rd=request.getRequestDispatcher("ora.jsp");
			rd.forward(request,response);
		}
	}

}
