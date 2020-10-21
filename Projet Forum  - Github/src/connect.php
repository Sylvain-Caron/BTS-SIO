<?php 
    session_start();
?>
<html>
    <head>
        <meta http-equiv="content-type" content="text/html;charset=utf-8" />
         <title>Forum - Page de connexion</title>
        <link rel="stylesheet" type="text/css" href="./css/connexion.css" media="screen">
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    </head>
    <body>
        <a href="deco.php">Déconnexion</a>       
                <!-- Le menu -->
        
                <?php include("menus.php"); ?>
                <center>
                    <br><br>
                    <div class="container">
	                   <div align="center" style="background-color: #05073F">
                           <div class="col-xs-12 col-sm-12 col-md-12 col-lg-8">
                               <?php 
                                    if(isset($_SESSION['pseudo']))
                                    {
                                        echo "<center><h1>Vous êtes connecté en tant que : <br>". $_SESSION['pseudo'] . "</h1></center>";
                                        
                                    }
                                    else
                                    {
                                ?>
                               <form method="POST" action="login.php">
                                    <br>
                                    <h1>CONNEXION</h1>
                                    <br>
                                    <label><b>Nom d'Utilisateur :</b></label>
                                    <input type="text" placeholder="Entrer le Nom d'utilisateur" name=pseudo>
                                    <br><br>
                                    <label><b>Mot de Passe :     </b></label>
                                    <input type="password" placeholder="Entrer le Mot de Passe" name=password>
                                    <br><br>
                                    <?php
                                    if(isset($_GET['retour'])){
                                        if($_GET['retour']==1){
                                    ?>
                                        <label><b>Erreur de saisie</b></label><br><br>
                                            <?php
                                        }
                                    }
                                    ?>
                                    <input type="submit"  value="SE CONNECTER">
                                    <br><br>
                                </form>
                           </div>    
                        </div>
                    </div>
                </center>
            <?php
            }
            
        ?>
        
    </body>
</html>