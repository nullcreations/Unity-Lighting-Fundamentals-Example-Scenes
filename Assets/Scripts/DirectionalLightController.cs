using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalLightController : MonoBehaviour
{
    [SerializeField] private float _rotationStep;

    private Vector3 rotationVec;
    
    void Start()
    {
        rotationVec = new Vector3(0, _rotationStep, 0);
    }

    // Update is called once per frame
    void Update()
    {
        RotateLight();
    }

    void RotateLight()
    {
        transform.Rotate(rotationVec);
    }
}
