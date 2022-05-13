using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMovement : MonoBehaviour
{

    private SwerveInput _swerveInput;
    [SerializeField] private float swerveSpeed = 0.5f;

    private void Awake()
    {
        _swerveInput=GetComponent<SwerveInput>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        float swerveAmount = Time.deltaTime * swerveSpeed * _swerveInput._MoveFactorX;
        transform.Translate(swerveAmount, 0, 0);
    }
}
