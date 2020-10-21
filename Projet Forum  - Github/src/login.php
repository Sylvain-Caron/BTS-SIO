<?php 
    session_start();
    
    //Récupération du pseudo et MDP
    $pseudo = $_POST['pseudo'];
    $password = $_POST['password'];
    
    // connexion BD
    $bdd = new PDO('mysql:host=localhost;dbname=forum', 'root', '');

    //Requète
    $sql =$bdd->query("SELECT password FROM users WHERE pseudo = '$pseudo'");
    $sql = $sql->fetch();
    //var_dump($result);
    // Si le résultat est positif alors on vérifie si mdp correspond à celui de la BD
    if($sql!="")
    {
        //var_dump($password);        
        if(password_verify($password, $sql[0]))
        {
            // On affiche un message comme quoi il est bien connecté 
            //var_dump($password);
            $_SESSION['pseudo'] = $pseudo;
            $_SESSION['id'] = $bdd->query("SELECT Id FROM users WHERE pseudo = '$pseudo'")->fetch()[0];
            header('location:connect.php?');
        }else{
            header('location:connect.php?retour=1');
        }
    }
    else
    {
        header('location:connect.php?retour=1');
    }
?>
