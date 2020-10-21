<?php
    session_start();
    try{
        $bdd = new PDO('mysql:host=localhost;dbname=forum', 'root', '');
    }
    catch(Exception $e){
            die('Erreur : '.$e->getMessage());
    }
    $com=$_POST['com'];
    $numpost=$_SESSION['num_post'];
    $id=$_SESSION['id'];
    $bdd->exec("INSERT INTO messages (commentaire,vues,id_users,num_post) VALUES('".$com."',0,'".$id."','".$numpost."')");
    header('location:Discussion.php');
?>