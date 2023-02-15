using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    //[SerializeField] private GameObject Bullet_Pistol;
    [SerializeField] private Bullet_Pistol bullet_Pistol;
    [SerializeField] private Transform empty;
    [SerializeField] private float shotForce;
    [SerializeField] private float shotRate;


    private float shotRateTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time>shotRateTime)
            {
                Shoot();

                shotRateTime = Time.time + shotRate;
            }
        }
    }

    private void Shoot()
    {
        var newPistol = Instantiate(bullet_Pistol, empty.position,empty.rotation);
        newPistol.GetComponent<Rigidbody>().AddForce(empty.forward * shotForce, ForceMode.Impulse);


       


    }
}
