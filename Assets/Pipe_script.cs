using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Pipe_script : MonoBehaviour
{
    public float movespeed = 2;
    public float pipekill = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-movespeed,0,0) * Time.deltaTime;

        if (transform.position.x <= pipekill) {
            Debug.Log("pip exsicuted my Dev");
            Destroy(gameObject);
        }
    }   
}
