//(c) Samantha Stahlke 2020
//Created for INFR 2310.
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnityChanScript : MonoBehaviour
{  
    public Animator anim;
    public GameObject character;
    public ParticleSystem starEffect, heartEffect, lightningEffect;

    void Start()
    {
        anim.SetBool("isIdle", true);
    }
    public void playStarAnim() {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")) {
            anim.SetBool("isStar", true);
            anim.SetBool("isIdle", false);
            }
    }
    public void playHeartAnim() {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")) {
            anim.SetBool("isHeart", true);
            anim.SetBool("isIdle", false);
            }
    } 
    public void playLightningAnim() {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle")) {
            anim.SetBool("isLightning", true);
            anim.SetBool("isIdle", false);
            }
    }

    public void changeAnim(int i) {
        switch (i) { 
            case 0:
                anim.SetBool("isStar", false);
                anim.SetBool("isIdle", true);
                break;
            case 1:
                anim.SetBool("isHeart", false);
                anim.SetBool("isIdle", true);
                break;
            case 2:
                anim.SetBool("isLightning", false);
                anim.SetBool("isIdle", true);
                break;
            }
        }
    

    public void PlayStars() { 
            starEffect.Play(true);
    } 
    public void PlayHearts() { 
            heartEffect.Play(true);
    }
    public void PlayLightning() { 
            lightningEffect.Play(true);
    }

    private void Update()
    {

    }
}
