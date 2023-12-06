import jakarta.servlet.ServletConfig;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * Servlet implementation class LoginServ
 */
@WebServlet("LoginServ")
public class LoginServ extends HttpServlet 
{
	private static final long serialVersionUID = 1L;
	Connection conn;
	/**
	 * @see Servlet#init(ServletConfig)
	 */
	public void init(ServletConfig config) throws ServletException 
	{
		String ss="jdbc:mysql://localhost:3306/Bit";
		try 
		{
			Class.forName("com.mysql.cj.jdbc.Driver");
			conn=DriverManager.getConnection(ss,"root","vita1234");
		} 
		catch (SQLException | ClassNotFoundException e) 
		{
			e.printStackTrace();
		}	
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException
	{
		try {
			PreparedStatement pst = conn.prepareStatement("Select * from Register where UserId=? and Password=?");
			pst.setString(1, request.getParameter("userId"));
			pst.setString(2, request.getParameter("password"));
			ResultSet rs = pst.executeQuery();
			System.out.println(rs);
			
			if(rs.next()) 
			{
			  response.sendRedirect("Success.html");
			}
			else 
			{
			  response.sendRedirect("Fail.html");
			}
			

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
