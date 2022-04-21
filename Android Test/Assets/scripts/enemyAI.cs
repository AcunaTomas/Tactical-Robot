using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public int energy;
    public int maxenergy;
    public bool active;
    void Start()
    {
        maxenergy = 4;
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (energy > 0)
        {
            energy += -1;
        }


    }
}
