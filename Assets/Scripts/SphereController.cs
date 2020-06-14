using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] private float _stepLength;

    private Vector3 _translationVec;

    private void Start()
    {
        _translationVec = new Vector3(_stepLength,0,0);
    }

    void Update()
    {
        AutomaticMovement();
    }

    void AutomaticMovement()
    {
        transform.Translate(_translationVec);
    }
}
