<?php session_start(); ?>
<html>

<head>
	<title>Accueil</title>
	<meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<link rel="stylesheet" href="deco.css"> 
    <link rel="stylesheet" href="dropdown.css"> 
	<link href="assets/css/bootstrap.min.css" rel="stylesheet">
	 
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
    
	<div>
		<div>
			<header>
					<div>
						<h1>La Fable</h1> <!-- Gros Titre -->
					</div>
			</header>

		<br/>
		
		
			<section >
				<div class="container">
					<div class="row">
						<div class="col-lg-12" id="tous"> <h1>Bienvenue</h1>
							<div class="row">
								<div class="col-lg-9">
									<div>
										<h3 align="center">Adresse: 32 Rue du Cafard, 31000 Toulouse, France</h3> <!-- Moyenne taille (titre) -->
									</div>
									<div align="center">
										<img src="caf art.jpg">
										<img src="int cafart.jpg">  <!-- Insertion des images -->
									</div>
								</div>
								<div class="col-lg-3">
								<div>
									<p align="center"> Voici nos horaires d'ouverture </p>
							
									<div  align="center">
										<SELECT name="horaire" size="1"> <!-- Liste déroulante de valeur horaire -->
											<OPTION>Lundi 7h - 22h
											<OPTION>Mardi 7h - 22h
											<OPTION>Mercredi 7h - 22h
											<OPTION>Jeudi 7h - 22h
											<OPTION>Vendredi 7h - 22h
											<OPTION>Samedi 8h - 12h / 17h - 23h
											<OPTION>Dimanche 8h - 12h
										</SELECT>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</section>
		</div>
	</div>
</body>

<!--body, #tous
{
  padding-top: 10px;
  background-image: url(nebu.jpg);
}-->
<footer id="footer">
	<p><font color="white">Create by Sylvain C</font></p>
</footer>

</html>
