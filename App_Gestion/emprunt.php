<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<link rel="icon" type="image/png" href="Images/favicon.png" />
		<title>Demande D'Emprunt - [Gestion du Matériel]</title>
		<link rel="stylesheet" href="style.css" />
		<link rel="stylesheet" href="bootstrap/css/bootstrap.css" />
	</head>
	
	<body>
		<div class="menu bouton">
			<ul>
				<li><a href="#">Menu</a>
					<ul>
						<li><a href="index.php">Accueil</a></li>
						<li><a href="liste.php">Matériel</a></li>
						<li><a href="#">Retour</a></li>
					</ul>
				</li>
			</ul>
		</div>
		
		<div class="bandeau">
			<center>
				<p class="titre">Gestion du Matériel Numérique </p>
			</center>
		</div>
		
		<?php
			
			try
			{
				$bdd = new PDO('mysql:host=localhost;dbname=appgestion;charset=utf8', 'root', '');
			}
			catch(Exception $e)
			{
				die('Problème ;)' . $e->getMessage());
			}
			
			$reponse = $bdd->query('SELECT * FROM formateurs  ORDER BY `formateurs`.`ID` ASC');
		?>	
		
		<form action="#" method="post">
			<div class="Formateurs">
				<?php
					echo '<select size="18" class="Liste_Formateurs">';
					while ($donnees = $reponse->fetch())
					{
						echo '<option>' . $donnees['Nom'] . '</option>' ;
					}
					echo '</select>';
				?>
			</div>
			
			<div class="Materiel">
				<?php
					$reponse = $bdd->query('SELECT * FROM `materiel` WHERE `ID`<13');
					
					echo '<div>';
					while ($donnees = $reponse->fetch())
					{
						echo '<input type=checkbox />' . '  ' . $donnees['Modele'] . '<br/>' ;
					}
					echo '</div>';
					
					$reponse = $bdd->query('SELECT * FROM `materiel` WHERE `ID`>12 AND `ID`<25');
					
					echo '<div>';
					while ($donnees = $reponse->fetch())
					{
						echo '<input type=checkbox />' . '  ' . $donnees['Modele'] . '<br/>' ;
					}
					echo '</div>';
					$pdo = null;
				?>
			</div>
		</form>
			<div class="BtnEmprunter"><input type="submit" value="Emprunter" class="btn btn-primary"/></div>
	</body>
</html>