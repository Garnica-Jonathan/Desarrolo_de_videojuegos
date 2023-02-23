using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.XR;


public enum Change
{
    speedPistol,
    gunWithTime
}
public class Pistol : MonoBehaviour
{
    //parte del Raycast
    [SerializeField] private Transform eyes;
    [SerializeField] private float distance;
    [SerializeField] private LayerMask layer;



    [SerializeField] private Bullet_Pistol bullet_Pistol;
    [SerializeField] private Transform empty;
    [SerializeField] private Change speedchange;
    [SerializeField] private float shotForce;
    [SerializeField] private float shotRate;
    [SerializeField] Transform arma;
    




    private float shotRateTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Switch();
        //GunTime();
        Debug.DrawRay(arma.position, arma.forward * 100f, Color.blue);

    }

    private void Shoot()
    {
        var newPistol = Instantiate(bullet_Pistol, empty.position,empty.rotation);
        newPistol.GetComponent<Rigidbody>().AddForce(empty.forward * shotForce, ForceMode.Impulse);

    }

    private void Switch()
    {
        switch (speedchange)
        {
            case Change.speedPistol:
                VelocityChange();
                break;
            /*case Change.gunWithTime:
                GunTime();
                break;*/
        }
    }
    private void GunTime()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > shotRateTime)
            {
                Shoot();
                shotRateTime = Time.time + shotRate;
            }
        }
            
    }
    private void VelocityChange()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Shoot();
            CreateRaycast();
        }

    }
    private void CreateRaycast()
    {
         RaycastHit hitInfo;
         var raycast = Physics.Raycast(eyes.position, eyes.forward, out hitInfo, distance, layer);

        if (raycast)
        {

            //Quita daño a Michelle
            EnemyMichelle enemy = hitInfo.transform.GetComponent<EnemyMichelle>();
            if (enemy != null)
            {
                enemy.DamageVida(10);
            }


            /*var l_boxRigidBody = hitInfo.rigidbody;
            if (l_boxRigidBody != null)
            {
                l_boxRigidBody.AddExplosionForce(exosionForce, hitInfo.point, radiusExplosion);
            }*/


            // Para hacerle daño a Michelle(No Funciona), no me instancia el prefap bullet_psitol
            /*hitInfo.transform.GetComponent<EnemyMichelle>().DamageVida(10);
            Instantiate(bullet_Pistol, hitInfo.point, Quaternion.identity);*/



            //para destruir directamente al Object

            //Destroy(hitInfo.transform.gameObject);
        Debug.Log($"chocaste en{hitInfo.collider}");
        }
        else
        {
            Debug.Log("no hay nada");
        }
    }


}
