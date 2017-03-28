<?php
	session_start();
	include('connexionBDD');
	
	$_SESSION['formateur'] = $bdd->query('SELECT ID FROM formateurs');
	$_SESSION['materiel'] = $bdd->query('SELECT ID FROM materiel_libre')
	
	$pdo = null;
?>