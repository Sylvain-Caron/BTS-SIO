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
            <h1>Liste des Activités</h1><br />
            <!-- mise en place du tableau -->
            <table class="table table-bordered table-striped">
            <!-- mise en place de la ligne de titre -->
                <tr>
                    <th>Nom</th>
                    <th>Information</th>
                </tr>
                <!-- affichage de chacune des lignes du tableau -->
                <?php foreach ($lesActivites as $act): ?>
                
                <tr>
                    <td><?php echo $act[0]; ?></td>
                    <td><?php echo $act[1]; ?></td>
                </tr>
                    
                <?php endforeach; ?>
                <!-- fin du tableau -->
            </table>
          
        </div>
    </body>
</html>