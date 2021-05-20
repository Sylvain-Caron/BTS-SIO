<?php

    require_once "modele/modeleMedic.php";

    //require_once "modele/modeleC.php";

    require_once "controler/controler.php";
    
    if(empty($_GET["action"]))
        consultAccueil();
        else
            if($_GET["action"] == 'M')
                consultMedic();
            else
                if($_GET["action"] == 'E')
                    consultEffet();
                else
                    if($_GET["action"] == 'ES')
                        consultEffetSec();
                    else
                        if($_GET["action"] == 'I')
                            consultInteraction();
                        else
                            if($_GET["action"] == 'A')
                                consultActivite();
                            else
                                if($_GET["action"] == 'IN')
                                inscriptionAct();
                                else
                                    if($_GET["action"] == 'P')
                                        valideInscription();

?>  