using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class hpbars : MonoBehaviour
{
    // Start is called before the first frame update
    private Button hpbar;
    private RectTransform bar;
    public Image barra;
    public float size = 0f;
    public EnemyEnergy en;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        size = (en.energy / en.maxenergy);
        barra.fillAmount = size;
        print(en.maxenergy);

    }
}
