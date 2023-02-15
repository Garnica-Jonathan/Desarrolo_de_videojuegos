using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private float maxHealt;
    [SerializeField] private float currentHealt;
    // Start is called before the first frame update
    void Start()
    {
        currentHealt = maxHealt;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecibeDamage(float p_damage)
    {
        currentHealt -= p_damage;
    }

    public void RecibeHealing(float p_healing)
    {
        currentHealt += p_healing;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("OnTriggerEnter with " + other.gameObject.name);
    }
    
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

}
