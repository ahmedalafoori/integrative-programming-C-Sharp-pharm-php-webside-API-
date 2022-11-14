<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    
        $usersid = $_POST['id'];
        $usersemail = $_POST['email'];
        $userspassword = $_POST['password'];
        $usersname = $_POST['name'];
		$usersnumber = $_POST['number'];
    

   
   
      $sql = "INSERT INTO `users` (`id`, `email`, `password`, `name`, `pic`, `number`, `date`) VALUES (NULL, '$usersemail', '$userspassword', '$usersname', '', '$usersnumber', current_timestamp());";
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