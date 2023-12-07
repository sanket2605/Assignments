

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import mypack.CareerExpert;

/**
 * Servlet implementation class CareerServ
 */
public class CareerServ extends HttpServlet 
{
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		CareerExpert c=new CareerExpert();
		String adv= c.getAdvice(request.getParameter("ql"));
		RequestDispatcher rd = request.getRequestDispatcher("CareerDetails.jsp");
		request.setAttribute("advice",adv);
		rd.forward(request, response);
		}
}
