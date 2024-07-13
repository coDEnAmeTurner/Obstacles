using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Dropper : MonoBehaviour
{
    [SerializeField] int waitTime = 3;
    private MeshRenderer meshRenderer;
    private new Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > waitTime)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
