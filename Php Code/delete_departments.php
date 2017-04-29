<?php


//catch value & set to a variable

	if(isset($_REQUEST['dept_name'])) {
		$d_name = $_REQUEST['dept_name'];  //different name varriable 

			$conn = oci_connect("admin", "admin", "localhost/RPDB");
			$sql= 'BEGIN  del_departments(:p_dname,:message);END;';
			$stmt = oci_parse($conn,$sql);

			//  Bind the input parameter
			oci_bind_by_name($stmt,':p_dname',$d_name,32); #...direct assign...
			oci_bind_by_name($stmt,':message',$message,32);
			
			// Assign value
			#..no need..
			
		
			$test = oci_execute($stmt);
			if ($test == true)
			{
				header('location: view_departments.php');

			}
			else
				echo "$message";
			
	}
	else {
		
			echo "Something Wrong!!!";
		}



?>