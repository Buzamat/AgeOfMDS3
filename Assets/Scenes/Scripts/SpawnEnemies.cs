using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

    //public GameObject unitPrefab;
    private static GameObject a;
    public static float respawnTime = 1.0f;
    private Vector2 screenBounds;
    public static bool died = false;
    public static int idenemy;
    //public AudioSource playSound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(unitWaves());
        // Instantiates a prefab at the path "Assets/Resources/enemy".
        //new GameObject = Instantiate(Prefab.Load("BearEnemy"));
}


    private void SpawnEnemy(){
        idenemy = GlobalCount.kills%3;
        if (GlobalCount.kills <= 5)
        {
            a = (GameObject)Instantiate(Resources.Load("BearEnemy" + idenemy.ToString())) as GameObject;
            Enemy.isboss = false;
        }
        else { a = (GameObject)Instantiate(Resources.Load("BossEnemy")) as GameObject;
            Enemy.isboss = true;
        }

    }


    void Update()
    {
        if (Enemy.exists == false)
        {
            Destroy(a);
            GlobalCount.cashCount += Enemy.drop;
            Enemy.drop = 0;
            Enemy.drop +=20 * GlobalCount.kills + Random.Range(10, 15);
            Enemy.health = 0;
            Enemy.health +=20 * GlobalCount.kills + Random.Range(10, 15);
            GlobalCount.kills += 1;
            GlobalCount.attack += 1;
            StartCoroutine(unitWaves());

        }

    }

    IEnumerator unitWaves()
    {
        if (Enemy.exists==false)
        {
            //a.GetComponent<Renderer>().material.color = Color.green;
            //yield return new WaitForSeconds(respawnTime);
            

            SpawnEnemy();
            if (Enemy.isboss) { Enemy.health = 2000; Enemy.drop = 1000; }
            Enemy.exists = true;
            yield return new WaitForSeconds(0);
        }


    }
}
