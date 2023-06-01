using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    float yokoidou;
    float tateidou;
    float tateidousokudo;
    float yokoidousokudo;
    Vector3 Pos = Vector3.zero;
    Rigidbody2D Rigid2d;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Application.targetFrameRate = 60;
        this.Rigid2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        yokoidousokudo = 0.25f;//Mathf.Abs(this.Rigid2d.velocity.x);
        tateidousokudo = 0.25f; Mathf.Abs(this.Rigid2d.velocity.y);
        

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

        float y = Input.GetAxisRaw("Vertical");

        if (y == 0)
        {
            anim.Play("Player_normal_Animation");
        }
        else if (y == 1)
        {
            anim.Play("Player_L_Animation");
        }

        else
        {
            anim.Play("Player_R_Animation");
        }
    }
}
