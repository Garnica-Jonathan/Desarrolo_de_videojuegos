using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1_Look : MonoBehaviour
{
    [SerializeField] private Transform Character_main;
    [SerializeField] private float SpeedRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookPlayer();
    }

    private void LookPlayer()
    {
        var VectorEnemy_1 = Character_main.position - transform.position;
        var Look = Quaternion.LookRotation(VectorEnemy_1);
        transform.rotation = Quaternion.Lerp(transform.rotation, Look, (SpeedRotation * Time.deltaTime));
    }
}
