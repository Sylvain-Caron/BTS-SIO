<?php

    function connexion()
    {
        $url = 'http://localhost:44398/WebService1.asmx?WSDL';

            $options = array(
                'cache_wsdl' => 0,
                'trace' => 1,
                'stream_context' => stream_context_create(array(
                    'SSL' => array(
                        'verify_peer' => false,
                        'verify_peer_name' => false,
                        'allow_self_signed' => true
                    )
                )));
            
            return $client = new SoapClient($url, $options);
    }

    function HelloWorld()
    {
       
        $client = connexion();

        $res = $client->HelloWorld();
        echo $res->HelloWorldResult;
    }
    
    function getMedicament()
    {
        $client = connexion();

        $resultat = $client->getMedicament();
        $lesMedicaments = $resultat->getMedicamentResult->string;

        $nb = count($lesMedicaments);

        $tab = array();
        for($i=0;$i<$nb; $i++)
        {
            $tab[$i]= explode(",",$lesMedicaments[$i]);   
        }

        return $tab;
    }

    function getIdMedic($medic)
    {
        $client = connexion();

        $param=array('medic' => $medic);

        $resultat = $client->getIdMedic($param);
        $idMedic = $resultat->getIdMedicResult;

        
        return $idMedic;
    }

    function getNomMedic($idMedic)
    {
        $client = connexion();

        $param=array('idMedic' => $idMedic);

        $resultat = $client->getNomMedic($param);
        $nomMedic = $resultat->getNomMedicResult;

        return $nomMedic;
    } 

    function getEffet($idMedic)
    {
        $client = connexion();

        $param=array('idMedic' => $idMedic);

        $resultat = $client->getEffet($param);
        $lesEffets = $resultat->getEffetResult->string;

        $nb = count($lesEffets);

        $tab = array();
        for($i=0;$i<$nb; $i++)
        {
            $tab[$i]= explode(",",$lesEffets[$i]);   
        }

        return $tab;
    }

    function getEffetSec($idMedic)
    {
        $client = connexion();

        $param=array('idMedic' => $idMedic);

        $resultat = $client->getEffetSec($param);
        $lesEffetsSec = $resultat->getEffetSecResult->string;

        $nb = count($lesEffetsSec);
        $tab = array();
        for($i=0;$i<$nb; $i++)
        {
            $tab[$i]= explode(",",$lesEffetsSec[$i]);   
        }

        return $tab;
    }

    function getInteraction($idMedic)
    {
        $client = connexion();

        $param=array('idMedic' => $idMedic);

        $resultat = $client->getInteraction($param);
        $lesInteractions = $resultat->getInteractionResult->string;

        $nb = count($lesInteractions);

        $tab = array();
        for($i=0;$i<$nb; $i++)
        {
            $tab[$i]= explode(",",$lesInteractions[$i]);   
        }

        return $tab;
    }

    function addPro($nom, $prenom)
    {
        $client = connexion();

        $param=array('nom' => $nom, 'prenom' => $prenom);
        
        $client->addPro($param);
    }

    function checkInscription($idPro)
    {
        $client = connexion();

        $param=array('idPro' => $idPro);

        $resultat = $client->checkInscription($param);
        $inscrit = $resultat->checkInscriptionResult;

        return $inscrit;
    }

    function setInscription($idPro, $idAct)
    {
        $client = connexion();

        $param=array('idAct' => $idAct, 'idPro' => $idPro);

        $client->setInscription($param);
    }

    function getIdPro($nom, $prenom)
    {
        $client = connexion();

        $param=array('nom' => $nom, 'prenom' => $prenom);

        $resultat = $client->getIdPro($param);
        $idPro = $resultat->getIdProResult;

        return $idPro;
    }

    function getActivite()
    {
        $client = connexion();

        $resultat = $client->getActivite();
        $lesActivites = $resultat->getActiviteResult->string;

        $nb = count($lesActivites);

        $tab = array();
        for($i=0;$i<$nb; $i++)
        {
            $tab[$i]= explode(",",$lesActivites[$i]);   
        }

        return $tab;
    }
    //getMedicament();
    //getIdMedic("Doliprane");
    //getNomMedic(1);
    //getEffet(1);
    //getEffetSec(1);
    //getInteraction(1);
    //getActivite();
    //var_dump(checkInscription(1,2));
    //var_dump(getMedicament());
    //HelloWorld();
?>