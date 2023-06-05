using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    GameObject Heart_gauge_1;
    GameObject Heart_gauge_2;
    GameObject Heart_gauge_3;
    GameObject Heart_gauge_4;
    GameObject Heart_gauge_5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -8.01f)
        {
            Destroy(gameObject);
        }
        transform.Translate(-0.1f,0,0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Shot"))
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().decreasehp();
            Destroy(gameObject);
        }
    }
}
