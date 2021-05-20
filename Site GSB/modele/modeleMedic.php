<?php
    function connexionBd()
    {
        $utilisateur = "root";
        $mot_de_passe = "123456789";
        $serveur_et_base = "mysql:host=localhost;dbname=gsb";
        // connexion à la base de données
    try
    {
        $bd = new PDO($serveur_et_base, $utilisateur, $mot_de_passe);
    }
    catch(Exception $e)
    {
        // affichage d'un message d'erreur et arrêt du script
        die("Erreur : ".$e->getMessage());
    }
        // retour de la référence à la base de données
        return $bd;
    }
    // fonction renvoyant le tableau des médicaments
    function getMedicament()
    {
        $bd = connexionBd();
        $requete = "SELECT * FROM medicament";
        
        $bd->query("SET NAMES utf8");
        $resultat = $bd->query($requete);
        
        // initialisation du tableau à vide
        $lesMedicaments = array();
        
        // boucle de balayage du résultat de la requête
        // et constitution du tableau PHP
        while($ligne = $resultat->fetch())
        {
            $lesMedicaments[] = $ligne;
        }
        // fermeture du curseur relatif au résultat
        $resultat->closeCursor();
        
        return $lesMedicaments;
    }
    //Recup l'id d'un medic en fonction du nom
    function getIdMedic($medic)
    {
        $bd = connexionBd();
        
        // préparation de la requête de sélection dans la table employes
        $requete = $bd->prepare("SELECT id FROM medicament
        WHERE nom_medic=:medic");
    
        $bd->query("SET NAMES utf8");
        $requete->execute(['medic' => $medic]);
        // récupération de la ligne du résultat
        $resultat = $requete->fetch();
        return $resultat;
    }
    //Recup le nom d'un medic en fonction de l'id
    function getNomMedic($idMedic)
    {
        $bd = connexionBd();

        $requete = $bd->prepare("SELECT nom_medic FROM medicament
        WHERE id = :idMedic");

        $bd->query("SET NAMES utf8");
        $requete->bindParam('idMedic', $idMedic);
        $requete->execute();

        $resultat = $requete->fetch();

        $name = $resultat[0]; //Récupère la première valeur string

        return $name;
    }
    //Recup les effets d'un medic en fonction d'un id
    function getEffet($idMedic)
    {
        $bd = connexionBd();

        $requete = $bd->prepare("SELECT id_medic, effet FROM effet_thera
        WHERE id_medic = :idMedic");

        // exécution de la requête
        $bd->query("SET NAMES utf8");
        $requete->bindParam(':idMedic', $idMedic);
        $requete->execute();
        //$resultat = $bd->query($requete);

        $lesEffets = array();

        //$resultat = $requete->fetch();
        
        while($ligne = $requete->fetch())
        {
            $lesEffets[] = $ligne;
        }
        
        //$resultat->closeCursor();
        return $lesEffets;
    }
    //Recup les effets secondaires d'un medic en fonction d'un id
    function getEffetSec($idMedic)
    {
        $bd = connexionBd();
        $requete = $bd->prepare("SELECT id_medic, effet FROM effet_sec
        WHERE id_medic = :idMedic");

        // exécution de la requête
        $bd->query("SET NAMES utf8");
        $requete->bindParam(':idMedic', $idMedic);
        $requete->execute();

        $lesEffetsSec = array();

        while($ligne = $requete->fetch())
        {
            $lesEffetsSec[] = $ligne;
        }
        //$resultat->closeCursor();
        return $lesEffetsSec;
    }
    //Recup les intéractions d'un medic en fonction d'un id
    function getInteraction($idMedic)
    {
        $bd = connexionBd();
        $requete = $bd->prepare("SELECT m1.nom_medic AS nom_medic1, m2.nom_medic AS nom_medic2, effet FROM interaction i
                                JOIN medicament m1 ON m1.id = i.id_medic1
                                JOIN medicament m2 ON m2.id = i.id_medic2
        WHERE id_medic1 = :idMedic
        OR id_medic2 = :idMedic");

        // exécution de la requête
        $bd->query("SET NAMES utf8");
        $requete->bindParam(':idMedic', $idMedic);
        $requete->execute();

        $lesInteractions = array();

        while($ligne = $requete->fetch())
        {
            $lesInteractions[] = $ligne;
        }
        //$resultat->closeCursor();
        return $lesInteractions;
    }
    //Ajoute un pro
    function addPro($nom, $prenom)
    {
        $bd = connexionBd();

        //TODO Pour afficher un message d'erreur nécessaire de recup valeur de retour @nb
        $requete = $bd->prepare("CALL ajout_pro(:nomPro, :prenomPro, @nb)");
        $bd->query("SET NAMES utf8");
        $requete->bindParam(':nomPro', $nom);
        $requete->bindParam(':prenomPro', $prenom);
        $requete->execute();
        
    }
    //Vérifie si le pro est déjà inscrit
    function checkInscription($idPro)
    {
        $bd = connexionBd();

        $requete = $bd->prepare("SELECT COUNT(*) FROM inscription
        WHERE id_pro = :idPro");

        $bd->query("SET NAMES utf8");
        $requete->bindParam(':idPro', $idPro);
        $requete->execute();

        $resultat = $requete->fetch();
        //var_dump("Inscrit ou pas 0/1 ", $resultat[0]);
        if($resultat[0] > 0)
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
    //Enregistre l'inscription
    function setInscription($idPro, $idAct)
    {
        $bd = connexionBd();
        $requete = $bd->prepare("INSERT INTO inscription(id_act, id_pro)
        VALUES(:idAct, :idPro)");

        // exécution de la requête
        $bd->query("SET NAMES utf8");
        $requete->bindParam(':idAct', $idAct);
        $requete->bindParam(':idPro', $idPro);
        $requete->execute();
    }
    //Recup l'id d'un pro en fonction du nom et prenom
    function getIdPro($nom, $prenom)
    {
        $bd = connexionBd();
        $requete = $bd->prepare("SELECT id FROM professionnel
        WHERE nom_pro = :nom
        AND prenom_pro = :prenom");

        // exécution de la requête
        $bd->query("SET NAMES utf8");
        $requete->bindParam(':nom', $nom);
        $requete->bindParam(':prenom', $prenom);
        $requete->execute();

        $resultat = $requete->fetch();

        //Return directement la valeur plutôt qu'un tableau
        return $resultat[0];
    }
    //Recup les acitivtés
    function getActivite()
    {
        $bd = connexionBd();
        $requete = "SELECT nom, information FROM activite";
        
        $bd->query("SET NAMES utf8");
        $resultat = $bd->query($requete);
        
        // initialisation du tableau à vide
        $lesActivites = array();
        
        // boucle de balayage du résultat de la requête
        // et constitution du tableau PHP $empls
        while($ligne = $resultat->fetch())
        {
            $lesActivites[] = $ligne;
        }
        // fermeture du curseur relatif au résultat
        $resultat->closeCursor();
        return $lesActivites;
    }
    //Recup l'id de l'activité en fonction du nom
    function getIdAct($nom)
    {
        $bd = connexionBd();
        $requete = $bd->prepare("SELECT id FROM activite
        WHERE nom = :nom");

        // exécution de la requête
        $bd->query("SET NAMES utf8");
        $requete->bindParam(':nom', $nom);
        $requete->execute();

        $resultat = $requete->fetch();

        return $resultat;
    }
?>