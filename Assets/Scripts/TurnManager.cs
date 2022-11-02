using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private int spelerBeurt = 1;
    public GameObject speler1;
    public GameObject speler2;
    //public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] spelers = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject g in spelers)
        {
            if (g.GetComponent<Speler>().spelerNummer == 1)
            {
                speler1 = g;
            }
            else if (g.GetComponent<Speler>().spelerNummer == 2)
            {
                speler2 = g;
            }
        }   // De speler die aan de beurt is wil ik actief maken
        Invoke("Init", 0.1f);
    
    }
    void Init()
    {
        if (spelerBeurt == 1)
        {
            Debug.Log("Speler 1 is nu aan de beurt");
            speler1.GetComponent<Speler>().ZetActief(true);
            speler2.GetComponent<Speler>().ZetActief(false);
            speler2.GetComponent<TankController>().enabled = false;
            speler1.GetComponent<TankController>().enabled = true;

        }
        else if (spelerBeurt == 2)
        {
            Debug.Log("Speler 2 is nu aan de beurt");
            speler2.GetComponent<Speler>().ZetActief(true);
            speler1.GetComponent<Speler>().ZetActief(false);
            speler1.GetComponent<TankController>().enabled = false;
            speler2.GetComponent<TankController>().enabled = true;
        }

    }

   public void WisselBeurt()
   {
        if (spelerBeurt == 1 )
        {
            spelerBeurt = 2;
            speler1.GetComponent<Speler>().ZetActief(false);
            speler2.GetComponent<Speler>().ZetActief(true);
            speler2.GetComponent<TankController>().hasFired = false;
            Debug.Log("Player2 werkt");
        }
        else if (spelerBeurt == 2)
        {
            spelerBeurt = 1;
            speler2.GetComponent<Speler>().ZetActief(false);
            speler1.GetComponent<Speler>().ZetActief(true);
            speler1.GetComponent<TankController>().hasFired = false;
            Debug.Log("Player1 werkt");
        }

   }
}
