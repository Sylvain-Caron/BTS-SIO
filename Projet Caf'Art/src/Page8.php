<?php
    session_start();
    $mysqli = new mysqli('localhost','root','','client'); // connexion
    
    $resultatComm = $mysqli->query("SELECT * FROM avis"); // Requète
    
    // Requète pour la moyenne
    $sqlService = "SELECT AVG(n_service) AS service FROM avis";
    $sqlOeuvre = "SELECT AVG(n_oeuvre) AS oeuvre FROM avis";
    $sqlArt = "SELECT AVG(n_art) AS art FROM avis";
    $sqlCat = "SELECT AVG(n_cat) AS cat FROM avis";
    $sqlSite = "SELECT AVG(n_site) AS site FROM avis";
    
    // Implémentation de la requète dans une variable
    $resultatService = mysqli_query($mysqli, $sqlService); 
    $resultatOeuvre = mysqli_query($mysqli, $sqlOeuvre);
    $resultatArt= mysqli_query($mysqli, $sqlArt);
    $resultatCat = mysqli_query($mysqli, $sqlCat);
    $resultatSite = mysqli_query($mysqli, $sqlSite);
    
    // Sauvegarde des résultats dans une variable poiur l'affichage
    $row1 = mysqli_fetch_object($resultatService);
    $row2 = mysqli_fetch_object($resultatOeuvre);
    $row3 = mysqli_fetch_object($resultatArt);
    $row4 = mysqli_fetch_object($resultatCat);
    $row5 = mysqli_fetch_object($resultatSite);


?>
<html>

<head>
	<title>Note et Commentaire</title>
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
			<div class="col-lg-6"> <h1>Note par critère</h1>
                // BOUCLE A FAIRE !!!
                <ul>
                    <li>
                    <?php
                        echo "Note moyenne Service : " . $row1->service . "\n\n";
                    ?>
                    </li>    
                    <li>
                    <?php
                        echo "Note moyenne Oeuvre : " . $row2->oeuvre . "\n\n";
                    ?>
                    </li>    
                    <li>
                    <?php
                        echo "Note moyenne Art : " . $row3->art . "\n\n";
                    ?>
                    </li>    
                    <li>
                    <?php
                        echo "Note moyenne Cat : " . $row4->cat . "\n\n";
                    ?>
                    </li>  
                    <li>
                    <?php
                        echo "Note moyenne Site : " . $row5->site . "\n\n";
                    ?>   
                    </li>
                </ul>
            </div>
            <div class="col-lg-6">
                        Liste des commentaires: 
                        <br/>
                <?php
                    while($row =$resultatComm->fetch_assoc())
                    {
                        echo $row['prenom'] ." ". $row['nom'] . " : " . $row['commentaire'] . "\n";
                    }
            
                ?>
                
            </div> 
        </div>
    </div>
    

	
	

	
</body>

</html>