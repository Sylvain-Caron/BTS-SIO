<?php 
    session_start();
?>
<html>
    <head>
        <title>Forum - Page d'inscription</title>
        <link rel="stylesheet" type="text/css" href="./css/inscription.css" media="screen">
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    </head>
    <body> 
        <?php 
            if(isset($_SESSION['pseudo']))
            {
                echo "<center><h1>Vous êtes connecté en tant que : " . $_SESSION['pseudo'] . "</h1></center>";
            }
            else
            {
                
                ?>
        
            <!-- Le menu -->
        
            <?php include("menus.php"); ?>
        
            <br><br>
             <div class="container">
	           <div align="center" style="background-color:lightblue">
	               <div class="col-xs-12 col-sm-12 col-md-12 col-lg-8">
                       <?php
                        if(isset($_GET['retour'])){
                            ?>
                       <form>
                           <h1>Merci pour votre inscription</h1>
                       </form>
                            <?php
                        }else{

                        
                ?>
                    <form method="POST" action="inscrit.php">
                        <h1>Inscription</h1>
                        <br>
                        <label><b>Pseudo :</b></label>
                        <input type="text" placeholder="Pseudo" name=pseudo>
                        <br><br>
                        <label><b>Saisir un Mot de Passe :</b></label>
                        <input type="password" placeholder="Mot de Passe" name=password>
                        <br><br>
                        <label><b>Nom :</b></label>
                        <input type="text" placeholder="Nom" name=nom>
                        <br><br>
                        <label><b>Prénom :</b></label>
                        <input type="text" placeholder="Prénom" name=prenom>
                        <br><br>
                        <label><b>Adresse mail : </b></label>
                        <input type="text" placeholder="Adresse Mail" name=mail>
                        <br><br>
                        <input type="submit"  value="VALIDATION">
                        
                    </form>
                       <br><br>
                </div>
            </div>
        </div>
                <?php
            }
            }
        ?>
    </body>
</html>