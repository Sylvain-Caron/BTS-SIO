<?php 
    session_start();
    
    //Récupération du pseudo et MDP
    $pseudo = $_POST['pseudo'];
    $pass = $_POST['pass'];
    
    // connexion BD
    $bdd = new PDO('mysql:host=localhost;dbname=client', 'root', '');
    //Requète
    $sql = "SELECT * FROM user WHERE pseudo = '$pseudo'";
    $result = $bdd->prepare($sql);
    $result->execute();
    
    var_dump($result);
    // Si le résultat est positif alors on vérifie si mdp correspond à celui de la BD
    if($result->rowCount() > 0)
    {
        var_dump($pass);
        $data = $result->fetchAll();
        
        if(password_verify($pass, $data[0]['password']))
        {
            // On affiche un message comme quoi il est bien connecté 
            var_dump($pass);
            echo "Connexion effectué";
            $_SESSION['pseudo'] = $pseudo;
        }
    }
    else // Sinon on créé un Admin avec le pseudo et le MDP entrée 
    {
            $pass = password_hash($pass, PASSWORD_DEFAULT);
            $sql = "INSERT INTO user (pseudo, password) VALUES ('$pseudo','$pass')";
            $req = $bdd->prepare($sql);
            $req->execute();
            echo "Enregistrement Effectué ";
    }
    
   
    






   /*
    $bdd= new PDO('mysql:host=localhost;dbname=client','root','');
    
    $req = $bdd->prepare('SELECT id, mdp FROM admin WHERE pseudo = :pseudo');
        
    $req->execute(array('pseudo'=>$pseudo));

    $resultat = $req->fetch();
    
    $mdpIsCorrect = password_verify($_POST['mdp'], $resultat['mdp']);

    if(!$resultat)
    {
        echo 'Mauvais identifiant ou mot de passe  !';
    }
    else
    {
        if($mdpIsCorrect)
        {
            session_start();
            $_SESSION['id'] = $resultat['id'];
            $_SESSION['pseudo'] = $pseudo;
            echo 'Vous êtes connecté !';
        }
        else
        {
            echo 'Mauvais identifiant ou mot de passe !';
        }
    }

    //TEST TEST TEST

    $Pseudo = $_POST['pseudo'];
    $MotDePasse = $_POST['mdp'];

    //on se connecte à la base de données:
    $mysqli = mysqli_connect('localhost','root','','client');

    //on vérifie que la connexion s'effectue correctement:
    if(!$mysqli)
    {
        echo "Erreur de connexion à la base de données.";
    } 
    else 
    {
        // on fait maintenant la requête dans la base de données pour rechercher si ces données existe et correspondent:
        $Requete = mysqli_query($mysqli,"SELECT * FROM membres WHERE pseudo = '".$Pseudo."' AND mdp = '".$MotDePasse."'");
        //si vous avez enregistré le mot de passe en md5() il vous suffira de faire la vérification en mettant mdp = '".md5($MotDePasse)."' au lieu de mdp = '".$MotDePasse."'
        // si il y a un résultat, mysqli_num_rows() nous donnera alors 1
        // si mysqli_num_rows() retourne 0 c'est qu'il a trouvé aucun résultat
        
        if(mysqli_num_rows($Requete) == 0) {
            echo "Le pseudo ou le mot de passe est incorrect, le compte n'a pas été trouvé.";
        } else {
            // on ouvre la session avec $_SESSION:
            $_SESSION['pseudo'] = $Pseudo; // la session peut être appelée différemment et son contenu aussi peut être autre chose que le pseudo
            echo "Vous êtes à présent connecté !";
        }
    }
    */

?>