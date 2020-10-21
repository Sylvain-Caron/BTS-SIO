<head>
    <link rel="stylesheet" type="text/css" href="./css/menus.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
</head>

<!-- Menu -->

<nav class="navbar navbar-expand-lg navbar-dark bg-dark static-top">
    <div class="container">
        <a class="navbar-brand" href="">
            <a href="Index.php"><img src="Images/logo.png"></a>
        </a>
        <center>
            <ul class="navbar-nav ml-auto">
                <li class="nav-item active">
                    <a class="nav-link" title="Accueil du Forum" href="Index.php">Accueil du forum</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" title="Post récents" href="posts.php">Discussions récentes</a>
                </li>
                <?php
                    if(isset($_SESSION['pseudo'])){
                        try{
                            $bdd = new PDO('mysql:host=localhost;dbname=forum', 'root', '');
                        }
                        catch(Exception $e){
                            die('Erreur : '.$e->getMessage());
                        }
                        $type =$bdd->query('SELECT type FROM users where Id='.$_SESSION['id']);
                        $type=$type->fetch();
                        if($type[0]=="Admin"){
                ?>
                <li class="nav-item active">
                    <a class="nav-link" title="Admin" href="connectAdmin.php">Espace admin</a>
                </li>
                <?php
                    }
                }
                ?>
            </ul>
        </center>
    </div>
    <a href="connect.php" ><button class="btn btn-primary">Se connecter</button></a>
    <br><br>
    <a href="inscription.php"><button class="btn btn-success">S'inscrire</button></a>
</nav>