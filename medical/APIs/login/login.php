<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    $useremail=$_POST['email'];
    $password=$_POST['password'];
    
    $sql="select email,Password from users where email='$useremail' and Password='$password' ";
    $query=mysqli_query($con,$sql);

    if (mysqli_num_rows($query)>0)
    {
        echo "1"; 
    }
    else
    {
        echo "Sorry, you are not registered yet";
    }
}
else 
{
    echo "No data enterd :(";
}

?>