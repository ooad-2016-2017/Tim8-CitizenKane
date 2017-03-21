# Football Simulator
#### Tim 8 -  Citizen Kane
### Članovi:
1. Durmić Nedim
2. Hadžirović Kenan
3. Halilović Irhad

### Opis Teme

Sistem služi za simulaciju fudbalskih utakmica i takmičenja. Kao takav može biti od pomoći sportskim radnicima, novinarima, kladioničarima i navijačima.
Na osnovu genersianih rezultata, sportski radnici mogu prevdiđati ishode mečeva i na osnovu tih informacija vršiti izmjene u stvarnim timovima. Mogu planirati
taktike i formacije, kao i analizirati protivnike. Cilj sistema je da što vjerodostojnije i realističnije prikaže sport u virtualnom svijetu. Konačno,
sistem se može koristiti za razonodu gdje igrač može preuzeti kontrolu nad omiljenim timovima.

### Procesi

- Korisnik bira da želi simulirati samo jednu utakmicu. Sistem ponudi odabir listu ekipa iz lokalne baze. Nakon odabira vlastite i protivničke ekipe, korisniku se
nudi prikaz postave i taktike. Nakon što odabere željenu postavu i taktiku, igrač nastavlja na simulaciju. Sistem generiše rezultat utakmice i prikazuje odgovarajuću
statistiku.
- Korisnik bira da želi simulirati cijelu sezonu. Potrebno je da odabere tim koji želi da vodi. Nakon toga bira da li će sezona uključivati nasumično odabrane
timove ili ručno odabrane. Kada je sezona kreirana, korisnik je upućen na meni za upravljanje simulacijom. Zavisno od odabira može da radi na transferima igrača,
podsi postave za sljedeću utakmicu, prati statistike sezone ili napusti simulaciju.
- Ukoliko korisnik primjeti da je baza igrača zastarjela ili nefunkcionalna, može odabrati preuzimanje novih podataka iz baze. U meniju odabere opciju ažuriranja
i izvrši preuzimanje sa online baze. Nakon završetka preuzimanja sistem obavještava korisnika o uspješnom ažuriranju.
- U slučaju simulacije cijele sezone korisnik može pristupiti transferu igrača. Postupak uključuje pretragu dostupnih igrača. Nakon pronalaska željenog igrača, 
ukoliko je on finansijski dostupan, korisnik dovodi igrača u svoju ekipu. U slučaju prodaje igrača korisnik bira igrača kojeg želi prodati i on tada stupa na 
listu transfera, a na račun korisnika se dodaje novčani iznos vrijednosti prodanog igrača.

### Funkcionalnosti

- Biranje vlastitog imena / nadimka
- Odabir nastavka ili nove simulacije
- Mogućnost simuliranja pojedinačne utakmice ili cijele sezone
- Mogućnost odabira ekipe
- Podešavanje sastva i taktike
- Transferi igrača (prodaja i kupovina)
- Praćenje finansija tima
- Pregled statistike lige (simulacija sezone)-
- Pregled kalendara sezone
- Ažuriranje baze timova i igrača
- Rang lista najboljih rezultata po korisniku


### Akteri

- Korisnik simulatora
- Moderator (korisnik koji može da vrši promjene nad sistemom)
