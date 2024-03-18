/*
 * 1. * *Hur fungerar stacken och heapen?**
        **Stacken (Stack):**Den fungerar som en hög av minnesplatser där varje metodanrop och dess lokala variabler lagras.
            När en metod anropas, läggs dess variabler och information på stacken. När metoden är klar tas den bort från stacken.
            Detta gör att det alltid är den senast anropade metoden som ligger överst på stacken. Enkelt uttryckt, det är en "Last In, First Out" (LIFO) struktur.
        **Heapen (Heap):**Det är en plats där objekt och data lagras som inte är lokala för en specifik metod eller variabel. Heapen är mer rörlig och dynamisk än stacken och har       längre livslängd. Objekt som skapas i heapen kräver vanligtvis manuell borttagning (genom garbage collection) när de inte längre används.
Exempel: 
   -Stacken kan liknas vid en stapel av tallrikar där du lägger till en ny tallrik överst varje gång du tar en. Den översta tallriken är den du kommer åt först och den sista som lades till är den sista som tas bort.
   - Heapen kan liknas vid en garderob där du kan placera olika objekt som du inte omedelbart behöver. Objekten förblir tillgängliga tills de tas bort manuellt.
*/
/**
2. * *Vad är Value Types respektive Reference Types och vad skiljer dem åt?**
   - **Value Types:**Dessa är datatyper som lagrar sina värden direkt i minnet där variabeln deklareras. Det innebär att värdet självt lagras och när en variabel tilldelas ett annat värde, ändras värdet på den variabeln. Exempel på value types inkluderar grundläggande datatyper som int, bool, float, etc., samt strukturer (structs).
   - **Reference Types:**Dessa är datatyper vars variabler innehåller en referens till en plats i minnet där själva datat lagras. När en variabel tilldelas en annan variabel av en reference type, pekar de båda variablerna på samma plats i minnet. Exempel på reference types inkluderar klasser, gränssnitt, delegater och strängar.

   Skillnaden är alltså hur datan hanteras i minnet och hur variabler relaterar till den. Med value types innehåller variabeln själva värdet, medan med reference types innehåller variabeln en referens till värdet.
**/

/**
3. * *Varför genererar de olika svar?**
   - I den första metoden `ReturnValue()`:
     -Variabeln `x` tilldelas värdet 3.
     - Sedan tilldelas variabeln `y` värdet av `x`, vilket är 3.
     - Sedan ändras värdet på `y` till 4.
     - Eftersom variabeln `x` inte har ändrats efter att `y` ändrats till 4, returneras fortfarande värdet 3 från `x`.
   - I den andra metoden `ReturnValue2()`:
     -Skapandet och tilldelningen av `x` och `y` sker med en klass `MyInt`, som är en reference type.
     - När `y` tilldelas `x`, pekar både `x` och `y` på samma objekt i heapen.
     - När värdet av `y` ändras till 4, påverkar detta också värdet av `x`, eftersom de båda pekar på samma objekt.
     - Därför returnerar `x.MyValue` i detta fall värdet 4.
**/

/**
 Datastrukturer och minneseffektivitet

2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
	Kapaciteten ökar när antalet element i listan överstiger den aktuella kapaciteten när ett nytt element ska läggas till i listan.
3. Med hur mycket ökar kapaciteten?
	Kapaciteten fördubblas vanligtvis när den ökar, men det beror på implementationen av List-klassen och kan variera.
4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
	För att öka kapaciteten för listan innebär att den underliggande arrayen måste kopieras till en ny array med dubbel kapacitet, vilket kräver extra minnesallokering och kopiering av befintliga element.
5. Minskar kapaciteten när element tas bort ur listan?
	Nej, kapaciteten minskar inte när element tas bort ur listan. Kapaciteten bibehålls för att undvika onödiga allokeringsoperationer vid efterföljande operationer.
6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
	Det är fördelaktigt att använda en egendefinierad array när du vet den exakta storleken på datastrukturen i förväg och inte förväntar dig att den ska ändras under körningstiden.
**/