using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing_Area : MonoBehaviour
{
    [SerializeField] private float HealingAmount;
    [SerializeField] private float TimeToHealt = 1f;
    private float _currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        
    }

    private void OnTriggerStay(Collider other)
    {
        /*var l_trigger = other.GetComponent<Trigger>();

        if (_currentTime <= Time.time && l_trigger != null)
        {
            _currentTime = Time.time + TimeToHealt;
            l_trigger.RecibeHealing(HealingAmount);
        }*/
        //La otra forma
        if(_currentTime <= Time.time && other.TryGetComponent<Trigger>(out var l_trigger))
        {
            _currentTime = Time.time + TimeToHealt;
            l_trigger.RecibeHealing(HealingAmount);
        }
    }
}
