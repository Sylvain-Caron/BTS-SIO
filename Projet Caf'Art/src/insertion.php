<?php
    //Ouverture d'une connexion à la BD client

    $objectPDO = new PDO('mysql:host=localhost;dbname=client','root','');
    //$mysqli = new mysqli('localhost','root','','client');


    // Préparer la requète insertion (SQL)
    
    $pdoStat = $objectPDO->prepare('INSERT INTO contact VALUES (NULL, :nom, :prenom, :tel, :mail)');


    //$sql = "INSERT INTO contact (nom, prenom, tel, mail) VALUES( ?, ?, ?, ?)";
    
    //$stmt = mysqli_prepare($mysqli,$sql);
    
    //$stmt->bind_param("ssss",$_POST['nom'],$_POST['prenom'],$_POST['tel'],$_POST['mail']);

    //On lie chaque marqueur à une valeur
    
    $pdoStat->bindValue(':nom', $_POST['nom'], PDO::PARAM_STR);
    $pdoStat->bindValue(':prenom', $_POST['prenom'], PDO::PARAM_STR);
    $pdoStat->bindValue(':tel', $_POST['tel'], PDO::PARAM_STR);
    $pdoStat->bindValue(':mail', $_POST['mail'], PDO::PARAM_STR);
    
    
        
    
    //Execution de la req
        
    //$stmt->execute();
        
    $insertIsOk = $pdoStat->execute();
    if($insertIsOk)
    {
        $message = 'Client ajouter';
    }
    else
    {
        $message =  'Echec';
    }
    
    //$mysqli->close();
?>

<!doctype html>

<html>
    <head>
    
    </head>
    <body>
        <h1>Insertion des clients</h1>
        
        <p><?php //echo $message; ?></p>
        
        <a href='Page7.php'>Retour</a>
    </body>
    
</html>