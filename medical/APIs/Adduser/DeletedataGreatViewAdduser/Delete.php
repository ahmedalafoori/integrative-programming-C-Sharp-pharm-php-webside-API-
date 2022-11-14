<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    $usersid = $_POST['id'];

    
    $sql="DELETE FROM `users` WHERE id = '$usersid' ";
   
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