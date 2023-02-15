using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsula_1 : MonoBehaviour
{

    [SerializeField] private float healt;
    [SerializeField] private float damage;
    [SerializeField] private float speed;
    [SerializeField] private bool paralized;
    [SerializeField] private bool god;
    // Start is called before the first frame update
    void Start()
    {
        TakeDamage(damage);
    }

    // Update is called once per frame
    void Update()
    {
        //var priconarw = Input.GetKey(KeyCode.W);
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var direccion = new Vector3(horizontal, 0, vertical);
        if (god || !paralized && healt > 0)
        {
            Move(direccion);
        }
        
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1f, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-1f, 0);
        }
        
        
    }
        
    private void Move(Vector3 moverDireccion)
    {
        transform.position += moverDireccion * (Time.deltaTime * speed) ;
    }

    private void TakeDamage(float damage)
    {
        healt -= damage;
        if(healt <= 0)
        {
            healt = 0;
            //Debug.Log("murio");
        }
        else
        {
            //Debug.Log("no murio");
        }
    }

}
