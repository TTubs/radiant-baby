using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Gamekit2D;
using TMPro;

public class Power : MonoBehaviour
{
    public Image bar;
    public Animator animator;
    public PlayerCharacter character;
    public TextMeshProUGUI text;


    private void Start()
    {
        //bar.fillAmount = 0;
        UpdateBar();
    }

    public void UpdateBar()
    {
        //bar.fillAmount = character.currentPower / 100f * character.maxPower;
        text.text = "" + character.currentPower;
        //animator.SetTrigger("gain");
    }

}
