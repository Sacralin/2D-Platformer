using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    float patrolTime = 2.0f;
    float patrolForce = 400f;

    float patrolTimer;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        this.direction = Vector2.left;
    }

    // Update is called once per frame
    void Update()
    {
        patrolTimer += Time.deltaTime;
        if(patrolTimer >= patrolTime)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            patrolTimer = 0;
            direction *= -1;
        }

        this.GetComponent<Rigidbody2D>().AddForce(this.direction * patrolForce * Time.deltaTime);

    }
}
