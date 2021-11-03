using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_rick : MonoBehaviour
{
    public Transform rick;
    public float upper_bound = (float) 2.0;

    // Start is called before the first frame update
    void Start()
    {
        rick = this.transform;
        InvokeRepeating("spawn", (float)0.0, (float)2.0);
    }

    void spawn()
    {
        float x_pos = Random.Range(-0.75f, 0.75f);
        Transform rick_instance = (Transform)Instantiate(rick, new Vector3( x_pos, upper_bound, -0.1f), Quaternion.Euler(0, 0, 0));
        rick_instance.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
