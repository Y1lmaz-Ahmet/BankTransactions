# Projectnaam

BankMemberManager

## Stappen voor het Ontwikkelen van een Bankledenbeheer CRUD Toepassing met ASP.NET Core MVC en EF Core

1. Maak een MVC-project
2. Definieer een EF Core-model
3. Afhankelijkheidsinjectie
4. DB Verbindingsreeks
5. Database Migratie
6. Creëer een MVC-controller
7. Layout Pagina
8. Invoegoperatie
9. Formuliervalidatie in MVC
10. Formulierinzending
11. Toon Bestaande Gegevens
12. Update-operatie
13. Verwijder Operatie

## Voorbeelden

![Voorbeeldafbeelding 1](Images/DataScherm-Bankgegevens.png)
### Tabel voor Weergave van Transactiegegevens

Deze tabel toont transactiegegevens van bankleden binnen de applicatie. Hier zijn enkele van de gegevensvelden die worden weergegeven:

- Rekeningnummer
- Begunstigde Naam
- Datum
- Bedrag

De tabel bevat ook actieknoppen voor elke transactie:

- **Wijzigen**: De knop met het potloodpictogram stelt gebruikers in staat om de transactiegegevens te wijzigen. Wanneer gebruikers op deze knop klikken, worden ze naar de bewerkingspagina geleid.
- **Verwijderen**: De knop met het prullenbakpictogram biedt gebruikers de mogelijkheid om een transactie te verwijderen. Wanneer gebruikers op deze knop klikken, wordt de betreffende transactie uit de lijst verwijderd.

De tabel en de bijbehorende knoppen helpen gebruikers bij het beheren van transactiegegevens binnen de app.


![Voorbeeldafbeelding 2](Images/Form-Transaction-Inputs.png)
### Formulier voor aanmaak nieuwe leden
 
- Rekeningnummer
- Begunstigde Naam
- Banknaam
- SWIFT-code
- Bedrag

Gebruikers vullen deze velden in met de relevante transactiegegevens voordat ze de transactie indienen.

Dit gedeelte van het formulier biedt twee knoppen voor acties:

- **Submit**: Deze knop wordt gebruikt om de ingevoerde transactiegegevens te verzenden voor verwerking. Wanneer gebruikers op deze knop klikken, worden de ingevulde gegevens verstuurd voor verwerking.

- **View All**: Deze knop geeft gebruikers de mogelijkheid om alle bestaande transacties te bekijken. Wanneer gebruikers op deze knop klikken, worden ze naar een overzichtspagina geleid waar ze alle transacties kunnen zien.

![Voorbeeldafbeelding 3](Images/VerwijderScherm-Bankgegevens.png)
### Details van Transactiegegevens en Verwijderformulier

In deze sectie worden details van transactiegegevens weergegeven in een gestructureerde lijst met definitielijsten (`<dl>`). De weergegeven gegevens omvatten:

- **Rekeningnummer**
- **Begunstigde Naam**
- **Banknaam**
- **SWIFT-code**
- **Bedrag**
- **Datum**

Elke gegevenswaarde wordt weergegeven naast de bijbehorende definitiekop, en dit helpt bij een duidelijke presentatie van de transactie-informatie.

Onder de definitielijsten is er ook een verwijderformulier aanwezig. Het formulier is bedoeld voor het verwijderen van een specifieke transactie. Gebruikers kunnen de gewenste transactie selecteren en vervolgens op de "Delete" knop klikken om deze te verwijderen. Een link naar de lijstweergave is ook aanwezig om terug te keren naar het overzicht.

Deze sectie geeft gebruikers de mogelijkheid om details van een specifieke transactie te bekijken en indien nodig te verwijderen.



