<html>
    <head>
        <title>Satisfaction</title>
        <meta http-equiv="content-type" content="text/html;charset=utf-8" />
        <link rel="stylesheet" href="deco.css"> 
        <link href="assets/css/bootstrap.css" rel="stylesheet">
    </head>
    <body>
        <div name="menu">
		  <?php include "menu.php"; ?>
	    </div>
        
            <div class="container">
              <div class="row">
                <div class="col-lg-12">
                    
                    <?php
                    /*
                        $Service = $_GET["Service"];
                        $Oeuvre = $_GET["Oeuvre"];
                        $Art = $_GET["Art"];
                        $Cat = $_GET["Cat"];
                        $Site = $_GET["Site"];
                        $Valide = $_GET["valide"];
                        
                        $note = 0;
                        if($Service == '+') #Je regarde la valeur à la balise donnée et incremente ou non
                        {
                            $note = $note + 1;
                        }
                        if($Oeuvre == '+') #Je regarde la valeur à la balise donnée et incremente ou non
                        {
                            $note = $note + 1;
                        }

                        if($Art == '+') #Je regarde la valeur à la balise donnée et incremente ou non
                        {
                            $note = $note + 1;
                        }

                        if($Cat == '+') #Je regarde la valeur à la balise donnée et incremente ou non
                        {
                            $note = $note + 1;
                        }

                        if($Site == '+') #Je regarde la valeur à la balise donnée et incremente ou non
                        {
                            $note = $note + 1;
                        }
                    */
                    ?>
                    <?php
                        echo /*'Merci pour la note de ', $note, '/5'*/'Merci pour la saisi de vos note',' ', $_POST["Sexe"] ,' ', $_POST["Nom"],' ', $_POST["Prenom"];
                        #echo permet l'affichage d'une phrase suivi de la variable note et de la récupération du Nom et Prénom de la personne
                    ?>
                    <?php
                        
                        $mysqli = new mysqli('localhost','root','','client'); // connexion
                    
                        $sql = "INSERT INTO avis (nom, prenom, n_service, n_oeuvre, n_art, n_cat, n_site, commentaire) VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
                        
                        $stmt = mysqli_prepare($mysqli,$sql);
                    
                        
                        $stmt->bind_param("ssiiiiis",$_POST['Nom'],$_POST['Prenom'],$_POST['service'],$_POST['oeuvre'],$_POST['art'],$_POST['cat'],$_POST['site'],$_POST['comm']);
                        
                        $stmt->execute();
                        $mysqli->close();
                    ?>
                </div>
            </div>
        </div>
    </body>

</html>