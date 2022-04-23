using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public int energy;
    public int maxenergy;
    public EnemyEnergy energies;
    public bool moving;
    public bool canattack;
    public int hp;
    public count plyr;
    public bool active;
    public Transform dir;
    private float radar;
    private Vector3 prevcoords;
    void Start()
    {
        maxenergy = 1;
        radar = 3;
        active = false;
        moving = false;
        dir = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (energy > 0)
        {
            if (Vector3.Distance(dir.position, plyr.trs.position) < radar)
            {
                attack();

            }
            else
            {
                energy += -1;
            }
        }



    }

    void locate()
    {

    }
    void attack()
    {
        plyr.hp += -1;
        energy += -1;
    }
    void energydeduct()
    {
        
    }
}
