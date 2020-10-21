<?php session_start(); ?>
<html>

<head>
	<title>Inscription Client</title>
	<meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<link rel="stylesheet" href="deco.css"> 
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
            <div class="col-lg-12">
                        Liste des Inscrits : <?php include "inscrit.php"; ?>
                <!-- Appel d'inscrit.php qui permet l'affichage des clients -->
            </div> 
        </div>
    </div>
    
</body>

</html>