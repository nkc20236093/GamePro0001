using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class PlayerController : MonoBehaviour
{
    float tateidou = Input.GetAxis("Horizontal");
    float yokoidou = Input.GetAxis("Vertical");
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float pos.y += tateidou;
        float pos.x += yokoidou;
        if (transform.position.y <= 4.3f && transform.position.y >= -4.36f && transform.position.x < 7.99f && transform.position.x > -8.01f)
        {

        }
    }
}
