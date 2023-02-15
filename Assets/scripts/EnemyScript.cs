using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    public float healt;
    [SerializeField] private string m_myName;
    [SerializeField] private Vector3 movement;
    [SerializeField] private Vector3 direccion;
    private float vida;
    public float speed;
    public float damage;
    
    [SerializeField] private MyCharacter MyCharacter;


    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        healt = 100;
        
        

        m_myName = MyCharacter.GetName();
        /*character.health -= damage - character.defense;*/


    }

    // Update is called once per frame
    void Update()
    {
        ReceiveLife(1);
        TakeDamage(1);

        transform.position += movement;
        transform.localScale += direccion;

    }

    public void ReceiveLife(float life)
    {
        healt += vida;

        vida = life;

        
    }

    public void TakeDamage(float attack)
    {
        healt -= damage;

        damage = attack;
    }

    public void MovementDirection(float direction)
    {   
        

       



    }

}
