using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float speedRotate;
    [SerializeField] private Animator ramonAnimator;
    [SerializeField] private CinemachineVirtualCamera terceraPersona;
    [SerializeField] private CinemachineVirtualCamera primeraPersona;
    // private static readonly int Speed = Animator.StringToHash("Speed");
    

    // Start is called before the first frame update
    void Start()
    {
          

    }

    // Update is called once per frame
    void Update()
    {
        Rotate(GetRotationInput());
        MoveCharacter(GetMovementInput());

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CameraController(terceraPersona, primeraPersona);
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            CameraController(primeraPersona, terceraPersona);
        }
    }

    private void Rotate(Vector2 l_rotate)
    {
        transform.Rotate(Vector3.up, l_rotate.x * speedRotate * Time.deltaTime, Space.Self);
    }
    private Vector2 GetRotationInput()
    {
        var l_mouseY = Input.GetAxis("Mouse Y");
        var l_mouseX = Input.GetAxis("Mouse X");
        return new Vector2(l_mouseX, l_mouseY);
    }
    private Vector3 GetMovementInput()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("Vertical");

        return new Vector3(l_horizontal,0,l_vertical).normalized;
    }
    private void MoveCharacter(Vector3 p_movement)
    {
        var transform1 = transform;
        transform1.position += (p_movement.z * transform1.forward + p_movement.x* transform1.right) *
                                (speed * Time.deltaTime);
        ramonAnimator.SetFloat("Speed", p_movement.magnitude);

    }

    private void Shoot()
    {
            ramonAnimator.SetTrigger("Shoot");
    }

    private void CameraController(CinemachineVirtualCamera oneCamera, CinemachineVirtualCamera twoCamera)
    {
        oneCamera.gameObject.SetActive(true);
        twoCamera.gameObject.SetActive(false);
    }
}
