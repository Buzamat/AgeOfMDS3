using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameObject textBox;

    public void ClickTheButton()
    {
        GlobalCount.cashCount += 1;
        if (GlobalCount.check)
        {
            GlobalCount.check = false;
        }
        else GlobalCount.check = true;

    }

}
