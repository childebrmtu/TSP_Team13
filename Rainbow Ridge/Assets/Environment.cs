using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    // the bounds of the play area expressed in Unity units
    [SerializeField] private float RightBound;
    [SerializeField] private float LeftBound;
    [SerializeField] private float UpperBound;
    [SerializeField] private float LowerBound;
    // the speed at which the background and obstacles scroll downward
    [SerializeField] private float ScrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // check to make sure that all variables are initialized
        if (!(RightBound > 0f))
        {
            Debug.LogError("RightBound must be given a positive value.");
        }
        if (LeftBound > 0f)
        {
            Debug.LogError("LeftBound must be given a negative value.");
        }
        if (!(UpperBound > 0f))
        {
            Debug.LogError("UpperBound must be given a positive value.");
        }
        if (LowerBound > 0f)
        {
            Debug.LogError("LowerBound must be given a negative value.");
        }
        if (!(ScrollSpeed > 0f))
        {
            Debug.LogError("ScrollSpeed must be given a positive value.");
        }
    }

    public float GetScrollSpeed()
    {
        return ScrollSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ScrollSpeed = ScrollSpeed * 1.005f;
    }
}
