using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyUp(KeyCode.J) )
        {
            TurnOnCamera(camera1, camera2 );
            Debug.Log("camara A");
        }
        
        else if (Input.GetKeyDown(KeyCode.J))
        {
            
            TurnOnCamera(camera2, camera1);
            Debug.Log("camara b");
        }
       
    }

    private void TurnOnCamera(CinemachineVirtualCamera cameraTurn, CinemachineVirtualCamera otherCamera)
    {
        cameraTurn.gameObject.SetActive(true);
        otherCamera.gameObject.SetActive(false);
    }
}
