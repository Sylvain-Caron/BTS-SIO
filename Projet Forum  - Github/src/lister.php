<?php
//Ouverture de la base de données
$objetPdo = new PDO('mysql:host=localhost;dbname=forum','root', '');

//Préparation de la requete 
$pdoStat = $objetPdo->prepare('SELECT * FROM posts');


//Execution de la requete

$executionreussie = $pdoStat->execute();

//On récupère les resulats

$posts = $pdoStat->fetchAll();

?>

<html>
<head>

    
</head>
<body>

    
    <?php  foreach($posts as $post): ?>
    
    <li>
        
        <div class="container">
	           <div align="center" style="background-color:D2D4FF">
	               <div class="col-xs-12 col-sm-12 col-md-12 col-lg-8"><br>
                    <a href="Discussion.php?numpost=<?= $post['num_post']?>">Acceder</a>
                        <h5>Titre :</h5><h6><?= $post['titre_post'] ?></h6>
                       <h5>Commentaire :</h5><h6><?= $post['commentaire'] ?></h6>
                    <h5>Vues :</h5><h6><?= $post['vues'] ?></h6>
                        <br>
                        </div>
                     </div>
                </div>
    </li>
    
    <?php endforeach ?>
    
    
</body>
</html>