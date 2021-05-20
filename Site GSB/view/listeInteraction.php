<html lang="fr">
    <head>
        <?php 
            include './src/link.html';
        ?>
        <title>Liste des Intéractions</title>
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
            <h1>Intéraction du Médicament : <?php echo $nomMedic ?></h1><br />
            <!-- mise en place du tableau -->
            <table class="table table-bordered table-striped">
            <!-- mise en place de la ligne de titre -->
                <tr>
                    <th>Médicament 1</th>
                    <th>Médicament 2</th>
                    <th>Intéraction</th>
                </tr>
                <!-- affichage de chacune des lignes du tableau -->
                <?php foreach ($lesInteractions as $interaction): ?>
                
                <tr>
                    <td><?php echo $interaction[0]; ?></td>
                    <td><?php echo $interaction[1]; ?></td>
                    <td><?php echo $interaction[2]; ?></td>
                </tr>
                    
                </form>
               
                <?php endforeach; ?>
                <!-- fin du tableau -->
            </table>

          
        </div>
    </body>
</html>