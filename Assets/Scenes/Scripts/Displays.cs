using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Displays : MonoBehaviour
{
    public GameObject healthDisplay;
    public GameObject moneyDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.GetComponent<Text>().text = "HP : " + Enemy.health;
        moneyDisplay.GetComponent<Text>().text = "Money : " + GlobalCount.cashCount;
    }
}
