# Labb3 - Databaser

# Vad du ska göra

- [x]  Fyll på din databas från labb 2 med lite mer exempeldata i alla tabeller.
- [x]  Skapa ett nytt console-program i C#
- [x]  Skapa en enkel navigation i programmet som gör att användaren kan välja mellan följande funktioner.

<aside>
💡  **Entity framwork : Consol**

- [x]  Hämta alla elever (ska lösas med Entity framwork)
    
    Användaren får välja om de vill se eleverna sorterade på för- eller efternamn och om det ska vara stigande eller fallande sortering.
    
- [x]  Hämta alla elever i en viss klass (ska lösas med Entity framework)
    
    Användaren ska först få se en lista med alla klasser som finns, sedan får användaren välja en av klasserna och då skrivs alla elever i den klassen ut.
    
    Extra utmaning: låt användaren även få välja sortering på eleverna som i punkten ovan.
    
- [x]  Lägga till ny personal (ska lösas genom Entity framework)
    
    Användaren får möjlighet att mata in uppgifter om en ny anställd och den datan sparas då ner i databasen.
    
</aside>

<aside>
💡 **SQL : Mangment Studio (SSMS) (Query fil )**

- [ ]  Hämta personal (ska lösas med SQL)
    
    Användaren får välja om denna vill se alla anställda, eller bara inom en av kategorierna så som ex lärare.
    
- [ ]  Hämta alla betyg som satts den senaste månaden (ska lösas med SQL)
    
    Här får användaren direkt en lista med alla betyg som satts senaste månaden där elevens namn, kursens namn och betyget framgår.
    
- [ ]  Hämta en lista med alla kurser och det snittbetyg som eleverna fått på den kursen samt det högsta och lägsta betyget som någon fått i kursen (ska lösas med SQL)
    
    Här får användaren direkt upp en lista med alla kurser i databasen, snittbetyget samt det högsta och lägsta betyget för varje kurs.
    
    Tips: Det kan vara svårt att göra detta med betyg i form av bokstäver så du kan välja att lagra betygen som siffror istället.
    
- [ ]  Lägga till nya elever (ska lösas genom SQL)
    
    Användaren får möjlighet att mata in uppgifter om en ny elev och den datan sparas då ner i databasen.
    
</aside>

<aside>
👉 **Extrautmaningar**

- Kontrollera att personnumren är giltiga genom SQL.
- Bygg en view för att hämta betyg som satts den senaste månaden.
- Bygg ytterligare en funktion för användaren där det går att få fram snittbetyget baserat dels på kön och dels på åldersgrupp/årskull sett till snittet för alla kurser de läst.
</aside>
