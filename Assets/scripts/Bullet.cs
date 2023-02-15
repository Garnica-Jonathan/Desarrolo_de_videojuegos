using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 movimiento;
    [SerializeField] private float speed;
    [SerializeField] private float lifeTimeBullet;
    private float x;
    private float y;
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        lifeTimeBullet += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * movimiento;
        timeDestroy();
        //transform.localScale += scale * agrandar;

        //Enlarge();

    }

    private void timeDestroy()
    {
        /*lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            destroy();
        }*/
        if(lifeTimeBullet <= Time.time)
        {
            KillerBullet();
        }

    }

    private void KillerBullet()
    {
        //Debug.Log("destuido");
        Destroy(gameObject);
    }

    private void Enlarge()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            x += 0.1f;
            y += 0.1f;
            z += 0.1f;

            transform.localScale = new Vector3(x, y, z);
        }
    }
}
