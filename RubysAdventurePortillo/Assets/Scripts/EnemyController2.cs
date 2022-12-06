using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    public float speed = 3.0f;
    public bool verticle;
    public float chageTime = 3.0f;


    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<rigidbody2D>(); 
    }

    void Update()
    {
        timer -= timer.deltaTime;

        if(timer < 0)
        {
            direction = -direction;
            timer = changeTime
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;

        if (vertical)
        {
            position.y position.y + Time.deltaTime * speed;
        }
        else
        {
            posion.x = posion x + Time.deltaTime * speed;
        }
        rigidbody2D.MovePosition(position);
    }
}
