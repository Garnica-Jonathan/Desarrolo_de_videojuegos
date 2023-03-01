using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    [SerializeField] private int startWipoints;
    [SerializeField] private float speed;
    [SerializeField] private float speedRotation;
    [SerializeField] private float distanciaWaipoints;
    
    //[SerializeField]private Transform[] m_waipoints;
    private Transform[] m_waipoints;
    private int m_currentIndex;

    private void Awake()
    {
        /*if (startWipoints > m_waipoints.Length)
        {
            startWipoints = 0;
        }

        m_currentIndex = startWipoints;*/

        
    }
    private void Start()
    {
        m_currentIndex = Random.Range(0, m_waipoints.Length);
    }
    public void RecibeWaipont(Transform[] p_waiponts)
    {
        m_waipoints = p_waiponts;
    }
    private void Update()
    {
        Patrol();
    }

    private void Move(Vector3 p_direction)
    {
        transform.position += p_direction * (speed * Time.deltaTime);
    }
    private void Patrol()
    {
        var l_currentWaipoint = m_waipoints[m_currentIndex];
        var l_currentDiference = l_currentWaipoint.position - transform.position;
        var l_lookWaiponts = Quaternion.LookRotation(l_currentDiference);
        transform.rotation = Quaternion.Lerp(transform.rotation, l_lookWaiponts, speedRotation * Time.deltaTime);
        var l_direction = l_currentDiference.normalized;
        Move(l_direction);
        var l_currDistance = l_currentDiference.magnitude;
        if (l_currDistance <= distanciaWaipoints)
        {
            NextWiponts();
        }
    }

    private void NextWiponts()
    {
        m_currentIndex++;
        if(m_currentIndex > m_waipoints.Length -1)
        {
            m_currentIndex = 0;
        }
    }










}
