using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public count plyr;
    public EnemyEnergy enemy;
    public Texts texto;
    public int turns;
    public int turns2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.trs.childCount <= 0)
        {
            plyr.active = false;
            texto.txt.text = "You Winner!";
        }


        if (enemy.energy == enemy.maxenergy)
        {
            if (plyr.moving == false)
            {
                plyr.active = false;
                enemy.activateEnemies();
                turns += 1;
            }

        }
        else
        {
            if (enemy.energy < 1 && plyr.active == false)
            {
                StartCoroutine(wait());

            }
        }

    }
    public void gameover()
    {
        texto.txt.text = "You Loser!";
    }

    IEnumerator wait()
    {
        Debug.Log("Begin");
        yield return new WaitForSeconds(2);
        plyr.active = true;
        enemy.deactivateEnemies();
        Debug.Log("End");
    }
}
