<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    
        $usersid = $_POST['id'];
        $usersemail = $_POST['email'];
        $userspassword = $_POST['password'];
        $usersname = $_POST['name'];
		$usersnumber = $_POST['number'];
    

   
   
      $sql = "UPDATE `users` SET `email` = '$usersemail', `password` = ' $userspassword', `name` = '$usersname', `number` = '$usersnumber'  WHERE `users`.`id` =   $usersid;";
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