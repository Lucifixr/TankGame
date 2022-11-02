using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speler : MonoBehaviour
{
    public int spelerNummer;
    [SerializeField]
    Material actiefMat;
    [SerializeField]
    Material inactiefMat;
    bool IsAanDeBeurt = false;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().material = inactiefMat;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space) && IsAanDeBeurt == true)
        {

            Invoke("WisselBeurt", 0.1f);


        }*/
    }





        /*void WisselBeurt()
        {

            GameObject.Find("GameManager").GetComponent<TurnManager>().WisselBeurt();



        }*/
        public void ZetActief(bool b)

        {
            if (b == true)
            {
                IsAanDeBeurt = true;
                GetComponent<SpriteRenderer>().material = actiefMat;
                GetComponent<TankController>().enabled = true;
            }
            else
            {
                IsAanDeBeurt = false;
                GetComponent<SpriteRenderer>().material = inactiefMat;
                GetComponent<TankController>().enabled = false;
            }

        }


}   
