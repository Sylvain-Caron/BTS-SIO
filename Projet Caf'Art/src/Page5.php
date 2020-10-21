<?php session_start(); ?>
<html>

<head>
	<title>Bootstraps</title>
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
    
	<h1 align="center">Présentation des possibilités avec Bootstraps</h1>
	

	
	
	<div class="container">
		<div class="row">
			<div class="col-lg-4">Largeur 4</div>
			<div class="col-lg-8">Largeur 8</div>
		</div>
		<div class="row">
			<div class="col-lg-1">1 col</div>
			<div class="col-lg-2">2 colonnes</div>
			<div class="col-lg-3">3 colonnes</div>
			<div class="col-lg-6">6 colonnes</div>
		</div>
		<div class="row">
			<div class="col-lg-12">12 colonnes</div>
		</div>
		<div class="row">
			<div class="col-lg-4">4 colonnes</div>
			<div class="col-lg-8">8 colonnes</div>
		</div>
    </div>
    
    <br/>
    
    <div class="container">
		<div class="row">
			<div class="col-lg-12">Container de 3 blocs
				<div class="row">
					<div class="col-lg-3">bloc 1</div>
					<div class="col-lg-6">bloc 2</div>
					<div class="col-lg-3">bloc 3</div>
				</div>
			</div>
		</div>
    </div>
    
    <br/>
    
    <div class="container">
		<div class="row">
			<div class="col-lg-12">Premier Niveau 12 col
			<div class="row">
				<div class="col-lg-8">1er Bloc
				<div class="row">
					<div class="col-lg-6">Groupe de 4</div>
					<div class="col-lg-6">2ème Groupe de 4
						<div class="row">
							<div class="col-lg-3 col-lg-offset-1">Groupe de 2</div>
							<div class="col-lg-3 col-lg-offset-1">Groupe de 2</div>
						</div>
					</div>	
				</div>
				</div>
				<div class="col-lg-4">2ème bloc
				</div>
			</div>	
			</div>
		</div>	
    </div>
    
    <BR/>
    <BR/>
    
    <div class="container">
		<div class="row">
			<div class="col-lg-12">12 COLONNES</div>
		</div>
    </div>
    
    <br/>
   
	
</body>

</html>
