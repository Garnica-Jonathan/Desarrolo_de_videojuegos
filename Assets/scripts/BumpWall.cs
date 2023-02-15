using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BumpWall : MonoBehaviour
{
    [SerializeField] private Transform[] newPositions;
    public float x;
    public float y;
    public float z;
    [SerializeField] private float waitTime = 2f;
    private float _currentTimee;
    Vector3 pos;


    private void Start()
    {
        
    }

    private void Update()
    {

    }
    /*public Transform GetPosition()
    {
        return newPositions[Random.Range(0, newPositions.Length)];
    }*/
    public void RandomPosition()
    {
        
            
            x = Random.Range(-x, x);
            y = 5;
            z = Random.Range(-z, z);
            pos = new Vector3(x, y, z);
            transform.position = pos;
        
        
    }
    public void GetPosi()
    {
        
            _currentTimee = waitTime + Time.time;
            transform.rotation = Random.rotation;
        
            
    }

    /*public void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<BumpWall>(out var z_harry))
        {
            z_harry.GetPosition();
        }
        Debug.Log(GetPosition());
    }*/

}
