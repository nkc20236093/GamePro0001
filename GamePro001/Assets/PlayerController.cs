using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class PlayerController : MonoBehaviour
{
    float yokoidou;
    float tateidou;
    float tateidousokudo;
    float yokoidousokudo;
    Vector3 Pos = Vector3.zero;
    Rigidbody2D Rigid2d;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.Rigid2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        tateidousokudo = Mathf.Abs(this.Rigid2d.velocity.x);
        yokoidousokudo = Mathf.Abs(this.Rigid2d.velocity.y);
        yokoidou = Input.GetAxisRaw("Horizontal");
        tateidou = Input.GetAxisRaw("Vertical");
        Pos.y = tateidou;
        Pos.x = yokoidou;
        transform.position += Pos;
        if (transform.position.y <= 4.3f && transform.position.y >= -4.36f && transform.position.x < 7.99f && transform.position.x > -8.01f)
        {
            //this.Rigid2d.AddForce(Pos * ) ;
        }
    }
}
