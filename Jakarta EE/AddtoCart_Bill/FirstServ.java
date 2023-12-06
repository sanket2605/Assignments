import jakarta.servlet.RequestDispatcher;
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
import java.util.*;
/**
 * Servlet implementation class FirstServ
 */
public class FirstServ extends HttpServlet {
	private static final long serialVersionUID = 1L;
    Connection conn;
    List<String> list=new ArrayList<String>();
	/**();
	 * @see Servlet#init(ServletConfig)
	 */
	public void init(ServletConfig config) throws ServletException 
	{
		try 
		{
			Class.forName("com.mysql.cj.jdbc.Driver");
			String ss = "jdbc:mysql://localhost:3306/bit";
			conn = DriverManager.getConnection(ss,"root","vita1234");
		} 
		catch (ClassNotFoundException | SQLException e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		try 
		{
			PreparedStatement pst=conn.prepareStatement("SELECT pname FROM products");
			ResultSet rs=pst.executeQuery();
			while(rs.next())
			{
				list.add(rs.getString("pname"));
			}
			request.setAttribute("pname",list);
			RequestDispatcher rd=request.getRequestDispatcher("Shop.jsp");
			rd.forward(request,response);
			conn.close();	
		} 
		catch (SQLException e) 
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
