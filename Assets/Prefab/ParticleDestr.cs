using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestr : MonoBehaviour
{
    
    float particleTtd = 1f;
    ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        particleTtd -= Time.deltaTime;
        if (particleTtd <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Raakt player2");

            GameObject.Find("Canvas").GetComponent<Scorescript>().AddP2Score();
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Debug.Log("Raakt Player1");

            GameObject.Find("Canvas").GetComponent<Scorescript>().AddP1Score();
        }
    }




}
