using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Globalization;

public class UI_Manager : MonoBehaviour
{
    public GameObject Cube;//prefab
    public GameObject Sphere;
    public Transform spawnLoc; //spawner location
    public Transform spawnLoc2;

    public GameObject plane;
    public Slider slider;
    public Text Score;
   

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    public void SpawnSphere()
    {
        //random spawn 
        Vector3 randomSpawn = new Vector3(spawnLoc2.position.x + Random.Range(-10, 10), spawnLoc2.position.y, spawnLoc2.position.z + Random.Range(-10, 10));
        //creates clone of cube prefab
        Instantiate(Sphere, randomSpawn, spawnLoc2.rotation);

        //spawn with random scaling and multiply
        //multiply by vector 
        Sphere.transform.localScale = Vector3.one * Random.Range(1.0f, 2.0f);

        string Stemp = Score.text;
        int Itemp = Int32.Parse(Stemp);
        Itemp += 30;
        Stemp = Itemp.ToString();
        Score.text = Stemp;

    }

    public void SpawnCube()
    {
        //random spawn 
        Vector3 randomSpawn = new Vector3(spawnLoc.position.x + Random.Range(-20, 20), spawnLoc.position.y, spawnLoc.position.z + Random.Range(-20, 20));
        //creates clone of cube prefab
        Instantiate(Cube, randomSpawn, spawnLoc.rotation);

        //spawn with random scaling and multiply
        //multiply by vector 
        Cube.transform.localScale = Vector3.one * Random.Range(0.1f, 2.0f);

        string Stemp = Score.text;
        int Itemp = Int32.Parse(Stemp);
        Itemp += 10;
        Stemp = Itemp.ToString();
        Score.text = Stemp;

    }

    public void changeScenes(string scene) 
    {

        SceneManager.LoadScene(scene);
    
    }

    public void movePlane(float pos) 
    {

        plane.transform.position = new Vector3(pos, plane.transform.position.y, plane.transform.position.z);
    
    }
}
