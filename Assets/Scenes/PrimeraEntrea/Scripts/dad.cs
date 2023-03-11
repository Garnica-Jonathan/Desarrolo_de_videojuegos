using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dad : Entity
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetName()
    {
        return "mi nombre es " + entityName;
    }
}
