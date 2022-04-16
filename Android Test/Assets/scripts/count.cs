using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class count : MonoBehaviour
{
    private NavMeshAgent an;
    public Touch asw;
    // Start is called before the first frame update
    void Start()
    {
       an = GetComponent<NavMeshAgent>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) 
            {
                an.destination = hit.point;
            }

            if (Input.touchCount > 0)
            {
                asw = Input.GetTouch(0);

                if(Physics.Raycast(Camera.main.ScreenPointToRay(asw.position), out hit)) 
                {
                    an.destination = hit.point;
                }
            }


        }
    }
}
