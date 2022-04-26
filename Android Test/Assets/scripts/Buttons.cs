using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public Button but;
    public GameManager Gman;
    void Start()
    {
        but = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Continue()
    {
        if (Gman.cond == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
