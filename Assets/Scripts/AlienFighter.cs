using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienFighter : Enemy
{
    // INHERITANCE
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        healthPoints = 150;
    }
}
