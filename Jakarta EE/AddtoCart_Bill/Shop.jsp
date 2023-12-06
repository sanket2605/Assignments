<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<h1><i> Product names </i></h1><br>

<form action="SecondServ" method=post>
<c:forEach var="str" items="${requestScope.pname}">
	<input type=checkbox name=ch value=${str}>${str}<br>
</c:forEach>
<input type=submit value="Add to Cart">
</form>
