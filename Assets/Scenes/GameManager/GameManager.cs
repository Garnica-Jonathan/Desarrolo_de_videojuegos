using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text totalEnemykilled;
    public int totalKills;
    public GameObject enemyContainer;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        else
        {
            instance = this;
        }
    }
    private void Start()
    {
        totalKills = enemyContainer.GetComponentsInChildren<EnemyMichelle>().Length;
        totalEnemykilled.text = " Enemigos Totales" + totalKills.ToString();
    }
    public void AddEnemyKills()
    {
        totalKills--;
        totalEnemykilled.text = " Enemigos Totales" + totalKills.ToString();
    }
    public static void LookCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

}
