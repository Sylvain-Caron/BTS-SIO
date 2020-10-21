<?php 
    session_start();
    if(isset($_GET['numpost'])){
        $_SESSION['num_post'] = $_GET['numpost'];        
    }
?>
<html>
    <head>
        <meta charset="utf-8" />
        <title>Forum - Page principale</title>
        <link rel="shortcut icon" href="favicon.ico">
		<link rel="stylesheet" type="text/css" href="./css/Discussion.css" media="screen">
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    </head>
 
    
    <body>
    
    <!-- Le menu -->
        
     <?php include("menus.php"); ?>
        
    <br>
    <br>
    
    <!-- Le corps -->
    <center>
        
    <h3>Vous vous trouvez actuellement sur la discussion : </h3>

       
    <?php include("contenu.php"); ?>
        
        

    <!-- La partie commentaire-->    
        
        <form method="POST" action="enregistrement_commentaire.php">
            
            <h6>Écrire un commentaire : </h6>
            <textarea name="com" cols="40" rows="5"></textarea><br><br>   
            <input type="submit" value="Valider">
        </form>
        <br>
        <br>
    
        </center>
    </body>
</html>