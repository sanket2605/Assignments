<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
    
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Bill</title>
</head>
<body>
<table border="1">

<c:forEach var="myval" items="${sessionScope.pname}">
<tr>
<td>
${myval}
</td>
</tr>
	</c:forEach>
</body>
</html>
