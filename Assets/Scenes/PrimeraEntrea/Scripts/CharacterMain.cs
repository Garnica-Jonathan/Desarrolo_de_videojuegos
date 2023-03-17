using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using static Unity.Burst.Intrinsics.X86;

public class CharacterMain : Entity
{
    [SerializeField] private Volume posst;
    [SerializeField] protected CharacterData characterData;
    //[SerializeField] private float speedRotate = 45;
    [SerializeField] private Animator ramonAnimator;
    [SerializeField] private CinemachineVirtualCamera terceraPersona;
    [SerializeField] private CinemachineVirtualCamera primeraPersona;
    [SerializeField] private Transform cameraAnchor = null;
    [SerializeField] private Transform cameraAnchorTwo = null;
    public bool isSprinting;
    [SerializeField] private float sprintingSpeed = 3f;
    private float sprintSpeed = 1;
    [SerializeField] private float stamineUseAmount = 5;
    private Stamina staminaSlider;



    // private static readonly int Speed = Animator.StringToHash("Speed");
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        characterData = GetComponent<CharacterData>();
        GameManager.LookCursor();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        AllInOne();

    }
    protected void AllInOne()
    {
        Rotate(GetRotationInput());
        MoveCharacter(GetMovementInput());

        ShootAndCamera();

        RunCheck();
    }

    private void ShootAndCamera()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
        
    }
    private void Rotate(Vector2 l_rotate)
    {
        transform.Rotate(Vector3.up, l_rotate.x * characterData.speedRotate * Time.deltaTime, Space.Self);

        Vector3 angle = cameraAnchor.eulerAngles;
        angle.x += l_rotate.y * characterData.speedRotate * Time.deltaTime;
        cameraAnchor.eulerAngles = angle;

        Vector3 anglee = cameraAnchorTwo.eulerAngles;
        anglee.x += l_rotate.y * characterData.speedRotate * Time.deltaTime;
        cameraAnchorTwo.eulerAngles = angle;

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
                                (characterData.Speed * Time.deltaTime) * sprintSpeed;
        ramonAnimator.SetFloat("Speed", p_movement.magnitude);

    }

    private void Shoot()
    {
            ramonAnimator.SetTrigger("Shoot");
    }

    //private void CameraController(CinemachineVirtualCamera oneCamera, CinemachineVirtualCamera twoCamera)
    //{
    //    oneCamera.gameObject.SetActive(true);
    //    twoCamera.gameObject.SetActive(false);
    //}

    private void SwitchCamera()
    {
        if (primeraPersona.gameObject.activeSelf)
        {
            terceraPersona.gameObject.SetActive(true);
            primeraPersona.gameObject.SetActive(false);
        }
        else
        {
            primeraPersona.gameObject.SetActive(true);
            terceraPersona.gameObject.SetActive(false);
        }

    }

    private void RunCheck()
    {
        var post = posst.profile;
        staminaSlider = GetComponent<Stamina>();
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            
           
            isSprinting = !isSprinting;

            if (isSprinting == true)
            {
                if (post.TryGet(out LensDistortion lens))
                {
                    lens.intensity.value = -0.66f;
                }
                staminaSlider.UseStamina(stamineUseAmount);
            }
            else
            {
                if (post.TryGet(out LensDistortion lens))
                {
                    lens.intensity.value = 0;
                }
                staminaSlider.UseStamina(0);
            }
        }

        if (isSprinting == true)
        {
            sprintSpeed = sprintingSpeed;
        }
        else
        {
            sprintSpeed = 1;
        }
    }
}
