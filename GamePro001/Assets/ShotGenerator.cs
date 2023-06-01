using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenerator : MonoBehaviour
{
    float bashoy;
    float bashox;
    public GameObject Shot_pre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bashoy = transform.position.y;
        bashox = transform.position.x;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject go = Instantiate(Shot_pre);
            go.transform.position =new Vector3 (bashox, bashoy, 0);
        }
    }
}
