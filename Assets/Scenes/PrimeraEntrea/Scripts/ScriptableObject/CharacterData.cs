using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Character/CharacterData")]
public class CharacterData : ScriptableObject
{
    public float Speed = 2;
    public float speedRotate = 45;
    public float m_staminaMax = 100;
    public float m_regenerateStaminaTime = 0.1f;
    public float m_amountRegenerate = 2;
    public float m_losingStaminaTime = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
