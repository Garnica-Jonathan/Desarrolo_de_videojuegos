using Assets.scripts.Clase_8;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_object_controller : MonoBehaviour
{
    /*public enum Object_Controller
    {
        Idle,
        Pursuit,
        RunAway
    }*/

    [SerializeField] private Object_Controller currentState;
    [SerializeField] private Transform cubo_2;
    [SerializeField] private float speed;
    [SerializeField] private float pursuitDistance;
    [SerializeField] private float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (currentState)
        {
            case Object_Controller.Idle:
                ExecuteIdle();
                break;
            case Object_Controller.Pursuit:
                    ExecutePursuit();
                break;
            case Object_Controller.RunAway:
                ExecuteRunAway();
                break;
            default:
                Debug.Log("Current State is invalid");
                    break;
        }
        
    }

    

    private void ExecuteIdle()
    {
        Debug.Log("Funciona 1");
    }

    private void LookAtPlayer()
    {

        //transform.LookAt(cubo_2.position);
        var VectorCubo_2 = cubo_2.position - transform.position;
        var lookPlayer = Quaternion.LookRotation(VectorCubo_2);
        transform.rotation = Quaternion.Lerp(transform.rotation,lookPlayer,Time.deltaTime * rotationSpeed);
    }
    private void ExecutePursuit()
    {
        Debug.Log("Funciona 2");
        var VectorCubo_2 = cubo_2.position - transform.position;
        var distance = VectorCubo_2.magnitude;
        LookAtPlayer();
        if (distance > pursuitDistance)
        {
            //transform.position += VectorCubo_2.normalized * (speed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, cubo_2.position, Time.deltaTime * speed);
        }
       
    }

    private void ExecuteRunAway()
    {
        Debug.Log("Funciona 3");
    }
}
