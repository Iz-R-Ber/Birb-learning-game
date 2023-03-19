using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Midscript : MonoBehaviour
{
    public Game_logic logic;

    // Start is called before the first frame update
    void Start()
    {
      logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Game_logic>();
        logic.canmod = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
            logic.AddScore();
    }
}
