using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Harry_Character : MonoBehaviour
{
    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("Vertical");

        var direccion = new Vector3(l_horizontal, 0, l_vertical);

        transform.position = direccion * speed * Time.deltaTime;
    }
}
