using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Obstacle
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.2f;
        healthPoints = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //POLYMORPHISM
    protected override void Move()
    {
        transform.Translate(Vector2.down * speed);
    }
}
