Resebokare 2
============
Ni ska skapa ett program som hanterar bokning av tågresor.
Tåget har ett begränsat antal platser för passagerare, exempelvis 100.
På tåget finns 2 kategorier av platser: Första klass och Ekonomiklass.
10% av platserna är avsedda för förstaklass, övriga platser är avsedda för ekonomi.

Implementera en arvshierarki för platserna.
Passagerarna i ekonomiklass har ett namn, ett syfte med resan samt en möjlighet att välja till lunch.
Passagerarna i första klass har ett namn, ett syfte med resan och valet att få en sovstol eller ej.
Placera så mycket som möjligt i basklassen Seat och lägg endast det som är specifikt i subklasserna.

Vid bokning av ny plats så får användaren antingen mata in ett specifikt nummer, eller så slumpas det ut en plats om användaren väljer att inte skriva in något alls.
Självklart går det inte att boka en plats som redan är tagen.

Basera programmet på klasserna Train, Seat, Passenger. Fler klasser kommer med säkerhet behövas.

Använd lämplig collection för att lagra bokningarna.

När man visar alla passagerarna skall dom kunna visas i både platsordning och namnordning.

Bygg in stöd för loggning mha interface vid bokning av förstaklassbiljetterna.

Exempel av hur programmet kan fungera
Antal lediga platser i Första klass är 10 och antal lediga platser i Ekonomi klass är 90
1. Registrera ny passagerare till första klass
2. Registrera ny passagerare till ekonomiavdelningen
3. Visa passagerare som reser med första klass
4. Visa passagerare som reser med ekonomiklass
5. Visa alla passagerare
6. Avsluta

"Användare väljer val: 1 "
Plats nummer: 6
Namn: Elof Jönsson
Syfte med resan: Business and pleasure
Sovstol (Ja/Nej): Ja

När ni är klara med programmet
Fundera över era variabler i klasserna ni skapat, om det inte finns ett tydligt syfte med att ha dem publika bör de vara privata, alternativt kan de vara protected om det gynnar arvshirarkin.
Titta över så att ni har stor och liten bokstav på rätt ställen. Samt att variablerna har lämpliga namn som vem som helst kan förstå. Stämmer singular och plural?
Be en kompis titta på programmet och föreslå 3 förbättringar.
