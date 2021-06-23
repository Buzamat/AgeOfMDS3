using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioSource soundDeath;
    public AudioClip hurt;

    public void ClickTheButton()
    {
            Enemy.health -= GlobalCount.attack;
        if (Enemy.health > 0)
        {

            AudioSource.PlayClipAtPoint(hurt, new Vector3(5, 1, 2));

        }

        else
        {
            Enemy.exists = false;
            AudioSource c = Instantiate(soundDeath) as AudioSource;
            c.Play();

        }
    }

}
