using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VelocityScript : MonoBehaviour
{
    public Text V1Text;
    public int V1Velocity;
    public int V2Velocity;
    public Text V2Text;
    public GameObject speler1;
    public GameObject speler2;
    float FirePower1;
    float FirePower2;
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    public void AddV1Text()
    {
        FirePower1 = speler1.GetComponent<TankController>().firePower;
        V1Text.text = FirePower1.ToString();
    }

    public void AddV2Text()
    {
        FirePower2 = speler2.GetComponent<TankController>().firePower;
        V2Text.text = FirePower2.ToString();
    }


}

