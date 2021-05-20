<html lang="fr">
    <head>
        <meta charset="utf-8">
        <link rel="stylesheet" href="view/bootstrap.min.css" />
        <title>
            Inscription à une Activité
        </title>
        <?php 
            include './src/link.html';
        ?>
        <style>
            .button{ 
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
            <h1>Inscription à une Activité</h1><br />
            <form method="post" action="index.php?action=P">
                <p>
                    <label for="inom">Nom</label><br />
                    <input type="text" name="nom" id="inom" />
                </p>
                <p>
                    <label for="iprenom">Prénom</label><br />
                    <input type="text" name="prenom" id="iprenom" />
                </p>
                <select name="act">
                    <?php $nb = 0; ?>
                    <?php foreach ($lesActivites as $act):?>
                        <option value=<?php echo $nb = $nb + 1; ?>><?php echo $act[0]; ?></option>
                    <?php endforeach; ?>
                </select>
                <br /><br />
                <p>
                    <button class="button" type="submit" value="Valider la saisie" >Valider la saisie</button>
                    <button class="button" type="reset" value="Effacer la saisie" >Effacer la saisie</button>
                </p>
                <br />
                </form>
                <p>
            <a href="index.php">
            Annuler : Retour à l'Accueil</a>
            </p>
        </div>
    </body>
</html>