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
    
    $sql="INSERT INTO `inventeries` (`id`, `catId`, `supplier`, `name`, `unit`, `price`, `pic`, `description`, `company`, `date`) VALUES (NULL, '$productid', '$useridsupplier', '$username', '$Powerprodect', '$priceprodect', '', '$descriptionprodect', '$companyprodect', current_timestamp());
";
   
    if (mysqli_query($con,$sql))
    {
            echo "insert Successfully";
        
        
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