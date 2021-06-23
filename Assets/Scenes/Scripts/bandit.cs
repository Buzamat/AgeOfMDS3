using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandit : MonoBehaviour
{
    public static float speed = 0.0f;
    private Rigidbody2D rb;
    public float inspeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-inspeed, 0);
        speed += speed;
    }

    // Update is called once per frame
    void Update()
    {
        speed += Random.Range(1000,1000);
        rb.velocity = new Vector2(speed, 0);
    }
}
