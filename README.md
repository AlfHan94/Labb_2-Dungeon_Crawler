Dungeon Crawler – Labb 2

## Översikt
I denna labb ska jag skapa ett konsolspel i form av en **dungeon crawler** i C#.  
Spelet går ut på att utforska en labyrint, bekämpa fiender och navigera runt på banan.

## Spelbeskrivning
- **Bana:** En dungeon definierad i `Level1.txt` med väggar, en spelarstartposition och två typer av monster: `Rat` och `Snake`.  
- **Mål:** Läsa in filen, skapa objekt för väggar, spelare och fiender. Objekten ska vara självständiga och hantera sina egna data och metoder.

## Krav
- **Data:**  
  - Position (X, Y)  
  - Färg (för utskrift i konsolen)  
  - Hälsa (HP för spelare och fiender)  
- **Metoder:**  
  - Förflyttning  
  - Attack och försvar  

## Tekniska detaljer
- **Språk:** C#  
- **Inläsning:** Dungeon läses från `Level1.txt`  
- **OOP:** Använder abstrakta basklasser, arv och polymorfism för att strukturera spelet
