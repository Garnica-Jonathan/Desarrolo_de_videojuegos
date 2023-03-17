using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Puerta : MonoBehaviour
{
    //private Image m_barra;
    public Animator puerta;
    //public Animator transportador;
    //[SerializeField] private TMP_Text text;
    public Activacion activacion;
    //public Transportador transporte;
    public float _maxHealtLife;
    public float currentHealt;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {

        //activacion.OnCollisionEnter += OpernDoor;
        activacion.OnCollisionEnter.AddListener(OpernDoor);
        //transporte.onTransportador += Transportador;
    }

    // Update is called once per frame
    void Update()
    {
        
        //m_barra.fillAmount = life.m_currentHealt / life.maxHealtLife;
        
    }
    /*private void OnTriggerEnter(Collider other)
    {

        animator.SetBool("abrir", true);
    }*/
    /*public void Vida(float asd)
    {
        text.text = $"mi vida es de: {asd}";
    }*/
    
    public void OpernDoor(bool asd)
    {
        puerta.SetBool("abrir", asd);
    }

    
}
