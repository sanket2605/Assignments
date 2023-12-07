<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Add Student Details</title>
<link rel="stylesheet" href="Student.css">
</head>
<body>
<div class="container">
  <h1>Add Student Details</h1>
  <form action="StudentServ" method="post">
    <div class="form-group">
      <label for="name">Name:</label>
      <input type="text" name="name" id="name" class="form-control" required>
    </div>
    <div class="form-group">
      <label for="age">Age:</label>
      <input type="number" name="age" id="age" class="form-control" min="0" required>
    </div>
    <div class="form-group">
      <label for="address">Address:</label>
      <textarea name="address" id="address" class="form-control" required></textarea>
    </div>
    <button type="submit" class="btn btn-primary">Submit</button>
  </form>
</div>
<footer class="page-footer">
  <p>Copyright &copy; Sanket More, 2023</p>
</footer>
</body>
</html>
