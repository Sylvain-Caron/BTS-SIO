<?php
session_start();
?>
<html>
    <head>
        <meta charset="utf-8" />
        <title>Forum - Page principale</title>
        <link rel="shortcut icon" href="favicon.ico">
		<link rel="stylesheet" type="text/css" href="./css/index.css" media="screen">
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    </head>
 
    
        
    <!-- L'entete -->
        
    <?php include("Header.php"); ?>
        
    <br>
    
    <!-- Le menu -->
        
     <?php include("menus.php"); ?>
        
    <br>
    
    <!-- Le corps -->
    <body>
        <center>        
        <input type="button" value="Créer un post" >
            <br><br>
        <a href="regles.php">Règles du forum</a>
        <br><br>
            <div class="container">
	           <div align="center" style="background-color:lightblue">
	               <div class="col-xs-12 col-sm-12 col-md-12 col-lg-8">
                        <fieldset>
                            <legend>Dernières discussions :</legend>
                            <div name="Discution 1" class="container">
                                  
                               <?php include("lister.php"); ?>
                                
                            </div>
                        </fieldset>  
                       <br>
                    </div>
                </div>
            </div>
        <br><br>
        </center>
    </body>
</html>