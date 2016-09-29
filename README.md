# Analyseer

Bekijk de volledige commit-geschiedenis om te bestuderen hoe dit project tot stand gekomen is.

Probeer volgende vragen te beantwoorden:

i.v.m. MSTest:

- Welke Assert-methods worden naast `Assert.AreEqual` nog allemaal gebruikt?
	> `Assert.IsTrue` `Assert.IsFalse` 
- Waarom heeft `TestDirectories` een `Initialize`- en `CleanUp`-method?
	> De `Initialize`-method wordt gebruikt om de noodzakelijke variabelen en directories aan te maken voor de test. De `Cleanup`-method wordt gebruikt om de directories te verwijderen na de test.
- Zijn de attributen `[TestMethod]`, `[TestClass]`, ... noodzakelijk? (Test uit!)
	> Ja, zo weet QUnit welke methods en of classes hij moet testen.
- Wat is de shortcut om alle tests uit te voeren in VS?
	> CTRL R, A

i.v.m. Files en Directories:

- Wat is het voordeel van `Path.Combine` i.v.m. strings aan elkaar plakken?
	> Met `Path.Combine` voer je twee Paths aan elkaar. Bij deze solution wordt `Path.Combine` gebruikt om een nieuw bestand aan te maken.
- Wordt de return-waarde van `Directory.CreateDirectory(...)` steeds opgevangen? (TIP: gebruik `CTRL-SHIFT-F`)
	> Ja, je vangt deze op voor op die returnwaarde de tests uit te voeren.
- Wat is de return-waarde van `Directory.CreateDirectory(...)`?
	> True als de dir bestaat, False als de dir niet bestaat.
- Wanneer is het nuttig om de return-waarde van `Directory.CreateDirectory(...)` op te vangen?
	> Om te zien of `Directory.CreateDirectory` werkt en `dir.Delete` werkt.

i.v.m. duidelijkheid/geschiedenis van de code:

- Lukken de testen in de commit 3ffe2c86? Waarom (niet)?
- Wat lost commit d0320b6a op?
- Wat is het probleem met de files in commit 9d184949?
- Wat doet commit 9b3e4065? Maakt dit de code makkelijker leesbaar? Makkelijker uitbreidbaar?


