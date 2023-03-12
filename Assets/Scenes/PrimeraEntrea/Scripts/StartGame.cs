using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Button m_start;

    
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        m_start.onClick.AddListener(NextScene);
    }
    public void NextScene()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
