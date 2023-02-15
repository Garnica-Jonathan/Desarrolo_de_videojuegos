using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municion : MonoBehaviour
{

    public Vector3 movimiento;
    public float speed;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * movimiento;
    }
}
