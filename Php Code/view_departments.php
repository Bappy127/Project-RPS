

<!DOCTYPE html>
<html>
<head>
	<title>Departments Page</title>
</head>
<body>

	<?php 

		if(isset($_REQUEST['fac_name'])) {
			$faculty_name = $_REQUEST['fac_name']; 
		}

	?>

	<center>

		<h2>View <?php echo "$faculty_name " ?>Department</h2>	
		<br>


	<table border="1" cellspacing="0" cellpadding="5">
		<tr>
			<th>Serial No</th>
			<th>Department Name</th>
			<th>Department Abbreviation</th>
			<th>Department Code</th>
			<th>Action</th>
		</tr>

		<?php 

			$conn = oci_connect("admin", "admin", "localhost/RPDB");

			$curs = oci_new_cursor($conn);

			//$query = 'select rownum,fac_name from faculty';
			$query = "BEGIN view_departments(:dept_view_cursor); END;";

			$stid = oci_parse($conn, $query);
			oci_bind_by_name($stid,':dept_view_cursor',$curs,-1, OCI_B_CURSOR);
			oci_execute($stid);


			oci_execute($curs);  // Execute the REF CURSOR like a normal statement id
						
			while ($row = oci_fetch_array($curs, OCI_RETURN_NULLS+OCI_ASSOC)) {
			
		?>
			
			<tr>
			
				<td><?php echo $row['ROWNUM']; ?></td>
				<td><?php echo $row['DEPT_NAME']; ?></td>
				<td><?php echo $row['DEPT_ABBR']; ?></td>
				<td><?php echo $row['DEPT_CODE']; ?></td>
					
				<td>
					<a href="insert_departments.php?fac_name=<?php echo $row['FAC_NAME']; ?>">Insert</a>&nbsp;|&nbsp;

					<a href="view_departments.php?fac_name=<?php echo $row['FAC_NAME']; ?>">View</a>&nbsp;|&nbsp;

					<a href="update_departments.php?dept_name=<?php echo $row['DEPT_NAME']; ?>&amp;fac_name=<?php echo $faculty_name ;  ?>">Update</a>&nbsp;|&nbsp;

					<a onclick="return confirm_delete();" href="delete_departments.php?dept_name=<?php echo $row['DEPT_NAME']; ?>" ">Delete</a>
					
				</td>
			</tr>
			
		<?php

			}
		
			

		?>
		
		
	</table>

		<br>
		<button onclick="window.location.href='insert_departments.php?fac_name=<?php echo $faculty_name; ?>' ">Insert Department</button>
		<button onclick="window.location.href='view_faculty.php'">Back</button>
		
	</center>


</body>
</html>
