using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{


    [SerializeField] private KeyCode shootKeyCode;


    public GameObject bullet;
    public Transform PointOfShoot;

    private void Start()
    {
        
    }


    private void Update()
    {
        /*if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }*/

        
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
        Instantiate(bullet, PointOfShoot.position, PointOfShoot.rotation);
    }



}
