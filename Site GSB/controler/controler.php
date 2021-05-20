<?php

    function consultAccueil()
    {
        require_once "view/accueilGSB.php";
    }
    
    function consultMedic()
    {
        //Recup all medicament
        $lesMedics = getMedicament();

        require_once "view/listeMedic.php";
    }

    function consultEffet()
    {
        //Recup all effet
        $idMedic = $_POST["codeIdAction"];
      
        $lesEffets = getEffet($idMedic);
        $nomMedic = getNomMedic($idMedic);
 
        require_once "view/listeEffet.php";
    }

    function consultEffetSec()
    {
        //Recup all effetSec
        $idMedic = $_POST["codeIdAction"];

        $lesEffetsSec = getEffetSec($idMedic);
        $nomMedic = getNomMedic($idMedic);

        require_once "view/listeEffetSec.php";
    }

    function consultInteraction()
    {
        //Recup all interaction
        $idMedic = $_POST["codeIdAction"];

        $lesInteractions = getInteraction($idMedic);

        $nomMedic = getNomMedic($idMedic);

        require_once "view/listeInteraction.php";
    }

    function consultActivite()
    {
        //Recup all activite
        $lesActivites = getActivite();

        require_once "view/listeAct.php";
    }

    function inscriptionAct()
    {
        
        //Inscription
        $lesActivites = getActivite();
        
        require_once "view/inscriptionAct.php";
    }

    function valideInscription()
    {
        $idAct = $_POST['act'];
        $nomPro = $_POST["nom"];
        $prenomPro = $_POST["prenom"];

        addPro($_POST["nom"], $_POST["prenom"]);

        $idPro = getIdPro($nomPro, $prenomPro);

        $check = checkInscription($idPro);
        
        if($check == false)
        {
            setInscription(getIdPro($nomPro, $prenomPro),$idAct);

            $msg = "Inscription Effectué";
            //setTimeout();
        }
        else
        {
            $msg = "Vous êtes déjà inscrit à une activitée !";
        }
        
        require_once "view/processInscription.php";
    }
?>