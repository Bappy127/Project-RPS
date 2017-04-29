<?php


		if(isset($_REQUEST['dept_name'])) {
				$p_doname = $_REQUEST['dept_name'];  //different name varriable 
			}
			//echo "$p_doname"."<br>";

		if(isset($_REQUEST['fac_name'])) {
				$p_fac_name = $_REQUEST['fac_name']; 
			}

			//echo $p_fac_name;
	
		if(isset($_POST['form_Department_update']))
		{
			

			try
			{
				if(empty($_POST['Department_name'])) {
					throw new Exception('Department name can not be empty');
				}
				if(empty($_POST['Department_abbr'])) {
					throw new Exception('Department Abbreviation can not be empty');
				}

				if(empty($_POST['Department_code'])) {
					throw new Exception('Department code can not be empty');
				}



				
				$department_name_new = $_POST["Department_name"];
				$department_abbr_new = $_POST["Department_abbr"];
				$department_code_new = $_POST["Department_code"];

				

				
				$conn = oci_connect("admin", "admin", "localhost/RPDB");

				$sql= 'BEGIN  update_departments(:p_dname,:p_doname,:p_dabbr,:p_dcode,:p_fac_name,:message);END;';

				$stmt = oci_parse($conn,$sql);


				//  Bind the input parameter
				oci_bind_by_name($stmt,':p_dname',$dept_new_name,32);
				oci_bind_by_name($stmt,':p_doname',$dept_old_name,32);
				oci_bind_by_name($stmt,':p_dabbr',$dept_new_abbr,32);
				oci_bind_by_name($stmt,':p_dcode',$dept_new_code,32);
				oci_bind_by_name($stmt,':p_fac_name',$dept_fac_name,32);
				oci_bind_by_name($stmt,':message',$message,32);


				
				// Assign a value to the input 
				
				$dept_new_name = $department_name_new;
				$dept_old_name = $p_doname;
				$dept_new_abbr = $department_abbr_new;
				$dept_new_code = $department_code_new;
				$dept_fac_name = $p_fac_name;

				
				


				
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


<!DOCTYPE html>
<html>
<head>
	<title>Update Department Page</title>
</head>
<body>



	<!-- For selecting procedure-->

	<?php
		
		$conn = oci_connect("admin", "admin", "localhost/RPDB");
			
		$sql= 'BEGIN  select_departments(:p_dname,:p_dabbr,:p_dcode,:message);END;';

		$stmt = oci_parse($conn,$sql);



		//  Bind the input parameter
		oci_bind_by_name($stmt,':p_dname',$dept_name,64);
		oci_bind_by_name($stmt,':p_dabbr',$dept_abbr,64);
		oci_bind_by_name($stmt,':p_dcode',$dept_code,64);
		oci_bind_by_name($stmt,':message',$message,64);

		// Assign value
		$dept_name == $p_doname;
						
	?>







	<center>
	<h2>Update </h2>
		<form action="" method="post">
			<table>
				<tr>
					<td>Department name: </td>
					<td><input type="text" name="Department_name" value="<?php echo $dept_name; ?>"></td>
				</tr>

				<tr>
					<td>Deaprtment Abbreviation: </td>
					<td><input type="text" name="Department_abbr" value="<?php echo $dept_abbr; ?>"></td>
				</tr>

				<tr>
					<td>Deaprtment code: </td>
					<td><input type="text" name="Department_code" value="<?php echo $dept_code; ?>"></td>
				</tr>
					
				<tr>
					<td></td>
					<td><input type="submit" value="Update" name="form_Department_update"></td>
				</tr>
				
			</table>
		</form>

		<button onclick="window.location.href='home.php'">Back 2 main page</button>

	</center>


</body>
</html>