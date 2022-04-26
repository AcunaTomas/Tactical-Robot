using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class count : MonoBehaviour
{
    private NavMeshAgent an;
    public Touch asw;
    public Animator animator;
    public GameManager gmanager;
    public Transform trs;
    public EnemyEnergy enemy;
    public bool moving;
    public bool canattack;
    public double energy;
    public double energymax;
    public int hp;
    public int maxhp;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        moving = false;
        canattack = true;
        maxhp = 2;
        hp = 1;
        energymax = 4;
        energy = energymax;
        active = true;
        an = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
	    trs = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 1)
        {
            gmanager.gameover();
            Destroy(gameObject);

        }

        if (trs.position == an.destination)
        {
            if (moving)
            {
                moving = false;
                if (canattack)
                {
                    attack();
                    enemy.energy += 1;
                }
            }
            else
            {

            }


            animator.SetBool("move", false);

                if (active && moving == false)
                {

                if (Input.GetMouseButtonDown(0))
                {
                    RaycastHit hit;
                    if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) 
                    {
                        an.destination = hit.point;
                        animator.SetBool("move", true);
                        moving = true;
                    }

                    if (Input.touchCount > 0)
                    {
                        asw = Input.GetTouch(0);

                        if(Physics.Raycast(Camera.main.ScreenPointToRay(asw.position), out hit)) 
                        {
                            an.destination = hit.point;
                            animator.SetBool("move", true);
                            moving = true;
                        }
                    }
                        

                }
                }
            
        }
        else
        {

        }
	   
    }

    void attack()
    {

        foreach (Transform child in enemy.trs)
        {
            if (Vector3.Distance(child.position, trs.position) < 1.5)
            {
                animator.SetBool("attack", true);
                child.BroadcastMessage("Die");
            }
            else
            {
                
            }
        }
    }
}
