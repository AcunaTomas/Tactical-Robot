using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class count : MonoBehaviour
{
    private NavMeshAgent an;
    public Touch asw;
    public Animator animator;
    public Transform trs;
    public int energy;
    public int energymax;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
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
        if (trs.position == an.destination)
        {

            animator.SetBool("move", false);
            

        }

        if (energy >= 1)
        {

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) 
                {
                    an.destination = hit.point;
                    animator.SetBool("move", true);
                    energy += -1;
                }

                if (Input.touchCount > 0)
                {
                    asw = Input.GetTouch(0);

                    if(Physics.Raycast(Camera.main.ScreenPointToRay(asw.position), out hit)) 
                    {
                        an.destination = hit.point;
                        animator.SetBool("move", true);
                        energy += -1;
                    }
                }
                    

            }
        }


	   
    }
}
