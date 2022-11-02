using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float bulletTtl = 5;
    [SerializeField]
    GameObject Particle;
    GameObject TurnManagerRef;
    TurnManager turnManager;
    
    


    // Update is called once per frame
    void Start()
    {
        TurnManagerRef = GameObject.Find("GameManager");
        turnManager = TurnManagerRef.GetComponent<TurnManager>();
    }
    void Update()
    {
        bulletTtl = bulletTtl - Time.deltaTime;
        if (bulletTtl <= 0)
        {
            GameObject b = Instantiate(Particle, transform.position, transform.rotation);
            turnManager.WisselBeurt();
            Destroy(gameObject);

        }
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {
        GameObject b = Instantiate(Particle, transform.position, transform.rotation);
        turnManager.WisselBeurt();
        Destroy(gameObject);

        if (colision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Raakt player2");

            GameObject.Find("Canvas").GetComponent<Scorescript>().AddP2Score();
        }
        if (colision.gameObject.CompareTag("Player2"))
        {
            Debug.Log("Raakt Player1");

            GameObject.Find("Canvas").GetComponent<Scorescript>().AddP1Score();
        }
    }

}
