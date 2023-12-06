import jakarta.servlet.ServletConfig;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 * Servlet implementation class ViewServ
 */
public class ViewServ extends HttpServlet {
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
		}	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException 
	{
		try {
			response.setContentType("text/html");			
			PreparedStatement pst = conn.prepareStatement("select * from register");
            PrintWriter out=response.getWriter();
			ResultSet rs = pst.executeQuery();
			while(rs.next()) {
				out.println(rs.getObject(1));
				out.print("<br><br>");
				out.println(rs.getObject(2));
				out.print("<br><br>");
				out.println(rs.getObject(3));
				out.print("<br><br>");
				out.println(rs.getObject(4));
				out.print("<br><br>");
				out.println(rs.getObject(5));
				out.print("<br><br>");
			}
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
