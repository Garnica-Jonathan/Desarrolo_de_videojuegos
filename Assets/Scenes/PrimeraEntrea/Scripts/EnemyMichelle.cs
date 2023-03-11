using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMichelle : Entity
{
    [SerializeField] protected EnemyData m_EnemyData;
    [SerializeField] private Animator michhelle; 
    [SerializeField] private Transform ramon;
    //[SerializeField] private float speedLook = 10;
    //[SerializeField] private float persuit = 2;
    //[SerializeField] private float persuitDistance = 2;
    [SerializeField] private bool killer;
    public float current;

    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        current = m_maxHealt;
        m_EnemyData = GetComponent<EnemyData>();//me pone GetComponent requires that the requested component 'EnemyData' derives from MonoBehaviour or Component or is an interface.
    }

    // Update is called once per frame
    void Update()
    {
        if (!killer && current > 0)
        {
            PersuitPlayer();
        }

        if (current <= 0)
        {
            Die(true);
        }
    }

    private void LookPlayer()
    {
        var positionPlayer = ramon.position - transform.position;
        var lookPlayer = Quaternion.LookRotation(positionPlayer);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookPlayer, (m_EnemyData.speedLook * Time.deltaTime));
    }

    private void PersuitPlayer()
    {
        LookPlayer();
        var positionPlayer = ramon.position - transform.position;
        var distancePlayer = positionPlayer.magnitude;
        if (distancePlayer > m_EnemyData.persuitDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, ramon.position, m_EnemyData.persuit * Time.deltaTime);
        }
    }

    public void DamageVida(float damage)
    {
        current -= damage;
        if (current <= 0)
        {
            current = 0;
        }
    }
    
    private void Die(bool die)
    {
        GameManager.instance.AddEnemyKills();
        michhelle.SetBool("MichelleBool", die);
        Destroy(gameObject);
    }
        
}
