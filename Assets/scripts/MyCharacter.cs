using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    [SerializeField] private string myNameCharacter;
    private string m_myName;
    public int age;
    public float health;
    public float damage;
    public float defense;
    [SerializeField]private Vector3 myPosition;


    private void Awake()
    {
        SetName("");
    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string GetName()/*Un metodo para devolver datos*/
    {
        return myNameCharacter;/*el return sirve para decile al metodo que devuelva dicho valor, en este caso devuelve un nombre*/
    }

    public void SetName(string asd) /*El void significa "vacio", lo que significa que se pone para no devolver ningun tipo de dato*/
    {
        myNameCharacter = asd;
    }
}
