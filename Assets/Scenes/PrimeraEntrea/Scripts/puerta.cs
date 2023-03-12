using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    //public Animator laPuerta;
    public bool puertita;
    public event Action<bool> OnCollisionEnter;
    /*private void OnTriggerEnter(Collider other)
    {
        laPuerta.SetBool("abrir", true);
        OnCollisionEnter?.Invoke(other);
    }*/

    
    private void OnTriggerEnter(Collider other)
    {
        asdasd(true);
    }

    private void OnTriggerExit(Collider other)
    {
        asdasd(false);
    }
    public void asdasd(bool asa)
    {
        puertita = asa;
        OnCollisionEnter?.Invoke(puertita);
    }
}
