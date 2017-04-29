
<?php


		//catch value & set to a variable

		if(isset($_REQUEST['fac_name'])) {
			$f_name = $_REQUEST['fac_name'];  //different name varriable 
		}
		else {
			header('location: view_faculty.php');
		}





		if(isset($_POST['form_faculty_update']))
		{
			

			try
			{
				if(empty($_POST['faculty_new_name'])) {
					throw new Exception('Faculty name can not be empty');
				}

				

				
				$faculty_new_name = $_POST["faculty_new_name"];
				
				
				$conn = oci_connect("admin", "admin", "localhost/RPDB");


				
				$sql= 'BEGIN  update_faculty(:p_name,:p_oname,:message);END;';

				$stmt = oci_parse($conn,$sql);


				//  Bind the input parameter
				oci_bind_by_name($stmt,':p_oname',$fac_old_name,32);
				oci_bind_by_name($stmt,':p_name',$fac_new_name,32);
				oci_bind_by_name($stmt,':message',$message,32);


				
				// Assign a value to the input 
				
				$fac_new_name = $faculty_new_name;
				$fac_old_name = $f_name;
				


				
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
	<title>Procedure Page</title>
</head>
<body>


<br>


<center>
<form action="" method="POST">
<table>
	
	<tr>
		<td>Faculty old name: </td>
		<td><input type="text" name="faculty_old_name" value="<?php echo $f_name; ?>"></td>
	</tr>

	<tr>
		<td>Faculty new name: </td>
		<td><input type="text" name="faculty_new_name"></td>
	</tr>
	
	<tr>
		<td></td>
		<td><input type="submit" value="Update" name="form_faculty_update"></td>
	</tr>
	
</table>


<input type="hidden" name="faculty_old_name" value="<?php echo $f_name; ?>">

</form>

<br>
<button onclick="window.location.href='home.php'">Back 2 main page</button>

</center>



</body>
</html>