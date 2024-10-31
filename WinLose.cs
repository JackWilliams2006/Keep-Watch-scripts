using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 300f;
    public bool dead = false;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    // Start is called before the first frame update
    void Start()
    {
        CameraOne();
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime > 0 && dead == true)
        {
            CameraTwo();
        }
        if (currentTime < 0 && dead == false)
        {
            win();
        }
    }
    public void win()
    {
        CameraThree();
    }
    void CameraOne()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);

    }
    void CameraTwo()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);

    }
    void CameraThree()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);

    }
}
