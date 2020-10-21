<?php 
    session_start();
?>
<html>
    <head>
        <meta http-equiv="content-type" content="text/html;charset=utf-8" />
         <title>Forum - Page de connexion</title>
        <link rel="stylesheet" type="text/css" href="./css/connectadmin.css" media="screen">
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    </head>
    <body>
        <!--<a href="deco.php">Déconnexion</a> -->       
                <!-- Le menu -->
        
                <?php include("menus.php"); ?>
                <center>
                    <br><br>
                    <div class="container">
	                   <div align="center" style="background-color: purple">
                           <div class="col-xs-12 col-sm-12 col-md-12 col-lg-8">
                               <?php 
                                    if(isset($_SESSION['pseudo']))
                                    {
                                        echo "<center><h1>Bienvenue Admin : <br>". $_SESSION['pseudo'] . "</h1></center>";
                                        
                                    }
                                    else
                                    {
                                ?>
                               <form method="POST" action="loginAdmin.php">
                                    <br>
                                    <h1>CONNEXION ADMINISTRATEUR</h1>
                                    <br>
                                    <label><b>Pseudo Admin:</b></label>
                                    <input type="text" placeholder="Pseudo" name=pseudo_a>
                                    <br><br>
                                    <label><b>Mot de Passe : </b></label>
                                    <input type="password" placeholder="Mot de Passe" name=password_a>
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
                                    <input type="submit"  value="CONNECTION">
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