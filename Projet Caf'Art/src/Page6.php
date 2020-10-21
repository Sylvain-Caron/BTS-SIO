<?php session_start(); ?>
<?php 
   if(isset($_GET['valide']))
   {
       if(empty($Nom)) 
       {
            $msg="Vous devez remplir le Nom";
            echo $msg;
       }
   }                      
?>
<html>

<head>
	<title>Satisfaction</title>
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
			<div class="col-lg-12"> <h1>Formulaire Satisfaction</h1>
                
                <form action="calcul.php" method="post">
                    <div>
                        Prénom:
                        <input type="text" name="Prenom">
                        Nom:
                        <input type="text" name="Nom">
                        Mr
                        <input type="radio" name="Sexe" value="Mr">
                        Mme
                        <input type="radio" name="Sexe" value="Mme">
                    </div>
                    <div>
                        Qualité du service:
                        <select name="service">
                            <OPTION>0</OPTION>
                            <OPTION>1</OPTION>
                            <OPTION>2</OPTION>
                            <OPTION>3</OPTION>
                            <OPTION>4</OPTION>
                            <OPTION>5</OPTION>
                        </select> /5
                        <!-- <input type="radio" name="Service" value="+" id="box1"> Très bien
                        <input type="radio" name="Service" value="-" id="box2"> Mauvaise -->
                    </div>
                    <div>
                        Présentation de l'oeuvre:
                        <select name="oeuvre">
                            <OPTION>0</OPTION>
                            <OPTION>1</OPTION>
                            <OPTION>2</OPTION>
                            <OPTION>3</OPTION>
                            <OPTION>4</OPTION>
                            <OPTION>5</OPTION>
                        </select> /5
                        <!-- <input type="radio" name="Oeuvre" value="+"> Bonne Présentation
                        <input type="radio" name="Oeuvre" value="-"> Mauvaise Présentation -->
                    </div>
                    <div>
                        Qualité du Caf'Art:
                        <select name="art">
                            <OPTION>0</OPTION>
                            <OPTION>1</OPTION>
                            <OPTION>2</OPTION>
                            <OPTION>3</OPTION>
                            <OPTION>4</OPTION>
                            <OPTION>5</OPTION>
                        </select> /5
                        <!-- <input type="radio" name="Art" value="+" id=""> Très bien
                        <input type="radio" name="Art" value="-" id=""> Mauvaise -->
                    </div>
                    <div>
                        Qualité du Café/Thé:
                        <select name="cat">
                            <OPTION>0</OPTION>
                            <OPTION>1</OPTION>
                            <OPTION>2</OPTION>
                            <OPTION>3</OPTION>
                            <OPTION>4</OPTION>
                            <OPTION>5</OPTION>
                        </select> /5
                        <!-- <input type="radio" name="Cat" value="+" id=""> Très bien
                        <input type="radio" name="Cat" value="-" id=""> Mauvaise -->
                    </div>
                    <div>
                        Qualité du site:
                        <select name="site">
                            <OPTION>0</OPTION>
                            <OPTION>1</OPTION>
                            <OPTION>2</OPTION>
                            <OPTION>3</OPTION>
                            <OPTION>4</OPTION>
                            <OPTION>5</OPTION>
                        </select> /5
                        <!-- <input type="radio" name="Site" value="+" id=""> Très bien
                        <input type="radio" name="Site" value="-" id=""> Mauvaise -->
                    </div>
                    <div>
                        <textarea name="comm" cols="50" placeholder="Commentaire général"></textarea>
                    
                    </div>
                    <br/>
                    <input type="submit" name="valide" value="Envoyé"> 
                                        
                </form>
                
            </div>
        </div>
    </div>
    

	<script>
        function verifForm()
        { 
            if(document.getElementById("box1").checked == false && document.getElementById("box2").checked == false)
            {
                document.getElementById("reponse").innerHTML = "Le Service n'est pas défini";
            }
        }
    
    </script>
	

	
</body>

</html>