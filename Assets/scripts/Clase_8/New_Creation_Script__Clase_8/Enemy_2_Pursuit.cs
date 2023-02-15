using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2_Pursuit : MonoBehaviour
{
    [SerializeField] private Transform Character_main;
    [SerializeField] private float speedLook;
    [SerializeField] private float speedPursuit;
    [SerializeField] private float Pursuitdistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pursuit();
    }

    private void LookPlayer()
    {
        var VectorPlayer = Character_main.position - transform.position;
        var look = Quaternion.LookRotation(VectorPlayer);
        transform.rotation = Quaternion.Lerp(transform.rotation, look, (speedLook * Time.deltaTime));
    }

    private void Pursuit()
    {
        LookPlayer();
        var vectorMain = Character_main.position - transform.position;
        var distance = vectorMain.magnitude;
        if (distance > Pursuitdistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, Character_main.position, (speedPursuit * Time.deltaTime));
        }
        
    }
}
