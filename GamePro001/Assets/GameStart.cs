using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float start = Input.GetAxisRaw("Horizontal");
        float start2 = Input.GetAxisRaw("Vertical");
        if (start != 0||start2!=0)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
