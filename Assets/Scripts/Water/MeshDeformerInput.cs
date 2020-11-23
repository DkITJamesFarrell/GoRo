﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code referenced: https://catlikecoding.com/unity/tutorials/mesh-deformation/
//
//
//

public class MeshDeformerInput : MonoBehaviour
{
    #region Public Variables
    [SerializeField] float force = 10f;
    [SerializeField] float forceOffset = 0.1f;
    #endregion

    #region Private Variables

    #endregion

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            HandleInput();
        }
    }

    void HandleInput()
    {
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(inputRay, out hit))
        {
            MeshDeformer deformer = hit.collider.GetComponent<MeshDeformer>();
            if (deformer)
            {
                Vector3 point = hit.point;
                point += hit.normal * forceOffset;
                deformer.AddDeformingForce(point, force);
            }
        }
    }

   
}
