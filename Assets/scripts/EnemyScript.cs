using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private string m_myName;
    [SerializeField] private Vector3 movement;
    [SerializeField] private Vector3 direccion;
    public float healt;
    public float speed;
    public float damage;
    
    [SerializeField] private MyCharacter MyCharacter;


    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        TakeDamage(20);

        ReceiveLife(100);

        MovementDirection(1);

        Dire(1);

        m_myName = MyCharacter.GetName();
        /*character.health -= damage - character.defense;*/


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * movement; 
        transform.localScale += speed * direccion;   
        
    }

    public void ReceiveLife(float life)
    {
        healt = life;
    }

    public void TakeDamage(float attack)
    {
        damage = attack;
    }

    public void MovementDirection(Vector3 direction)
    {
        var movimiento = transform.position += movement;

        movimiento = direction;
        

    }
    
    public Vector3 Dire()
    {
        var movimiento = transform.position += movement;
        return movimiento;
    }

}
