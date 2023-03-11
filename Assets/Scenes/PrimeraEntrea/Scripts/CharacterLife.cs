using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLife : JumpRaycast
{
    [SerializeField] private Button m_damage;
    [SerializeField] private Image m_barra;
    public float m_currentHealt;

    private void Awake()
    {
        m_currentHealt = m_maxHealt;
        m_damage.onClick.AddListener(Damage);//Me dice que no esta instanciado el objecto pero igual funciona

        
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
    protected void BarrStamina()
    {
        m_barra.fillAmount = m_currentHealt / m_maxHealt;
    }
    private void Damage()
    {
        m_currentHealt--;
        if (m_currentHealt < 0)
        {
            m_currentHealt = 0;
        }
    }
}
