<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    $Supplierid = $_POST['id'];

    
    $sql="DELETE FROM `supplier` WHERE id = '$Supplierid' ";
   
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