

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI.Table;
using Cursor = UnityEngine.Cursor;

public class HarryController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Animator harryAnimator;
    private static readonly int Speed = Animator.StringToHash("Speed");
    [SerializeField] private Camera m_camera;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float waitTime;
    private float _currentTimee;
    private void Start()
    {

    }

    private void OnApplicationFocus(bool hasFocus)
    {
        Cursor.visible = !hasFocus;
        Cursor.lockState = hasFocus ? CursorLockMode.None : CursorLockMode.Confined;
    }

    void Update()
    {
        Move(GetMovementInput());
        Rotate(GetRotationInput());
    }

    private void Rotate(Vector2 p_scrollDelta)
    {
        transform.Rotate(Vector3.up, p_scrollDelta.x * rotationSpeed * Time.deltaTime, Space.Self);
    }

    private Vector2 GetRotationInput()
    {
        var l_mouseX = Input.GetAxis("Mouse X");
        var l_mouseY = Input.GetAxis("Mouse Y");
        return new Vector2(l_mouseX, l_mouseY);
    }

    private Vector3 GetMovementInput()
    {
        var l_horizontal = Input.GetAxis("Horizontal");
        var l_vertical = Input.GetAxis("Vertical");
        return new Vector3(l_horizontal, 0, l_vertical).normalized;
    }

    private void Move(Vector3 p_inputMovement)
    {
        var transform1 = transform;
        transform1.position += (p_inputMovement.z * transform1.forward + p_inputMovement.x * transform1.right) *
                               (speed * Time.deltaTime);
        harryAnimator.SetFloat(Speed, p_inputMovement.magnitude);
    }

    public void Reduce(float reduceX, float reduceY, float reduceZ)
    {
        transform.localScale = new Vector3(reduceX, reduceY, reduceZ);
    }

    public void OriginalSize(float sizeX, float sizeY, float sizeZ)
    {
        transform.localScale = new Vector3(sizeX, sizeY, sizeZ);


    }


    public void OnTriggerEnter(Collider other)
    {
        if (_currentTimee <= Time.time && other.TryGetComponent<BumpWall>(out var z_harry))
        {
            _currentTimee = waitTime + Time.time;
            z_harry.RandomPosition();
            z_harry.GetPosi();

        }

    }
}

