using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : CharacterLife
{
    [SerializeField] private Slider m_staminaSlider;
    //[SerializeField] private float m_staminaMax= 100;
    //private float m_regenerateStaminaTime= 0.1f;
    //private float m_amountRegenerate= 2;
    //private float m_losingStaminaTime = 0.1f;
    private float m_currentStamina;
    private Coroutine myCoroutineLosing;
    private Coroutine myCoroutineRegenerate;
    // Start is called before the first frame update
    void Start()
    {
        m_currentStamina = characterData.m_staminaMax;
        m_staminaSlider.maxValue = characterData.m_staminaMax;
        m_staminaSlider.value = characterData.m_staminaMax;
    }

    // Update is called once per frame
    void Update()
    {
        BarrStamina();
        MoveAndJump();
    }

    public void UseStamina(float amount)
    {
        if (m_currentStamina-amount > 0)
        {
            if (myCoroutineLosing != null)
            {
                StopCoroutine(myCoroutineLosing);
            }
            myCoroutineLosing = StartCoroutine(LosingStaminaCoroutine(amount));

            if (myCoroutineRegenerate != null)
            {
                StopCoroutine(myCoroutineRegenerate);
            }
            myCoroutineRegenerate = StartCoroutine(RegenerateStaminaCoroutine());
        }
        else
        {
            GetComponent<CharacterMain>().isSprinting = false;

        }
    }

    private IEnumerator LosingStaminaCoroutine(float amout)
    {
        while (m_currentStamina >= 0)
        {
            m_currentStamina -= amout;
            m_staminaSlider.value = m_currentStamina;

            yield return new WaitForSeconds(characterData.m_losingStaminaTime);
        }
        myCoroutineLosing= null;

        GetComponent<CharacterMain>().isSprinting = false;
    }

    private IEnumerator RegenerateStaminaCoroutine()
    {
        yield return new WaitForSeconds(1);

        while (m_currentStamina < characterData.m_staminaMax)
        {
            m_currentStamina += characterData.m_amountRegenerate;

            m_staminaSlider.value = m_currentStamina;

            yield return new WaitForSeconds(characterData.m_regenerateStaminaTime);
        }
        myCoroutineRegenerate= null;
    }
}
