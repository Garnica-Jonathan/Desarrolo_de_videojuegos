using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMichelle : MonoBehaviour
{
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            ActivateCube(false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            ActivateCube(true);
        }

    }

    private void ActivateCube(bool p_isActivate) 
    {
        /*animator.SetBool("TrapActivated", p_isActivate);*/
        animator.SetBool("Voltereta", p_isActivate);

    }
}
