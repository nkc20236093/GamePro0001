using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenerator : MonoBehaviour
{
    public GameObject Shot_pre;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyUp(KeyCode.Space))
        {
           Instantiate(Shot_pre);
        }
        
        if (transform.position.x >= 8.14f)
        {
            Destroy(gameObject);
        }
    }
}
