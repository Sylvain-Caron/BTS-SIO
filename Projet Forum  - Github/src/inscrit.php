<?php 
    session_start();
?>
<?php
    // Variable
    if(isset($_SESSION['pseudo']))
    {
       echo "Vous êtes déjà inscrit";
       header ("Refresh: 5;URL=index.php");
    }
    else
    {
        $pseudo = $_POST['pseudo'];
        $password = $_POST['password'];
        $nom = $_POST['nom'];
        $prenom = $_POST['prenom'];
        $mail = $_POST['mail'];

        //Ouverte connexion BD
        $bdd = new PDO('mysql:host=localhost;dbname=forum', 'root', '');

        //hash Password
        $password = password_hash($password, PASSWORD_DEFAULT);
    
        
        $sql = "INSERT INTO users (pseudo, nom, prenom, mail, password, type) VALUES ('$pseudo','$nom','$prenom','$mail','$password','0')";
        $req = $bdd->prepare($sql);
        $req->execute();        
        header('location:inscription.php?retour=1');
    }
?>