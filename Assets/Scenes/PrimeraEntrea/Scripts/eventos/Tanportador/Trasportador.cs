using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasportador : MonoBehaviour
{
    public Activar_transportador tranporte;
    public Animator cube;
    void Start()
    {
        tranporte.onTransportador.AddListener(Transportador);
        //tranporte.onTransportador += Transportador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Transportador(bool activar)
    {
        cube.SetBool("mover", activar);
    }
}
