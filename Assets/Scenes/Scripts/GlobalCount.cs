using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCount : MonoBehaviour
{
    public static int cashCount=0;
    public static bool check = false;
    //public GameObject cashDisplay;
    public static int attack = 1;
    public static int kills = 1;
    // Update is called once per frame



    void Update()
    {
        //internalCash = cashCount;
        //cashDisplay.GetComponent<Text>().text = "Nr Bani : " + internalCash;
    }
}
