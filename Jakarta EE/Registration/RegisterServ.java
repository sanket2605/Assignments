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
import java.sql.SQLException;

/**
 * Servlet implementation class RegisterServ
 */
public class RegisterServ extends HttpServlet 
{
	private static final long serialVersionUID = 1L;
	private Connection conn;
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
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		try 
		{
			PreparedStatement pst=conn.prepareStatement("insert into register values(?,?,?,?,?)");
			String name=request.getParameter("name");
			pst.setString(1,name);
			
			String address=request.getParameter("address");
			pst.setString(2,address);
			
			String email=request.getParameter("email");
			pst.setString(3,email);
			
			String userid=request.getParameter("userid");
			pst.setString(4,userid);
			
			String password=request.getParameter("password");
			System.out.println(password);
			pst.setString(5,password);
			
			int val=pst.executeUpdate();
			if(val>0)
			{
				System.out.println("Records Inserted are : "+val);
			}
			else
			{
				System.out.println("Records not Inserted");
			}
		} 
		catch (SQLException e) 
		{
			e.printStackTrace();
		}
		
	}

}
