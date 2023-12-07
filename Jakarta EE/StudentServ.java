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
 * Servlet implementation class StudentServ
 */
public class StudentServ extends HttpServlet 
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
			PreparedStatement pst=conn.prepareStatement("insert into student(name,age,address) values(?,?,?)");
			String name=request.getParameter("name");
			pst.setString(1,name);
			
			String age=request.getParameter("age");
			pst.setString(2,age);
			
			String address=request.getParameter("address");
			pst.setString(3,address);
			
			int val=pst.executeUpdate();
			if(val>0)
			{
				System.out.println("Records Inserted are : "+val);
			}
			else
			{
				System.out.println("Records not Inserted");
			}
			
			List<String> list=new ArrayList<String>();
			PreparedStatement pst1=conn.prepareStatement("select rollno from student ");
			ResultSet rs=pst1.executeQuery();
			while(rs.next())
			{
				list.add(rs.getString("rollno"));
			}
			request.setAttribute("rollno",list);
			RequestDispatcher rd=request.getRequestDispatcher("Report.jsp");
			rd.forward(request,response);
		} 
		catch (SQLException e) 
		{
			e.printStackTrace();
		}
		
	}

}
