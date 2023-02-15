using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(GetMoveVector());
        RotateCharacter(GetRotateAmount());
    }

    private void Move(Vector3 moveDir)
    {
        /*var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var direccion = new Vector3(horizontal,0,vertical);

        transform.position += direccion * (speed * Time.deltaTime);
        */

        var transform1 = transform;
        transform1.position += (moveDir.x * transform1.right + moveDir.z * transform1.forward) * (speed * Time.deltaTime);
        }

    private void RotateCharacter(float rotateAmout)
    {
        /*if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1f, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -1f, 0);
        }*/
        transform.Rotate(Vector3.up, rotateAmout * Time.deltaTime * rotationSpeed, Space.Self);
    }

    private float GetRotateAmount()
    {
        return Input.GetAxis("Jump");
    }

    private Vector3 GetMoveVector()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("Vertical");

        return new Vector3 ( l_horizontal, 0 , l_vertical).normalized;
    }
}
