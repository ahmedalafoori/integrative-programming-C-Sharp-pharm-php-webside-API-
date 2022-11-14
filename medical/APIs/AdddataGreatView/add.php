<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
   /* $username=$_POST['name'];
    $password=$_POST['password']; 
	*/

    $sql="insert into users(Name,Password) values('$username','$password')";
    
 /*  
 if(mysqli_query($con,$sql))
    {
        echo "Added successfuly";
    }
    else
    {
        echo  "An error Accured";
    } 
	
	*/

}



?>