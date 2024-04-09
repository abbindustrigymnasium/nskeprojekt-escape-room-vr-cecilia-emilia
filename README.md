# Escape Room VR
Wow coolt med VR spel!!!

## Spelidén
Spelet ska vara ett escape room i VR där spelaren kan interagera med omgivningen. Till exempel ska spelaren kunna öppna lådor och lyfta objekt för att hitta ledtrådar eller viktiga verktyg som behövs för att ta sig ur rummet. 
Spelaren ska kunna röra sig i rummet med hjälp av joysticks/spakarna på kontrollerna, på så sätt behöver spelaren inte röra sig i riktiga livet. Detta betyder att spelaren inte behöver jättestort spelutrymme för att utforska hela rummet.

Spelet görs i Unity, vilket använder C#, och är menat att köras på en meta quest 2 eller meta quest 3.


## Hur kör jag själv projektet?
1. Klona projektet till din egna dator.
2. Öppna projektet i Unity med editor versionen 2022.3.19f (projektet ligger i mappen "Escape Room VR").
3. I Unity, öppna scenen "Menu" i Assets/Scenes/Menu
4. Koppla in en Meta Quest 2 eller Meta Quest 3 i datorn.

Härefter finns det två sätt att köra spelet, i editorn (dålig prestanda beroende på dator) eller att bygga det och köra det på headsetet (vilket ger bäst prestanda).
När spelet körs i Unity Editorn så går det inte att koppla ur headsetet medan spelet körs då allting händer på datorn. Däremot om du bygger spelet till headsetet så går det att koppla ur enheten.

#### I Unity Editor
Att köra spelet i Unity Editor ger generellt sätt lägre prestanda, det beror däremot på dator.
Efter att headsetet är inkopplat, följ dessa steg:
1. Öppna  [Meta Quest Link programvaran](https://www.meta.com/se/quest/setup/) (Laddas ner under Quest 2, "Ladda ner programvara")
2. Se till att alla drivrutiner på datorn är uppdaterade (specifikt för grafikkortet)
3. I programvaran, i menyn på sidan, Devices -> Add Headset
4. Följ instruktionerna för ditt headset
5. När headsetet är konfigurerat och uppkopplat via Quest Link så går du tillbaka till Unity Editor
6. Klicka på Play

#### På headsetet
Att köra spelet på headsetet ger generellt sätt högre prestanda då Quest 2 och Quest 3 är såkallade "standalone headsets".
Efter att headsetet är inkopplat behöver vi bygga de scener vi vill ha och sedan lägga över de i headsetet.
1. Sätt på headsetet och se till att sätta på Developer Mode (för detta krävs det att kontot har registrerats och konfigurerats på ett visst sätt).
2. När headsetet är inkopplat bör en notis dyka upp, den ska du klicka på för att tillåta datorn att göra ändringar på enheten (USB Detected)
3. I Unity Editor, File > Build Settings (eller klicka ctrl + shift + B)
4. Välj platform Andriod om den inte redan är vald. Välj sedan följande inställningar:
   - Texture Compression: ASTC
   - ETC2 fallback: 32-bit
   - Export Projext: false
   - Build App Bundle: false
   - Create symbols.zip: disabled
   - Run Device: Din device (klicka refresh och välj sedan den som heter Quest 2 eller Quest 3)
   - Development Build: true
   - Autoconnect Profiler: false
   - Deep Profiling support: false
   - Script Debugging: false
   - Compression Method: LZ4

5. Se till att scenerna som är med i builden är följande i samma ordning:
   -  Scenes/Menu
   -  Scenes/**Färdiga scenens namn**
   -  Scenes/Finish
7. Välj Build, namnge filen och välj var du vill spara den. Den kommer ha filändelsen ".apk".
8. När Unity har byggt färdigt så går du in i File Explorer på datorn, dra din .apk fil till "This PC/Quest 2/Download". Ändra såklart "Quest 2" till "Quest 3" beroende på headset.
9. När .apk filen befinner sig i headsetet så går du tillbaka till Unity Build Settings. Se till att headsetet är valt och sedan klickar du på Patch And Run. Unity kommer ladda och sedan bör spelet köras på ditt headset!
När Unity har laddat färdigt och spelet körs på headsetet går det bra att koppla ur det ur datorn.


## Utmaningar i arbetet
Tidsbegränsningen, spel tar lång tid att utveckla och därför skulle det antagligen varit fördelaktigt att få mer tid till att arbeta.
- Det tar lång tid att testa nya funktioner pga tiden det tar att bygga och sedan köra "patch and run". Om man vill slippa detta kan man köra direkt i Unity men det är extremt långsamt och laggigt.
- Att skapa och importera 3D-modellerade filer är tidskrävande då man måste modellera de, justera skalan på objekten när de väl är i Unity och sedan eventuellt fixa alla problem som uppstår med material och texturer.
- Komma på smartaste lösningen på problem eller funktioner. Vilket sätt kan man gå tillväga som ger det mest effektiva resultatet?
- Det är tidskrävande att få fram ett "open world" spel, ett spel där det inte går att förutspå vad spelaren kommer att göra, men man vill ändå att det ska hända saker när slumpmäsiga händelser sker.

I början hade vi svårigheter att bygga/köra spelet på en av våra datorer. Problemet löstes genom att byta editor, den förra saknade andriod tillägg på den datorn av någon anledning.


## Vad har varit kul?
Det är roligt att utveckla spel då man får koda, 3d-modellera, designa en värld och sedan såklart spela spelet då det är färdigt. Det är sätt att få vara kreativ och sitta och klura på lösningar. 

Att göra ett escape room är ett väldigt brett projekt och man kan implementera väldigt mycket, det gör att ifall man hittar någon detalj eller funktion som hade varit roligt att lära sig går det bra att stoppa in det i spelet, för det gör spelet bara roligare, som t.ex att hugga sönder saker. 


## Ifall vi hade haft oändligt med tid (förbättringar)
- Det går att fortsätta utveckla modeller och lägga till mer detaljer och bättre matrial.
- Vi skulle ha skapat en berättelse, så att man vet varför man är inlåst i ett rum och vad man letar efter.
- Ledtrådar.
- Fler funktioner som gör det mer verkligt och svårare att spela.
- Fler steg till att ta sig ut, att man måste hitta vissa verktyg för att komma åt nycklar osv.
- En bättre scen för menyn och slutet.
- Ljudeffekter (för alla objekt) och bakgrundsmusik/ljud

## Licens
Projektet är licensierat under MIT-licens.???
