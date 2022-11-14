<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
     $productid = $_POST['id'];

    
    $sql="DELETE FROM `inventeries` WHERE `inventeries`.`id` LIKE $productid";
   
    if (mysqli_query($con,$sql))
    {
            echo "Deleted Successfully";
        
        
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