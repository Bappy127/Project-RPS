
<?php

	if(isset($_REQUEST['fac_name'])) {
			$p_fac_name = $_REQUEST['fac_name'];  //different name varriable 
		}

		



	if(isset($_POST['form_Department_insert']))
	{
		

		try
		{
			if(empty($_POST['Department_name'])) {
				throw new Exception('Faculty name can not be empty');
			}

			if(empty($_POST['Department_abbr'])) {
				throw new Exception('Faculty name can not be empty');
			}

			if(empty($_POST['Department_code'])) {
				throw new Exception('Faculty name can not be empty');
			}





			$Department_name= $_POST["Department_name"];
			$Department_abbr= $_POST["Department_abbr"];
			$Department_code= $_POST["Department_code"];

			
			$conn = oci_connect("admin", "admin", "localhost/RPDB");


			//$sql = 'BEGIN sayHello(:name, :message); END;';
			$sql= 'BEGIN  insert_departments(:p_dname,:p_dabbr,:p_dcode,:p_fac_name,:message);END;';

			$stmt = oci_parse($conn,$sql);


			//  Bind the input parameter
			oci_bind_by_name($stmt,':p_dname',$dept_name,64);
			oci_bind_by_name($stmt,':p_dabbr',$dept_abbr,64);
			oci_bind_by_name($stmt,':p_dcode',$dept_code,64);
			oci_bind_by_name($stmt,':p_fac_name',$dept_fname,64);
			oci_bind_by_name($stmt,':message',$message,64);
			
			

			// Assign a value to the input 
			
			$dept_name = $Department_name;
			$dept_abbr = $Department_abbr;
			$dept_code = $Department_code;
			$dept_fname = $p_fac_name;
			
			$test = oci_execute($stmt);
			if ($test == true) {
				header('location:view_departments.php');
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
	<title>Department Page</title>
</head>
<body>
<CENTER><?php echo "Faculty name is = ".$p_fac_name; ?></CENTER>
	<br>
	<center>

		<form action="" method="post">
			<table>
				<tr>
					<td>Department name: </td>
					<td><input type="text" name="Department_name"></td>
				</tr>

				<tr>
					<td>Deaprtment Abbreviation: </td>
					<td><input type="text" name="Department_abbr"></td>
				</tr>

				<tr>
					<td>Deaprtment code: </td>
					<td><input type="text" name="Department_code"></td>
				</tr>
					
				<tr>
					<td></td>
					<td><input type="submit" value="Insert" name="form_Department_insert"></td>
				</tr>
				
			</table>
		</form>

		<button onclick="window.location.href='view_faculty.php'">Back</button>
		<button onclick="window.location.href='home.php'">Back 2 main page</button>

	</center>



</body>
</html>