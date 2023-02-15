using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Enemy_3_State
{
    Look,
    Pusuit
}
public class Enemy_3_Enum : MonoBehaviour
{
    [SerializeField] private Enemy_3_State state;
    [SerializeField] private Transform Character_main;
    [SerializeField] private float speedLook;
    [SerializeField] private float speedPusuit;
    [SerializeField] private float distancePusuit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case Enemy_3_State.Look:
                ExecuteLook();
                break;
            case Enemy_3_State.Pusuit:
                ExecutePusuit();
                break;
        }
    }

    private void ExecuteLook()
    {
        var vectorLook = Character_main.position - transform.position;
        var look = Quaternion.LookRotation(vectorLook);
        transform.rotation = Quaternion.Lerp(transform.rotation, look, speedLook * Time.deltaTime);
    }
    private void ExecutePusuit()
    {
        var vectorPuruit = Character_main.position - transform.position;
        var distance = vectorPuruit.magnitude;
        if(distance > distancePusuit)
        {
            transform.position = Vector3.MoveTowards(transform.position, Character_main.position, speedPusuit * Time.deltaTime);
        }
        
    }
}
