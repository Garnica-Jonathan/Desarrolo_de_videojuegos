using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    [SerializeField] private float reduceX;
    [SerializeField] private float reduceY;
    [SerializeField] private float reduceZ;
    [SerializeField] private float sizeX;
    [SerializeField] private float sizeY;
    [SerializeField] private float sizeZ;
    [SerializeField] private float aaaa = 1.5f;
    [SerializeField] private float sssss = 3f;
    private float _currentTime;
    private float _currentwaitTe;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<HarryController>(out var l_harry))
        { 
            if (_currentTime <= Time.time) 
            {
                
                l_harry.Reduce(reduceX, reduceY, reduceZ);
                _currentTime = Time.time + aaaa;
            }
            if (_currentwaitTe <= Time.time)
            {
                _currentwaitTe = Time.time + sssss;
                l_harry.OriginalSize(sizeX, sizeY, sizeZ);
            }
            
            
           
        }

        
    }

}
