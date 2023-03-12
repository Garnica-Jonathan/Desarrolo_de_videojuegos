using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLife : JumpRaycast
{
    [SerializeField] private Button m_damage;
    [SerializeField] private Image m_barra;
    public float maxHealtLife;
    public float _m_currentHealt;

    private void Awake()
    {
        maxHealtLife = m_maxHealt;
        _m_currentHealt = m_maxHealt;
        //m_damage.onClick.AddListener(Damage());//Me dice que no esta instanciado el objecto pero igual funciona

        
    }
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        BarrStamina();
        MoveAndJump();
    }

    public event Action<float> OnHealtChange;


    [ContextMenu(itemName:"recibe damage")]
    private void RecibeDamage()
    {
        Damage(1);
    }
    protected void BarrStamina()
    {
        m_barra.fillAmount = _m_currentHealt / maxHealtLife;
    }
    public void Damage(float p_damage)
    {
        _m_currentHealt -= p_damage;
        if (_m_currentHealt < 0)
        {
            _m_currentHealt = 0;
        }
        OnHealtChange?.Invoke(_m_currentHealt);
    }
}
