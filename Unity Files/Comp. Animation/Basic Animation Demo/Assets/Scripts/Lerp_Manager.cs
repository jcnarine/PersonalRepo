using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;


public class Lerp_Manager : MonoBehaviour
	{

	//Related to Lerp
	public List<GameObject> listofPoints;
	public GameObject movingObject;
	public float t, segmentTime, startpos, speed = 0.2f;
	public int currentIndex, nextIndex;


    //Related to controlling UI
    public Button playButton, pauseButton, addButton, removeButton, loopButton;
    public Transform spawnRotate;
    public bool isPlaying, isLooping;
    public GameObject spherePoint;
    public Text positionX, positionY, positionZ;
    public Slider xSlider, ySlider, zSlider;
    public float pointX, pointY, pointZ;


    // Start is called before the first frame update
    public void Start()
        {

        isPlaying = false;
        isLooping = false;
        addButton.interactable = true;
        removeButton.interactable = false;
        playButton.interactable = true;
        pauseButton.interactable = false;

        t = 0;

        currentIndex = 0;

        nextIndex = 1;

        if (speed <= 0)
            speed = 1.0f;
        }

    // Update is called once per frame
    public void Update()
        {

        changeTextPosition();

        if (isPlaying)
            {

            if (listofPoints.Count > 1)

                {
                if (segmentTime > 0.0f)
                    t = Mathf.Min(t + Time.deltaTime / segmentTime, 1.0f);
                else
                    t = 1.0f;
                }

            movingObject.transform.position = Vector3.Lerp(listofPoints[currentIndex].transform.position, listofPoints[nextIndex].transform.position, t);

            if (t >= 1.0f)
                {

                currentIndex += 1;

                segmentLerp();

                if (!isLooping)
                    {
                        isPlaying = false;
                        pauseButton.interactable = false;
                        playButton.interactable = true;
                        movingObject.transform.position = listofPoints[0].transform.position;
                    }

                }
            }
        }
    void changeTextPosition()
        {
        positionX.text = Math.Round(xSlider.value, 2).ToString();
        positionY.text = Math.Round(ySlider.value, 2).ToString();
        positionZ.text = Math.Round(zSlider.value, 2).ToString();
        }

    public void playLerp()
        {
            if (listofPoints.Count > 2)
            isPlaying = true;
            playButton.interactable = false;
            pauseButton.interactable = true;
        }

    public void pauseLerp()
        {
            isPlaying = false;
            pauseButton.interactable = false;
            playButton.interactable = true;
        }

    public void remove()
        {
        if (listofPoints.Count > 0)
            {
            listofPoints.RemoveAt(listofPoints.Count - 0);
            }
        else
            {
            Debug.LogError("Error: Need to have one or more points to remove");
            }
        }

    public void add()
        {


        Vector3 spawnLocation = new Vector3(xSlider.value, ySlider.value, zSlider.value);

        GameObject tempG = Instantiate(spherePoint, spawnLocation, spawnRotate.rotation); ;
        listofPoints.Add(tempG);


        }

    public void loop()
        {
        if (isLooping)
            {
            loopButton.GetComponentInChildren<Text>(true).text = "Start Loop";
            isLooping = false;
            }
        else
            {
            loopButton.GetComponentInChildren<Text>(true).text = "End Loop";
            isLooping = true;
            }
        }

	public void segmentLerp()
		{

		if (listofPoints.Count < 2) { return; }

		if (currentIndex >= listofPoints.Count)
			{
			currentIndex = 0;
			}

		nextIndex = currentIndex + 1;
			

		float distance = Vector3.Magnitude(listofPoints[nextIndex].transform.position - listofPoints[currentIndex].transform.position);

		segmentTime = distance / speed;

		t = 0.0f;

		}

	}



