<?php session_start(); ?>
<html>

<head>
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
    
    <br/>
    
	<div class="container">
		<div class="row">
			<div class="col-lg-12"></div>
		</div>
		<div class="row">
			<div class="col-lg-12">Coordonnée
				<div>
					<table align="center">
						<thead>
							<tr>
								<th>Ville</th> 
								<th>Coordonnées</th>
								<th>Oeuvre</th>
							</tr>
						</thead>
						<tr>
							<td>Toulouse</td>
							<td>32 Rue du Cafard</td>
							<td>Le lièvre et la tortue</td>
						</tr>
						<tr>
							<td>Avignon</td>
							<td>84 Rue du zoo</td>
							<td>Le Jazz</td>
						</tr>
						<tr>
							<td>Albi</td>
							<td>Au Hibou</td>
							<td>Le Hibou</td>
						</tr>
						<tr>
							<td>Paris</td>
							<td>Le Bouchor</td>
							<td>Oeuvre Théatral</td>
						</tr>
					</table>
				</div>
			
			</div>
		</div>
	
	</div>
	
	
	
	<br/>

	
</body>

<footer>
	<p><font color="white">Create by Sylvain C</font></p>
</footer>

</html>
