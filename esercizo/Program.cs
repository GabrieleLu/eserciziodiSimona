/*

Creazione della Classe Utente:
Definisci una classe chiamata "User" che rappresenti un utente del gioco.
Aggiungi campi per tenere traccia delle statistiche dell'utente, come partite vinte e partite perse.
2. Inizializzazione dell'Utente:
Quando avvii il gioco, chiedi all'utente di inserire il proprio nome e crea un'istanza della classe "User" per rappresentare quell'utente.
3. Aggiornamento delle Statistiche:
Durante il gioco, aggiorna le statistiche dell'utente in base all'esito della partita (vinta o persa).
Aggiungi metodi nella classe "User" per incrementare il contatore delle partite vinte o perse.
4. Visualizzazione delle Statistiche:
Aggiungi un'opzione nel menu del gioco per consentire all'utente di visualizzare le proprie statistiche.
Mostra le statistiche dell'utente, come il numero totale di partite giocate, partite vinte e partite perse.
5. Salvataggio delle Statistiche:
Aggiungi la possibilità di salvare le statistiche dell'utente su file, in modo che siano disponibili anche dopo la chiusura del programma.
Al termine del gioco, salva automaticamente le statistiche dell'utente.
6. Lettura delle Statistiche:
Al lancio del gioco, carica le statistiche dell'utente dal file, se presente, in modo che l'utente possa continuare a monitorare il proprio progresso nel tempo.





Funzionalità del Gioco dell'Impiccato:
Inizializzazione:

Il gioco sceglie una parola casualmente dall'elenco delle parole disponibili.
Visualizza una serie di trattini rappresentanti le lettere della parola da indovinare.
Input dell'Utente:

Chiede all'utente di inserire una lettera.
Controlla se la lettera inserita è presente nella parola segreta.
Logica del Gioco:

Se la lettera è corretta, mostra la sua posizione nella parola.
Se la lettera è errata, decrementa il numero di vite rimanenti e disegna una parte del corpo dell'impiccato.
Continua finché l'utente indovina la parola o finché esaurisce tutte le vite.
Fine del Gioco:

Se l'utente indovina la parola, mostra un messaggio di vittoria.
Se l'utente esaurisce tutte le vite, mostra un messaggio di sconfitta.
Statistiche dell'Utente:

Registra il numero di partite vinte e perse per l'utente.
Consente all'utente di visualizzare le proprie statistiche.
Loop di Gioco:

Dopo la fine di una partita, chiedi all'utente se desidera giocare di nuovo.
Interfaccia Utente:

Utilizza la console per visualizzare le informazioni del gioco e interagire con l'utente.
Mostra graficamente il corpo dell'impiccato mentre l'utente indovina le lettere.
Testing e Debugging:

Assicurati che il gioco funzioni correttamente in diverse situazioni e risolvi eventuali bug.
Commenti e Pulizia del Codice:

Commenta il codice per renderlo comprensibile e manutenibile.
Assicurati che il codice sia ben strutturato e pulito.
*/

using System;

public interface IFormaGeometrica
{
    double CalcolaArea();
    double CalcolaPerimetro();
}

public class Rettangolo : IFormaGeometrica
{
    public double Base { get; set; }
    public double Altezza { get; set; }

    public Rettangolo(double b, double h)
    {
        Base = b;
        Altezza = h;
    }

    public double CalcolaArea()
    {
        return Base * Altezza;
    }

    public double CalcolaPerimetro()
    {
        return 2 * (Base + Altezza);
    }
}

public class Cerchio : IFormaGeometrica
{
    public double Raggio { get; set; }

    public Cerchio(double r)
    {
        Raggio = r;
    }

    public double CalcolaArea()
    {
        return Math.PI * Math.Pow(Raggio, 2);
    }

    public double CalcolaPerimetro()
    {
        return 2 * Math.PI * Raggio;
    }
}


public class Program
{
    private static double baseRettangolo;
    private static double altezzaRettangolo;
    private static Rettangolo rettangolo;
    private static double raggioCerchio;
    private static Cerchio cerchio;

    static void Main(string[] args)
    {
        Console.WriteLine("Seleziona un'operazione:");
        Console.WriteLine("1. Calcola l'area del rettangolo");
        Console.WriteLine("2. Calcola l'area del cerchio");
        Console.WriteLine("3. Calcola il perimetro del rettangolo");
        Console.WriteLine("4. Calcola il perimetro del cerchio");
        Console.WriteLine("5. Esci");


         string scelta = Console.ReadLine();
        switch (scelta)
        {

        case "1": 

            CalcolaAreaRettangolo();

        break;


        case "2":

            CalcolaAreaCerchio();


        break;

        case "3":

            CalcolaPerimetroRettangolo();


        break;


        case "4":

            CalcolaPerimetroCerchio();


        break;


        case "5":
                Console.WriteLine("eSCI!");
        break;



        default:
                Console.WriteLine("Scelta non valida.");
        break;







    }

}

    private static void CalcolaAreaRettangolo()
    {
        Console.WriteLine("Inserisci la base del rettangolo:");
                    double baseRettangolo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci l'altezza del rettangolo:");
                    double altezzaRettangolo = double.Parse(Console.ReadLine());
                    Rettangolo rettangolo = new Rettangolo(baseRettangolo, altezzaRettangolo);
         Console.WriteLine($"L'area del rettangolo è: {rettangolo.CalcolaArea()}");
        
    }

    private static void CalcolaAreaCerchio()
    {

          Console.WriteLine("Inserisci il raggio del cerchio:");
                    double raggioCerchio = double.Parse(Console.ReadLine());
                    Cerchio cerchio = new Cerchio(raggioCerchio);
          Console.WriteLine($"L'area del cerchio è: {cerchio.CalcolaArea()}");
        
    }

    private static void CalcolaPerimetroRettangolo()
    {
         Console.WriteLine("Inserisci la base del rettangolo:");
                    baseRettangolo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci l'altezza del rettangolo:");
                    altezzaRettangolo = double.Parse(Console.ReadLine());
                    rettangolo = new Rettangolo(baseRettangolo, altezzaRettangolo);
        Console.WriteLine($"Il perimetro del rettangolo è: {rettangolo.CalcolaPerimetro()}");
        
    }

    private static void CalcolaPerimetroCerchio()
    {
        Console.WriteLine("Inserisci il raggio del cerchio:");
                    raggioCerchio = double.Parse(Console.ReadLine());
                    cerchio = new Cerchio(raggioCerchio);
        Console.WriteLine($"Il perimetro del cerchio è: {cerchio.CalcolaPerimetro()}");
    
    }
}


