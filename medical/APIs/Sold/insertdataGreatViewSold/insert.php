<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    
        $userid = $_POST['id'];
        $username = $_POST['name'];
        $phoneusername = $_POST['contact'];
        $discount = $_POST['discount'];
		$prodect = $_POST['item'];
        $amount = $_POST['amount'];
    

   
   
      $sql = "INSERT INTO `sold` (`id`, `name`, `contact`, `discount`, `item`, `amount`, `userId`, `date`) VALUES (NULL, '$username', '$phoneusername', '$discount', '$prodect', '$amount', '', current_timestamp());";
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