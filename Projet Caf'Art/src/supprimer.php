<?php

    //Connexion
    $objectPDO = new PDO('mysql:host=localhost;dbname=client','root','');

    //Requete de suppression
    $pdoStat = $objectPDO->prepare('DELETE FROM contact WHERE id=:num LIMIT 1');

    //Liaison du paramettre 

    $pdoStat->bindValue(':num', $_GET['numContact'], PDO::PARAM_INT);

    //Execution
    $executeIsOk = $pdoStat->execute();
    
    if($executeIsOk)
    {
        $message = 'Supprimer !';
    }
    else
    {
        $message = 'Echec';
    }

?>

<html>
    <body>
    
        <h1>Suppression</h1>
        
        <p><?= $message ?></p>
        
    </body>
</html>