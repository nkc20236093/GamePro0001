using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject TimeGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.TimeGauge = GameObject.Find("TimeGauge");
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        this.TimeGauge.GetComponent<Image>().fillAmount -= -0.1f;

    }
}
