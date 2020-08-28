# baze_podataka_2
Proces isporuke i prodaje poljoprivrednih proizvoda započinje prijemom narudžbenice na osnovu izdatog kataloga o proizvodima.
Proverava se tražena količina na stavci narudžbenice sa stanjem u bazi. Ako je rezultat upita tačan, nastavlja se sa daljim tokom isporuke.
Prodavac izdaje otpremnicu sa detaljima o isporučenim proizvodima na osnovu koje kupac dalje izdaje prijemnicu o primljenim proizvodima.
Na osnovu prijemnice prodavac izdaje račun (fakturu).
Na kraju na osnovu fakture kupac vrši uplatu čime se proces isporuke i prodaje poljoprivrednih proizovda završava.

Projekat se sastoji iz 5 delova:
1. ER i relacioni model u kome su detaljno opisani svi objekti koji će se pojavljivati u bazi, zajedno sa njihovim atributima i međusobnim vezama.
2. Denormalizacija druge i treće normalne forme korišćenjem pre-joining i short-circuit tehnike.
3. Implementacija korisnički definisanih tipova i trigera.
4. Optimizacija baze podataka – kreiranje indeksa nad spoljnim ključem i tekstualnim poljem, vertikalno particionisanje, horizontalno particionisanje, dve različite tehnike optimizacije sa pratećim uskladištenim procedurama.
5. Aplikacija nad bazom podataka u programskom jeziku C#.
