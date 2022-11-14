<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    
      $Supplierid = $_POST['id'];
        $usernameSupplier = $_POST['name'];
        $phoneusernameSupplier = $_POST['number'];
        $addressSupplier = $_POST['address'];
    

   
   
      $sql = "INSERT INTO `supplier` (`id`, `name`, `pic`, `number`, `address`, `cnic`, `date`) VALUES (NULL, '$usernameSupplier', '', '$phoneusernameSupplier', '$addressSupplier', '', current_timestamp());";
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