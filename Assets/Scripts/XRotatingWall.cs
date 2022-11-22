using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRotatingWall : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.5f, 0f, 0f);
    }
}
