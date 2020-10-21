<?php

//ouverture d'une connexion à la bdd forum

$objetPdo = new PDO('mysql:host=localhost;dbname=forum', 'root', '');

//Préparation de la requete

$pdoStat = $objetPdo->prepare('SELECT * FROM messages WHERE num_post='.$_SESSION['num_post'].'');


//Execution

$executionreussie = $pdoStat->execute();

//On récupère les resulats

$msgs = $pdoStat->fetchAll();
//var_dump($msgs);
?>

<html>
<body>
<?php foreach($msgs as $msg): ?>

    <?php $pdoStatis = $objetPdo->prepare('SELECT pseudo FROM users WHERE Id='.$msg['id_users'].'');
    
    $execution = $pdoStatis->execute();
    
    $pseudo = $pdoStatis->fetch();
    ?>
    
     <li>
        
        <div class="container">
	           <div align="center" style="background-color:D2D4FF">
	               <div class="col-xs-12 col-sm-12 col-md-12 col-lg-8"><br>
                        
                    <h6><?= $pseudo['pseudo'] ?></h6>
                    <h6><?= $msg['commentaire'] ?></h6> <?php
                    if(isset($_SESSION['pseudo'])){
                        try{
                            $bdd = new PDO('mysql:host=localhost;dbname=forum', 'root', '');
                        }
                        catch(Exception $e){
                            die('Erreur : '.$e->getMessage());
                        }
                        $type =$bdd->query('SELECT type FROM users where Id='.$_SESSION['id']);
                        $type=$type->fetch();
                        if($type[0]=="Admin"){
                ?>
                <a href="supprimer.php?num_Message=<?= $msg['num_message']?>" name='lien'>Supprimer</a>
                <?php
                    }
                }
                ?>
                        <br>
                        </div>
                     </div>
                </div>
    </li>
    
<?php endforeach ?>

</body>
</html>