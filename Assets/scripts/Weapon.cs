using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Bullet disparo_de_arma;
    public Transform apuntar;
    public float shootingTimer;
    private float _shootingTimerInner;
    
    // Start is called before the first frame update
    void Start()
    {
        _shootingTimerInner = shootingTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Shoot();
        }
        
        /*if( _shootingTimerInner <= Time.time)
        {
            Shoot();
        }*/
    }

    private void Shoot()
    {
        _shootingTimerInner = shootingTimer + Time.time;
        Instantiate(disparo_de_arma, apuntar.position, apuntar.rotation);
        //Debug.Log("disparar");
    }
}
