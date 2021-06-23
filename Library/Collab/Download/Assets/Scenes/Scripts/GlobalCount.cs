using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCount : MonoBehaviour
{
    public static int cashCount;
    public static bool check = false;
    public GameObject cashDisplay;
    public int internalCash;
    // Update is called once per frame



    void Update()
    {
        internalCash = cashCount;
        cashDisplay.GetComponent<Text>().text = "Nr Bani : " + internalCash;
    }
}
