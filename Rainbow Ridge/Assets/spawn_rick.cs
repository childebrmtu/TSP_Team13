using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_rick : MonoBehaviour
{
    public Transform rick;
    public float upper_bound = (float) 2.0;
    public float spawn_range = (float) 0.75;
    public float spawn_period = (float) 2.0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", (float)0.0, spawn_period);
    }

    void spawn()
    {
        float x_pos = Random.Range(-spawn_range, spawn_range);
        Transform rick_instance = (Transform)Instantiate(rick, new Vector3( x_pos, upper_bound, -0.1f), Quaternion.Euler(0, 0, 0));
        rick_instance.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
