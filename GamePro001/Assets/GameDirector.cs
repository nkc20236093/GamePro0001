using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject TimeGauge;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.TimeGauge = GameObject.Find("TimeGauge");
    }

    //void Update()
    //{

    //}
    //update is called once per frame
    public void decreasehp()
    {
        this.TimeGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if (this.TimeGauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
