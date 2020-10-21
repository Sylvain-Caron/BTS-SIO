<?php session_start(); ?>
<html>

<head>
	<title>Page 2</title>
	<meta http-equiv="content-type" content="text/html;charset=utf-8" />
	<link rel="stylesheet" href="deco.css">
    <link rel="stylesheet" href="dropdown.css"> 
	<link href="assets/css/bootstrap.min.css" rel="stylesheet">
</head>

<body>

	<br/>
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
	
	<section>
		<div class="container">
			<div class="row">
				<div class="col-lg-12"><h1 align="center">Le Lièvre et la Tortue</h1> <!-- Gros Titre de la fable --></div>
			</div>
			<div class="row">
				<div class="col-lg-12"><a id="titrem">Histoire</a>
					<div>
						<div align="center">
							<img src="lievre-tortue.jpg"> <!-- Insertion de l'image -->
						</div>
												<!-- Texte -->
							<p> Le Lièvre et la Tortue est une des plus célèbres fables de Jean de la Fontaine. Les fables de la Fontaine furent éditées en 12 livres entre 1668 et 1694. Le Lièvre et la Tortue est la 10ème fable du livre 6.<br>

							Cette fable est une réécriture de la fable d'Esope, La Tortue et le Lièvre.
								=> Texte de la fable La Tortue et le Lièvre d'Esope

							Cette fable met en scène des animaux personnifiés, qui sont des allégories des caractères humains.<br>
							Dans la fable Le Lièvre et la Tortue, La Fontaine met en scène un lièvre et une tortue qui décident de faire la course. Le Lièvre, sûr de sa rapidité, laisse tellement d'avance à la tortue avant de s'élancer qu'il perd finalement la course.

							Comme toujours dans les fables, La Fontaine cherche à plaire et instruire en même temps. <br>
							
							La Morale dans celle ci montre bien que la vitesse n'est pas la solution à tout</p>
					</div>
				</div>
			</div>
		</div>
	
	</section>
	
	
</body>

<footer>
	<p><font color="white">Create by Sylvain C</font></p>
</footer>

</html>
