<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','store');
    
    if($_POST['requesttype'] == 'select')
    {
        $sql="SELECT `id`, `name`, `number`, `address`, `date` FROM `supplier`  ";
        $query=mysqli_query($con,$sql);
        $xml = new SimpleXMLElement('<Menus/>');
    
        if (mysqli_num_rows($query)>0)
        {
                while($row = mysqli_fetch_assoc($query)){
                $Men = $xml->addChild('inventeries');
            
                foreach ($row as $key => $value) {
                $Men->addChild($key, $value);
                }
            }
            echo $xml->asXML();
        }
        else
        {
            echo "Sorry, No food in this inventeries";
        }
	}
   

   
   /*
    else if($_POST['requesttype'] == 'update')
    {
		$productid = $_POST['id'];
        $useridsupplier = $_POST['supplie'];
        $username = $_POST['name'];
        $Powerprodect = $_POST['unit'];
        $priceprodect = $_POST['price'];
		$descriptionprodect = $_POST['description'];
        $companyprodect = $_POST['company'];

        $sql = "UPDATE `inventeries` SET `supplier`='$useridsupplier', `name`='$username', `unit`='$Powerprodect', `price`='$priceprodect',`description`='$descriptionprodect',`company`='$companyprodect', WHERE `inventeries`.`id` = $id";
        if(mysqli_query($con,$sql))
        {
            echo "Updated Successfully...";
        }
        else 
        {
            echo "Couldn't update...";
        }
		

    
    }else if($_POST['requesttype'] == 'delete')
    {
        $id = $_POST['id'];

        $sql = "DELETE FROM `menu` WHERE `menu`.`id` = $id";
        if(mysqli_query($con,$sql))
        {
            echo "deleted Successfully...";
        }
        else 
        {
            echo "Couldn't delete...";
        }
    
    }
    else if($_POST['requesttype'] == 'insert')
    {
        $name = $_POST['name'];
        $price = $_POST['price'];
        $type = $_POST['type'];
        $sql = "INSERT INTO `menu` (`id`, `Food_name`, `Price`, `Type`) VALUES (NULL, '$name', '$price', '$type');";
        if(mysqli_query($con,$sql))
        {
            echo "inserted Successfully...";
        }
        else 
        {
            echo "Couldn't insert...";
        }
    
    }
   
    
}
else 
{
    echo "No data enterd :(";
}

*/
}
?>