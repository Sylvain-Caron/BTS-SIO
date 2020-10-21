<?php 
    session_start();
?>
<html>
    <head>
        <meta http-equiv="content-type" content="text/html;charset=utf-8" />
	    <link rel="stylesheet" href="connexion.css"> 
        <link rel="stylesheet" href="dropdown.css"> 
	    <link href="assets/css/bootstrap.css" rel="stylesheet">
        
    </head>
    <body>
        <?php
        if(isset($_SESSION['pseudo']))
        {
            ?>
            <div name="menu">
		      <?php include "menuAdmin.php";?>
	        </div>
            <?php
        }
        else
        {
            ?>
            <div name="menu">
		      <?php include "menu.php";?>
	        </div>
            <?php
        }
        ?>
        
        <?php 
            if(isset($_SESSION['pseudo']))
            {
                echo "<center><h1>Vous êtes connecté en tant que : " . $_SESSION['pseudo'] . "</h1></center>";
            }
            else
            {
                ?>
                <div id="container">
                    <form method="POST" action="login.php">
                        <h1>CONNEXION</h1>

                        <label><b>Nom d'Utilisateur :</b></label>
                        <input type="text" placeholder="Entrer le Nom d'utilisateur" name=pseudo>

                        <label><b>Mot de Passe :     </b></label>
                        <input type="password" placeholder="Entrer le Mot de Passe" name=pass>

                        <input type="submit"  value="SE CONNECTER">

                    </form>
                </div>
            <?php
            }
        ?>
        
    </body>
</html>