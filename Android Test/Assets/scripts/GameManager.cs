using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public count plyr;
    public enemyAI enemy;
    public int turns;
    public int turns2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (plyr.energy <= 0 && enemy.active == false)
        {
            if (plyr.moving == false)
            {
                plyr.active = false;
                enemy.active = true;
                enemy.energy = 2;
                turns += 1;
            }

        }
        else
        {
            if (enemy.energy <= 0 && plyr.active == false)
            {
                enemy.active = false;
                plyr.active = true;
                plyr.energy = 4;
                turns2 += 1;
            }
        }

    }
}