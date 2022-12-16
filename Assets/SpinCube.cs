using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 RotateAmount;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
            transform.Rotate(RotateAmount);
    }
}
