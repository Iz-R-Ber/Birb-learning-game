using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_spowner : MonoBehaviour
{
    public GameObject pip;
    public float spawnrate = 2;
    private float timer = 2;
    public float spawn_offset = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
            timer += Time.deltaTime;
        else {
            timer = 0;
            spawn();
        }
            

       
    }

    void spawn() { 
        float lowestpoint = transform.position.y - spawn_offset;
        float highestpoint = transform.position.y + spawn_offset;
        Instantiate(pip, 
            new Vector3( transform.position.x, Random.Range(lowestpoint, highestpoint), transform.position.z)
            , transform.rotation); 
    }
}
