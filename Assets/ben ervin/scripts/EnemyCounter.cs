using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Gamekit2D;
using UnityEngine.Events;

public class EnemyCounter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public EnemyBehaviour[] enemies;
    public int count = 0;
    public UnityEvent Win;


    public void Start()
    {
        if (Win == null)
        {
            Win = new UnityEvent();
        }
        enemies = GameObject.FindObjectsOfType<EnemyBehaviour>();
        text.text = "" + enemies.Length;
        count = enemies.Length;
    }

    public void SumbractNumber()
    {
        count--;

        if (count == 0)
        {
            text.text = "" + count;
            Win.Invoke();
        }
        else
        {
            text.text = "" + count;
        }
    }
}
