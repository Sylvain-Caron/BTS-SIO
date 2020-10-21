<?php session_start(); ?>
<html>

<head>
	<meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<link rel="stylesheet" href="deco.css">
    <link rel="stylesheet" href="connexion.css"> 
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
	
	<br/>


	<div class="container">
		<div class="row">
			<div class="col-lg-12"> <h1>Formulaire Quizz</h1>
				<div class="row">
					<div class="col-lg-12">
						<div>
							<form name="quizz" action="" method="get" id="rapide">
								<div>
									Prénom:
									<input type="text" name="Prenom">
									Nom:
									<input type="text" name="Nom">
								</div>	
								<div>
									Vous êtes plutôt: <br>
									<input type="radio" name="animal" value="lievre" id="lievre"> Lièvre
									<input type="radio" name="animal" value="tortue" id="tortue"> Tortue
								</div>	
								<div>
									Faites votre choix: <br>
									<input type="checkbox" id="box1" name="" value="">
									<label for="box1">Rapide le matin</label>
									<input type="checkbox" id="box2" name="" value="">
									<label for="box2">Rapide le soir</label>
									<input type="checkbox" id="box3" name="" value="">
									<label for="box3">Lent le matin</label>
									<input type="checkbox" id="box4" name="" value="">
									<label for="box4">Lent le soir</label>
								</div>
								<div>
									Choisir 2 jours dans la semaine ou vous êtes dans l'état dit au dessus:
									<SELECT name="jour1" size="1">
										<OPTION value="Lundi">Lundi
										<OPTION value="Mardi">Mardi
										<OPTION value="Mercredi">Mercredi
										<OPTION value="Jeudi">Jeudi
										<OPTION value="Vendredi">Vendredi
										<OPTION value="Samedi">Samedi
										<OPTION value="Dimanche">Dimanche
									</SELECT>
									<SELECT name="jour2" size="1">
										<OPTION value="Lundi">Lundi
										<OPTION value="Mardi">Mardi
										<OPTION value="Mercredi">Mercredi
										<OPTION value="Jeudi">Jeudi
										<OPTION value="Vendredi">Vendredi
										<OPTION value="Samedi">Samedi
										<OPTION value="Dimanche">Dimanche
									</SELECT>
								</div>
								
									<br>
									(Autre) -> Voulez vous faire un calcul de vitesse ? <input type="button" onClick="demande()" value="Calcul de Vitesse">
									<div id="repRapide">
									</div>
									<br>
									
								Validation du Quizz : <input type="submit" onClick="verif()" value="Validation">
							</form>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	
	<script>
		function verif()
		{
			var note = 0; 							// Variable note qu'on affiche à la fin
			if(document.getElementById("lievre").checked) // On va voir l'id en référence 			                                         pour savoir si il est "cocher"
			{
				note = note + 2;                           // J'incremente la note
			}
			else
			{
				note = note + 1;
			}

			// On va voir les id en référence pour savoir si ils sont "cocher"
			if( document.getElementById("box1").checked == true && document.getElementById("box4").checked == true  || 
				document.getElementById("box2").checked == true && document.getElementById("box3").checked == true)
			{

				note = note + 3; 						   // J'incremente la note
			}
			else
			{
				note = note + 0;
			}

			// Je choisi le Nom du formulaire, le nom du SELECT (jour1) puis la value et si elle est égale à ce que je veux j'incremente de la valeur que je souhaite
			if(document.quizz.jour1.value == "Lundi" || document.quizz.jour1.value == "Mardi" || document.quizz.jour1.value == "Jeudi" || document.quizz.jour1.value == "Vendredi")
			{
				note = note + 2;
			}
			else
			{
				note = note + 1;
			}
			if(document.quizz.jour2.value == "Lundi" || document.quizz.jour2.value == "Mardi" || document.quizz.jour2.value == "Jeudi" || document.quizz.jour2.value == "Vendredi")
			{
				note = note + 2;
			}
			else
			{
				note = note + 1;
			}

			// J'affiche la note
			alert("Voici votre rapidité : " + note + "/10");
		}

		function demande()
		{
			var sport, leve, temps;
			var total = 0;
			alert("Nous allons effectué un calcul de vitesse");

			sport = confirm("Faites vous du sport ?");
			if(sport == true)
			{
				total = total + 2;
			}
			else
			{
				total = total + 1;
			}
			leve = prompt("Vous êtes du matin ou du soir ?");
			if(leve == "matin")
			{
				total = total + 3;
			}
			else
			{
				total = total + 1;
			}
			temps = prompt("Combien de temps dormez vous par nuit ?");
			if(temps <= 7)
			{
				total = total + Math.floor(Math.random() * 6);
			}
			else
			{
				total = total + 0;
			}
			document.getElementById("repRapide").innerHTML = "Voici votre note de rapidité " + total;
		}
		

	</script>
	
</body>
<footer>
	<p><font color="white">Create by Sylvain C</font></p>
</footer>

</html>
