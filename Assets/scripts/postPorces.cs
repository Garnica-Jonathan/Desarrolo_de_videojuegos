using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class postPorces : MonoBehaviour
{
    [SerializeField] private Volume post;

    private void Awake()
    {
        var profile = post.profile;
        if(profile.TryGet(out LensDistortion distorsion))
        {
            distorsion.intensity.value = -0.66f;
        }
    }
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
