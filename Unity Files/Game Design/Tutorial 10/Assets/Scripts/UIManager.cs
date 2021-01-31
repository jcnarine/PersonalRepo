using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image bar;
    public Text AmmoText;

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = ProjectileSpawner.Ammo / ProjectileSpawner.MaxAmmo;
        AmmoText.text = "Ammo:" + ProjectileSpawner.Ammo + "/" + ProjectileSpawner.MaxAmmo;
    }
}
