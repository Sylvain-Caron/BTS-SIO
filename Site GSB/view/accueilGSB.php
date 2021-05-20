<html lang="fr">
    <head>
        <meta charset="utf-8">
        <style>
            header{
                background-size: cover; 
                background-image: url("src/img/fond-laboratoire2.jpg");
                color: white;
            }
        </style>
        <title>Accueil GSB</title>
        <?php 
            include './src/link.html';
        ?>
    </head>
    <body>
        <div class="w3-top">
            <div class="menu">
                <?php
                    include 'menu.php';
                ?>
            </div>
        </div>
        <header class="w3-container w3-center" style="padding:128px 16px">
            <!--<img src="view/fond-laboratoire1.jpg"></img>-->
            <h1 class="w3-margin w3-jumbo">Bienvenue</h1>
            <button class="w3-button w3-black w3-padding-large w3-large w3-margin-top"><a href="index.php?action=M">Voir nos productions</a></button>
        </header>
        <div class="w3-row-padding w3-padding-64 w3-container">
            <div class="w3-content">
                <div class="w3-twothird">
                <h1>Présentation de GSB</h1>
                <h5 class="w3-padding-32">GSB, est un laboratoire Galaxy Swiss Bourdin (GSB) est issu de la fusion entre le géant américain Galaxy (spécialisé dans le secteur des maladies virales dont le SIDA et les hépatites) et le conglomérat européen Swiss Bourdin (travaillant sur des médicaments plus conventionnels), lui-même déjà union de trois petits laboratoires.</h5>

                <p class="w3-text-grey">En 2009, les deux géants pharmaceutiques ont uni leurs forces pour créer un leader de ce secteur industriel. L’entité Galaxy Swiss Bourdin Europe a étabi son siège administratif à Paris.
                    Le siège social de la multinationale est situé à Philadelphie, Pennsylvanie, aux États-Unis.
                    La France a été choisie comme témoin pour l’amélioration du suivi de l'activité de visite.</p>
                </div>

                <div class="w3-third w3-center">
                <img src="src/img/logoGSBclassic.png" ></img>
                </div>
            </div>
        </div>

        <!-- Second Grid -->
        <div class="w3-row-padding w3-light-grey w3-padding-64 w3-container">
            <div class="w3-content">
                <div class="w3-third w3-center">
                <i class="fa fa-handshake-o" style="font-size:200px;color:red"></i>
                </div>

                <div class="w3-twothird">
                <h1>Réorganisation</h1>
                <h5 class="w3-padding-32">Conséquence</h5>
                <p class="w3-text-grey">Une conséquence de cette fusion, est la recherche d'une optimisation de l’activité du groupe
                    ainsi constitué en réalisant des économies d’échelle dans la production et la distribution des
                    médicaments (en passant par une nécessaire restructuration et vague de licenciements),
                    tout en prenant le meilleur des deux laboratoires sur les produits concurrents.
                    L'entreprise compte 480 visiteurs médicaux en France métropolitaine (Corse comprise), et
                    60 dans les départements et territoires d'outre-mer. Les territoires sont répartis en 7 régions
                    géographiques (Paris-Centre, Sud, Nord, Ouest, Est, DTOM Caraïbes-Amériques, DTOM AsieAfrique).
                </p>
                </div>
            </div>
        </div>
        <footer class="w3-container w3-padding-64 w3-center w3-opacity">  
            <p>Powered by <a href="" target="_blank">GSB</a></p>
        </footer>
    </body>
</html>