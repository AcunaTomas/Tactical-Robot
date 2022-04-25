using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnergy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform trs;
    public int energy;
    public int maxenergy;
    void Start()
    {
        trs = GetComponent<Transform>();
        energy = 0;
        maxenergy = trs.childCount + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateEnemies()
    {
        if (energy != trs.childCount)
        {
            energy = trs.childCount;
        }
        trs.BroadcastMessage("Activate");
    }
    public void deactivateEnemies()
    {
        trs.BroadcastMessage("Deactivate");
    }
}
