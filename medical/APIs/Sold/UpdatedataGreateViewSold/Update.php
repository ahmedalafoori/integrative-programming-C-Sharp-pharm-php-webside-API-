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
    

   
   
      $sql = "UPDATE `sold` SET `name` = '$username', `contact` = ' $phoneusername', `discount` = '$discount', `item` = '$prodect', `amount` = '$amount' WHERE `sold`.`id` =  $userid;";
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