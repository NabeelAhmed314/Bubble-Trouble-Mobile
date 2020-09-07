using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int ballCount;
    public static LevelManager LV;

    private void Start()
    {
        if (LevelManager.LV == null)
        {
            LevelManager.LV = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(ballCount == 0)
        {
            if(SceneManager.GetActiveScene().buildIndex  + 1  == 6)
            {
                Destroy(LifeManager.LM.Life0);
                Destroy(LifeManager.LM.Life1);
                Destroy(LifeManager.LM.Life2);
                Destroy(LifeManager.LM);
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
