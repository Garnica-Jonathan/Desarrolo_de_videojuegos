using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMichelle : MonoBehaviour
{
    [SerializeField] private Animator michhelle;
    [SerializeField] private float vida = 100;
    [SerializeField] private Transform ramon;
    [SerializeField] private float speedLook;
    [SerializeField] private float persuit;
    [SerializeField] private float persuitDistance;
    [SerializeField] private bool killer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!killer && vida > 0)
        {
            PersuitPlayer();
        }
        
        
    }

    private void LookPlayer()
    {
        var positionPlayer = ramon.position - transform.position;
        var lookPlayer = Quaternion.LookRotation(positionPlayer);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookPlayer, (speedLook * Time.deltaTime));
    }

    private void PersuitPlayer()
    {
        LookPlayer();
        var positionPlayer = ramon.position - transform.position;
        var distancePlayer = positionPlayer.magnitude;
        if (distancePlayer > persuitDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, ramon.position, persuit * Time.deltaTime);
        }
    }

    public void DamageVida(float damage)
    {
        vida -= damage;
        if (vida <=0)
        {
            vida= 0;
        }
    }

        
}
