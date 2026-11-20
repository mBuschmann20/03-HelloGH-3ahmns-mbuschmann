using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string[] locations =
    {
        "Serverstadt",
        "digitales Archiv",
        "Pixelwald",
        "Computersystem eines Raumschiffs",
        "verlassenes Spiel",
        "unterirdisches Datennetz"
    };

    string[] damageCauses =
    {
        "ein fehlerhaftes Update",
        "ein Computervirus",
        "ein abgestürztes Programm",
        "gestohlene Bytes",
        "eine beschädigte Datei",
        "eine unterbrochene Verbindung"
    };

    string[] restoreItems =
{
        "Farben",
        "Erinnerungen",
        "Daten",
        "Energie",
        "Verbindungen",
        "Spielfelder"
    };

    void Start()
    {
        int randomLocation = Random.Range(0, locations.Length);
        Debug.Log("Wo: " + locations[randomLocation]);

        int randomDamageCause = Random.Range(0, damageCauses.Length);
        Debug.Log("Ursache: " + damageCauses[randomDamageCause]);

        int randomRestoreItem = Random.Range(0, restoreItems.Length);
        Debug.Log("Wiederherstellung: " + restoreItems[randomRestoreItem]);
    }

    void Update()
    {
        
    } 
}
