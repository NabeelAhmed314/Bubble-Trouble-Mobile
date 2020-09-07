using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public int lifeCount;
    public GameObject Life2;
    public GameObject Life1;
    public GameObject Life0;


    public static LifeManager LM;

    // Start is called before the first frame update
    void Start()
    {
        if(LifeManager.LM == null)
        {
            LifeManager.LM = this;
            lifeCount = 2;
            DontDestroyOnLoad(LifeManager.LM);
            DontDestroyOnLoad(Life2);
            DontDestroyOnLoad(Life1);
            DontDestroyOnLoad(Life0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeCount == 2)
        {
            Life2.SetActive(true);
            Life1.SetActive(true);
            Life0.SetActive(true);
        }
        else if(lifeCount == 1)
        {
            Life2.SetActive(false);
            Life1.SetActive(true);
            Life0.SetActive(true);
        }
        else if(lifeCount == 0)
        {
            Life2.SetActive(false);
            Life1.SetActive(false);
            Life0.SetActive(true);
        }
        else
        {
            Life2.SetActive(false);
            Life1.SetActive(false);
            Life0.SetActive(false);
            Destroy(Life2);
            Destroy(Life1);
            Destroy(Life0);
            Destroy(LifeManager.LM);
            SceneManager.LoadScene("GameOver");
        }
    }
}
