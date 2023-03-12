using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class dad : MonoBehaviour
{
    //private Image m_barra;
    public Animator animator;
    //[SerializeField] private TMP_Text text;
    public puerta life;
    public float _maxHealtLife;
    public float currentHealt;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {

        life.OnCollisionEnter += ews;
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
    
    public void ews(bool asd)
    {
        animator.SetBool("abrir", asd);
    }
}
