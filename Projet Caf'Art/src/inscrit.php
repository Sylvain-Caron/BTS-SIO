<?php 

    echo 'Résultat avec PDO';

    $objectPDO = new PDO('mysql:host=localhost;dbname=client','root','');

    //$mysqli = new mysqli('localhost','root','','client');

    $pdoStat = $objectPDO->prepare('SELECT * FROM contact');

    //$resultat = $mysqli->query("SELECT * FROM contact");


    $executeIsOk = $pdoStat->execute();
    
    // Récup des resultats
        
    $contacts = $pdoStat->fetchAll();

    
?>
<html>
    <head>
    </head>
    <body>
        <ul>
            <?php foreach($contacts as $contact): ?>
                
                <li>
                    <?= $contact['nom'] ?> <?= $contact['prenom'] ?> <?= $contact['tel'] ?> <?= $contact['mail'] ?>
                    //Lors de l'affichage on fourni l'id en numContact afin de pouvoir supprimer une personne juste en trouvant l'id voulu
                    <a href='supprimer.php?numContact=<?= $contact['id'] ?>'>Supprimer</a>
                </li>
            
            <?php endforeach; ?>
            
            <?php 
                echo 'Résultat avec MYSQLI :';
            ?>
            <br/>
            <!--<?php
                while($row =$resultat->fetch_assoc())
                {
                    echo 'id = ' . $row['id'] . "\n";
                }
            
            ?>-->
        </ul>
    </body>
</html>