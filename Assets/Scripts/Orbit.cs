using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform objectToOrbit;
    public float orbitSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objectToOrbit.position, new Vector3(0, 1, 0), orbitSpeed * Time.deltaTime);
    }
}
