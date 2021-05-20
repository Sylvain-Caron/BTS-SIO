<html lang="fr">
    <head>
        <?php 
            include './src/link.html';
        ?>
        <title>Liste des Médicaments</title>
        <script>
        function goToEffet(form)
        {
            if(confirm("Supprimer ce Jeu vidéo de code " + form.codeIdAction.value))
            // suppression confirmée
            form.submit();
        }
        </script>
    </head>
    <body>
        <div class="w3-top">
            <div class="menu">
                <?php
                    include 'menu.php';
                ?>
            </div>
        </div>
        </br>
        </br>
        </br>
        </br>
        <div class="container">
            <h1>Effet du Médicament : <?php echo $nomMedic ?></h1><br />
            <!-- mise en place du tableau -->
            <table class="table table-bordered table-striped">
            <!-- mise en place de la ligne de titre -->
                <tr>
                    <th style="text-align:center">Effet</th>
                </tr>
                <!-- affichage de chacune des lignes du tableau -->
                <?php foreach ($lesEffets as $effet): ?>
                
                <tr>
                    <td style="text-align:center"><?php echo $effet[1]; ?></td>
                </tr>
                    
                </form>
               
                <?php endforeach; ?>
                <!-- fin du tableau -->
            </table>

          
        </div>
    </body>
</html>