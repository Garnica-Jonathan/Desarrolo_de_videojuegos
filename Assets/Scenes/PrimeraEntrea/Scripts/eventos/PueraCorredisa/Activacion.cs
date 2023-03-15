using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activacion : MonoBehaviour
{
    private bool puertita;
    public UnityEvent<bool> OnCollisionEnter; //Evento con Unity
    //public event Action<bool> OnCollisionEnter;//Evento con c#
    

    
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
