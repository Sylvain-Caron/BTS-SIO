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
        <style>
            .button{ /* Green */
                background-color: #CFC9B2;
                border: none;
                color: black;
                padding: 16px 32px;
                text-align: center;
                text-decoration: none;
                display: inline-block;
                font-size: 16px;
                margin: 4px 2px;
                transition-duration: 0.4s;
                cursor: pointer;
            }
            .button:hover {
                background-color: #4CAF50;
                color: white;
            }
            th{
                text-align: center;
            }
            td{
                text-align: center;
            }
        </style>
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
            <h1>Liste des Médicaments</h1><br />
            <!-- mise en place du tableau -->
            <table class="table table-bordered table-striped">
            <!-- mise en place de la ligne de titre -->
                <tr>
                    <th>Id</th>
                    <th>Nom</th>
                    <th>Action 1</th>
                    <th>Action 2</th>
                    <th>Intéraction</th>
                </tr>
                <!-- affichage de chacune des lignes du tableau -->
                <?php foreach ($lesMedics as $medic): ?>
                
                <!-- mise en place d'un formulaire -->
                <form method="post" action="index.php?action=E">
                <!-- champ caché pour le code du medicament de la ligne -->
                <input type="hidden" name="codeIdAction" value="<?php echo $medic[0]; ?>"/>
                <!-- affichage de la ligne courante -->
                <tr>
                    <td><?php echo $medic[0]; ?></td>
                    <td><?php echo $medic[1]; ?></td>
                    <td><button class="button" type="submit" name="effet" value="Voir les effets">Voir les effets</button></td>
                    <td><button class="button" type="submit" formaction="index.php?action=ES" name="effetSec" value="Voir les effets secondaire">Voir les effets secondaires</button></td>
                    <td><button class="button" type="submit" formaction="index.php?action=I" name="interaction" value="Voir les intéractions">Voir les intéractions</button></td>
                </tr>
                    
                </form>
               
                <?php endforeach; ?>
                <!-- fin du tableau -->
            </table>

          
        </div>
    </body>
</html>