using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemMover : MonoBehaviour
{
    public GameObject JohnLemon;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, JohnLemon.transform.position, Time.deltaTime);
    }
}
