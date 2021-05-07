using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class HpBar : MonoBehaviour
{
    public GameObject hpBar;
    public GameObject display;
    private Damageable damageable;
    // Start is called before the first frame update
    void Start()
    {
        damageable = transform.GetComponentInParent<Damageable>();
        hpBar.transform.localScale = new Vector3(1, 0, 1);
    }

    public void UpdateHealth()
    {
        if (!display.gameObject.activeInHierarchy)
        {
            display.gameObject.SetActive(true);
        }

        float scale = (damageable.CurrentHealth - damageable.startingHealth) / 100f * damageable.startingHealth;
        hpBar.transform.localScale = new Vector3(1, scale, 1);

    }
}
