<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    
        $Supplierid = $_POST['id'];
        $usernameSupplier = $_POST['name'];
        $phoneusernameSupplier = $_POST['number'];
        $addressSupplier = $_POST['address'];
		
    

   
   
      $sql = "UPDATE `supplier` SET `name` = '$usernameSupplier', `number` = ' $phoneusernameSupplier', `address` = '$addressSupplier'  WHERE `supplier`.`id` =   $Supplierid;";
        if (mysqli_query($con,$sql))
    {
            echo "Updated Successfully";
        
        
    }
    else
    {
        echo "Sorry, error accured";
    }
    
}
else 
{
    echo "No data enterd :(";
}

?>