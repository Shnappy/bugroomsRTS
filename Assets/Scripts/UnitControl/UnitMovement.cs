using System;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    public LayerMask ground;
    private NavMeshAgent agent;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main; //TODO change if camera is to be messed with
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit raycastHit;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, Mathf.Infinity, ground))
            {
                agent.SetDestination(raycastHit.point);
            }
        }
    }
}
