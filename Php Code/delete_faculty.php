<?php


	//catch value & set to a variable

	if(isset($_REQUEST['fac_name'])) {
		$faculty_name = $_REQUEST['fac_name'];  //different name varriable 

			$conn = oci_connect("admin", "admin", "localhost/RPDB");
			$sql= 'BEGIN  del_faculty(:p_fname,:message);END;';
			$stmt = oci_parse($conn,$sql);

			//  Bind the input parameter
			oci_bind_by_name($stmt,':p_fname',$faculty_name,32); #direct assign
			oci_bind_by_name($stmt,':message',$message,32);
			
			// Assign value
			# no need
			
		
			$test = oci_execute($stmt);
			if ($test == true) {
				header('location: view_faculty.php');
			}
			
			else
				echo "$message";
			



	}
	else {
		//header('location: showdata.php');
	}



?>