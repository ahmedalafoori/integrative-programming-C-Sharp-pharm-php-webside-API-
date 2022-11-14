<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
     $userid = $_POST['id'];

    
    $sql="DELETE FROM `sold` WHERE id = '$userid' ";
   
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