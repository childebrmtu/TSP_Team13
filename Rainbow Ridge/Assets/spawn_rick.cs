using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_rick : MonoBehaviour
{
    [SerializeField]
    private Transform[] prefabs;
    [SerializeField]
    private Environment env;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", (float)0.0, (float)2.0);
    }

    void spawn()
    {
        float x_pos = Random.Range(-0.75f, 0.75f);
        Transform my_prefab = prefabs[Random.Range(0, prefabs.Length)];
        Transform rick_instance = (Transform)Instantiate(my_prefab, new Vector3( x_pos, env.GetUpperBound(), -0.1f), Quaternion.Euler(0, 0, 0));
        rick_instance.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
