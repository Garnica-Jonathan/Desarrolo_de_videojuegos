using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activar_transportador : MonoBehaviour
{
    [SerializeField] private bool transportador;
    public UnityEvent<bool> onTransportador;//Evento con Unity
    //public event Action<bool> onTransportador;//Evento con c#
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Transporte(true);
    }


    private void Transporte(bool p_transportador)
    {
        transportador = p_transportador;
        onTransportador?.Invoke(transportador);
    }





}
