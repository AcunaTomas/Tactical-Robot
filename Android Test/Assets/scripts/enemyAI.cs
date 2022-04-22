using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public int energy;
    public int maxenergy;
    public count plyr;
    public bool active;
    public Transform dir;
    private NavMeshAgent an;
    private float radar;
    private Vector3 prevcoords;
    void Start()
    {
        maxenergy = 2;
        radar = 8;
        active = false;
        dir = GetComponent<Transform>();
        an = GetComponent<NavMeshAgent>();
        prevcoords = an.destination;
    }

    // Update is called once per frame
    void Update()
    {
        if (energy > 0)
        {
            if(an.destination == prevcoords)
            {
                locate();
            }

            
        }
        else
        {
            an.destination = dir.position;
        }


    }

    void locate()
    {
        if (Vector3.Distance(dir.position, plyr.trs.position) < radar)
        {
            an.destination = plyr.trs.position;
            energy += -1;
        }
        else
        {
                
        }
    }
    void attack()
    {
        plyr.hp += -1;
    }
    void energydeduct()
    {
        
    }
}
