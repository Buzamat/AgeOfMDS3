using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSheesh : MonoBehaviour
{

    public GameObject unitPrefab;
    public AudioSource soundPrefab;
    public static float respawnTime = 0.1f;
    private Vector2 screenBounds;
    //public AudioSource playSound;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }


    private void SpawnEnemy(){
        GameObject a = Instantiate(unitPrefab) as GameObject;
        AudioSource b = Instantiate(soundPrefab) as AudioSource;
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y /3, screenBounds.y/3));
        b.Play();
        }


    void Update()
    {
        StartCoroutine(unitWaves());
    }

    IEnumerator unitWaves()
    {
        while (GlobalCount.check)
        {      
                yield return new WaitForSeconds(respawnTime);
                SpawnEnemy();
            GlobalCount.cashCount += 1;
        }


    }
}
