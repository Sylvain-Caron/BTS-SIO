<?php
session_start();
//Ouverture d'une connexion à la BD forum
$objetPdo = new PDO('mysql:host=localhost;dbname=forum','root', '');

//Preparation de la requete
$pdoStat = $objetPdo->prepare('DELETE FROM messages WHERE num_message=:numero LIMIT 1'); //Suppression limité à un ligne


//Liaison du parametre nommé

$pdoStat->bindValue(':numero', $_GET['num_Message'], PDO::PARAM_INT);

//Execution de la requete

$executeIsOk = $pdoStat->execute();

//Vérification

if($executeIsOk)
{
    $message ="Le message à été supprimé";
    header("refresh:2;url=Discussion.php");
}

else
{
    $message = "Echec de la supression du message";
}
?>
<html>
<body>

<h1>Suppression</h1>    
    
<p><?= $message ?></p>
 
</body>
</html>