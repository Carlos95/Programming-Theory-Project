using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junk : Obstacle
{
    // INHERITANCE
    private Rigidbody2D junkRb;
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        junkRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // POLYMORPHISM
    protected override void Move()
    {
        junkRb.AddForce((player.transform.position - transform.position).normalized * 2,ForceMode2D.Impulse);
    }
}
