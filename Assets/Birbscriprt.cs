using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Birbscriprt : MonoBehaviour
{

    public Rigidbody2D mybody;
    public float flap_streangth,rotat, counterotation;
    public bool testing = false;
    private bool flap, birdAlive = true;
    public Game_logic logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Game_logic>();
    }

    // Update is called once per frame
    void Update()
    {
        //reset for testing 
        if (testing && Input.GetKeyDown(KeyCode.R)) {

            gameObject.transform.position = new Vector2(0, 0);
            mybody.velocity = new Vector2(0, 0);

        }

        // controle
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive) { 

            mybody.velocity = Vector2.up * flap_streangth;

            if (inrotation(180, 90))
                gameObject.transform.Rotate(new Vector3(0f, 0f, (counterotation * 10)));

        }

        //coninue to rotate
        if (inrotation(280, 180)) {

            gameObject.transform.Rotate(new Vector3(0f, 0f, -rotat * 10) * Time.deltaTime);

        } 
    }

    bool inrotation(float x , float y) {
        if (transform.eulerAngles.z >= x || transform.eulerAngles.z <= y)
            return true;
        return false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        logic.gameOver();
    }
}
 