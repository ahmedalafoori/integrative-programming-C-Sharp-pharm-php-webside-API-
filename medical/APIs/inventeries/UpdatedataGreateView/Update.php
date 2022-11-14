<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    $productid = $_POST['id'];
        $useridsupplier = $_POST['supplier'];
        $username = $_POST['name'];
        $Powerprodect = $_POST['unit'];
        $priceprodect = $_POST['price'];
		$descriptionprodect = $_POST['description'];
        $companyprodect = $_POST['company'];
    

   
   
      $sql = "UPDATE `inventeries` SET `supplier` = '$useridsupplier', `name` = '$username', `unit` = '$Powerprodect', `price` = '$priceprodect', `description` = '$descriptionprodect', `company` = '$companyprodect' WHERE `inventeries`.`id` = $productid;";
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