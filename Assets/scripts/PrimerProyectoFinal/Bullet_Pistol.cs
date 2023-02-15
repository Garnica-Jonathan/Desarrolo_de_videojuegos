using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Pistol : MonoBehaviour
{
    [SerializeField] private Vector3 movimiento;
    //[SerializeField] private float speed;
    [SerializeField] private float timeDestroy;

    // Start is called before the first frame update
    void Start()
    {
    timeDestroy += Time.time; 
    }

    // Update is called once per frame
    void Update()
    {
        if (timeDestroy <= Time.time)
        {
            BulletDestroy();
        }
    }

    private void BulletDestroy()
    {
        Destroy(gameObject);
    }
}
