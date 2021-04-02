# Les_03_Opdracht_Lau
23/2/2021

--------------------------------------------------
D E E L 1

Maak een ASP.NET 5.0 Core WebAPI project. 
Maak een lege controller aan met de naam 'GetalController'.

!- MAAK EEN PUBLIEKE GIT REPOSITORY -!

Zorg dat de controller de volgende methodes heeft: 
(getal: datatype = int)
  Get: lees het getal uit een textbestand genaamd 'getal.txt'.
  Post1: geef een getal mee en schrijf het weg naar 'getal.txt'.
  Post2: deze heeft geen parameter, schrijf een random getal weg tussen 1 en 10.
  
Alle functies geven "mooi" de statuscodes terug.
Zorg er ook voor dat wanneer de GET wordt gedaan en het bestand niet aanwezig is, er een 404 teruggegeven wordt.

--------------------------------------------------
D E E L 2

Maak een nieuwe controller genaamd 'GetallenController'. 

!- COPY PASTE DE VORIGE CONTROLLER EN RENAME -!

Zorg dat de controller de volgende methodes heeft:
  Get: lees alle getalen uit in een textbestand genaamd 'getallen.txt' en return een List of Array van int. De getallen worden gesplitst door aparte lijnen.
  Post: voeg een getal toe achteraan in de lijst.
  Delete: verwijder het eerste getal (en lijn!) van de lijst.
  
Voeg volgende advanced methodes toe:
  Put: maak een PUT methode die 2 ints als parameters meekrijgt. Het eerste getal is de lijn van de wijziging, het tweede getal is het nieuwe getal dat op die lijn moet komen.
  Delete: maak een 'DeleteSpecific' methode die een indexgetal meekrijgt als parameter en delete de lijn op die index. Indien de index out of bounds is, wordt er een BadRequest statuscode   teruggegeven!
