using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seen : MonoBehaviour
{
    public GameObject BoxLock;
    public GameObject Lid;
    public GameObject Death;
    float currentTime = 0f;
    float startingTime = 120f;

    public AudioClip clip;
    private AudioSource source;

    public bool sight = false;

    void Start()
    {
        currentTime = startingTime;
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (sight == false)
        {
            currentTime -= 1 * Time.deltaTime;
            //print(currentTime);
        }
        events();
        if (currentTime < -2.5)
        {
            Death.GetComponent<WinLose>().dead = true;
        }
    }

    public void events()
    {
        BoxLock.GetComponent<Lock>().UnLock = false;
        Lid.GetComponent<Lid>().Open = false;
        //first knocking
        if (currentTime > 99.99 && currentTime < 100)
        {
            source.PlayOneShot(clip);
        }
        //unlock Box
        if (currentTime > 59.99 && currentTime < 60)
        {
            BoxLock.GetComponent<Lock>().UnLock = true;
        }

        if (currentTime > 0 && currentTime < 50 && sight == false)
        {
            Lid.GetComponent<Lid>().Open = true;
        }
        if(currentTime > -2 && currentTime < -1.99)
        {
            source.PlayOneShot(clip);
        }
    }
}
