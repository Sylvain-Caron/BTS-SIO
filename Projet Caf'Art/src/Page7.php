<?php session_start(); ?>
<html>

<head>
	<title>Inscription Client</title>
	<meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<link rel="stylesheet" href="deco.css"> 
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
    
	<div class="container">
		<div class="row">
			<div class="col-lg-12"> <h1>Inscription</h1>
                <!-- Appel d'insertion.php qui permet d'insérer un client -->
                <form action="insertion.php" method="post"> 
                    <div>
                        Prénom :
                        <input type="text" name="prenom">
                        <br/>
                        Nom :
                        <input type="text" name="nom">
                    </div>
                    <br/>
                    <div>
                        Tel :
                        <input type="text" name="tel">
                    </div>
                    <br/>
                    <div>
                        Mail :
                        <input type="text" name="mail">
                    </div>
                    <br/>
                    <input type="submit" value="Enregistrer"> 
                                      
                </form>
                
            </div>
        </div>
    </div>
    

	
	

	
</body>

</html>