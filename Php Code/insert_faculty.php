
<?php

if(isset($_POST['form_faculty_insert']))
{
	

	try
	{
		if(empty($_POST['faculty_name'])) {
			throw new Exception('Faculty name can not be empty');
		}



		$faculty_name = $_POST["faculty_name"];

		$conn = oci_connect("admin", "admin", "localhost/RPDB");


		$sql= 'BEGIN  insert_faculty(:p_name,:message);END;';

		$stmt = oci_parse($conn,$sql);


		//  Bind the input parameter
		oci_bind_by_name($stmt,':p_name',$fac_name,64);
		
		// Bind the output parameter
		oci_bind_by_name($stmt,':message',$message,64);

		// Assign a value to the input 
		$fac_name = $faculty_name;
		


		$test = oci_execute($stmt);
		if ($test == true)
		{
			header("location:view_faculty.php");
		}
		else
			echo "$message";
	
	}
	catch(Exception $e) {
		$error_message = $e->getMessage();
	}



}	
	
?>







<!doctype html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Insert Page</title>
</head>
<body>


<br>
<center>
<form action="" method="post">
<table>
	<tr>
		<td>Faculty name: </td>
		<td><input type="text" name="faculty_name"></td>
	</tr>
	
	<tr>
		<td></td>
		<td><input type="submit" value="Insert" name="form_faculty_insert"></td>
	</tr>
	
</table>
</form>


<br>
<button onclick="window.location.href='view_faculty.php'"> Back </button>
<button onclick="window.location.href='home.php'">Back 2 main page</button>

</center>
</body>
</html>