# Courier-Run

Progetto arcade 2D realizzato con Unity 6 (6000.3.2f1 LTS). 

Il gioco è basato su un Rider che deve muoversi ed evitare ostacoli in un ambiente a scorrimento. È una migrazione di un prototipo del 2021 aggiornato per sfruttare le ultime ottimizzazioni del motore grafico.

### Aspetti tecnici:
* **Fisica:** Gestione del salto e delle collisioni tramite Rigidbody2D.
* **Input System:** Utilizzo del nuovo pacchetto di input di Unity per una gestione più pulita degli eventi (migrato dal vecchio Input Manager).
* **Architettura:** Struttura semplice a componenti per la gestione di Rider, Score e Game Loop.

### Note di aggiornamento:
Durante il passaggio a Unity 6 ho ripulito il codice legacy e aggiornato il sistema di gestione dei pacchetti per eliminare i warning di deprecazione.
