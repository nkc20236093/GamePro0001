using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : MonoBehaviour
{
    float yokoidou;
    float tateidou;
    float tateidousokudo;
    float yokoidousokudo;
    Vector3 Pos = Vector3.zero;
    Rigidbody2D Rigid2d;
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.Rigid2d = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        yokoidousokudo = 1;//Mathf.Abs(this.Rigid2d.velocity.x);
        tateidousokudo = 1; Mathf.Abs(this.Rigid2d.velocity.y);
        

        yokoidou = Input.GetAxisRaw("Horizontal");
        tateidou = Input.GetAxisRaw("Vertical");
        
        Pos.y = tateidou*tateidousokudo;
        Pos.x = yokoidou*yokoidousokudo;

        transform.position += Pos;

        // ˆÚ“®§ŒÀ
        Vector3 p = transform.position;
        if (p.y >= 4.3f) p.y = 4.3f;
        if (p.y <= -4.36f) p.y = -4.36f;
        if (p.x >= 7.99f) p.x = 7.99f;
        if (p.x <= -8.01f) p.x = -8.01f;

        transform.position = p;

        //Debug.Log(Pos);
        //if (transform.position.y <= 4.3f && transform.position.y >= -4.36f && transform.position.x < 7.99f && transform.position.x > -8.01f)
        //{
        //    this.Rigid2d.AddForce(Pos);
        //}
    }
}
