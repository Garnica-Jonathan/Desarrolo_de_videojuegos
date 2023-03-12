using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpRaycast : CharacterMain
{
    [SerializeField] private Rigidbody rg;
    [SerializeField] private float forceJump;
    [SerializeField] private float distance;
    [SerializeField] private LayerMask layerFloor;
    [SerializeField] private bool floor;
    
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        MoveAndJump();
    }

    protected void MoveAndJump()
    {
        AllInOne();
        RaicastJump();
    }
    private void RaicastJump()
    {
        RaycastHit hitJump;

        var rayJump = Physics.Raycast(transform.position, Vector3.down, out hitJump, distance, layerFloor);

        if (rayJump)
        {
            floor = false;
        }
        else
        {
            floor = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && floor)
        {
            Jump();
        }
        Debug.DrawRay(transform.position, Vector3.down * distance, Color.green);
    }

    private void Jump()
    {
        rg.AddForce(Vector3.up * forceJump, ForceMode.Impulse);

    }

}
