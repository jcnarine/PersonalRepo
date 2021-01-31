using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateStar : MonoBehaviour
{
    public float speedX = 0.1f;
    public float speedY = 0.1f;
    private float offX;
    private float offY;
    // Start is called before the first frame update
    void Start()
    {
        offX = GetComponent<Renderer>().material.mainTextureOffset.x;
        offY = GetComponent<Renderer>().material.mainTextureOffset.x;
    }

    // Update is called once per frame
    void Update()
    {
        offX += Time.deltaTime * speedX;
        offY += Time.deltaTime * speedY;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offX, offY));
    }
}
