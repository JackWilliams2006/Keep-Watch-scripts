using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{

    public List<Transform> wayPoints = new List<Transform>();
    public bool isMoving;
    public int WayPointIndex;
    public float moveSpeed;
    public float rotationSpeed;
    public GameObject Radio;
    public bool response = false;

    // Start is called before the first frame update
    void Start()
    {
        startMoving();
    }

    public void startMoving()
    {
        WayPointIndex = 0;
        isMoving = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (WayPointIndex > 6)
        {
            reset();
        }
        if (!isMoving)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(current: transform.position, target: wayPoints[WayPointIndex].position, maxDistanceDelta: Time.deltaTime * moveSpeed);

        var direction = wayPoints[WayPointIndex].position - transform.position;
        var targetRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

        request();

        var distance = Vector3.Distance(transform.position, wayPoints[WayPointIndex].position);
        if (distance < 0.05f)
        {
            WayPointIndex++;
        }
    }

    void reset()
    {
        transform.position = new Vector3(951, -39.96f, -546);
        transform.Rotate(0,0,0);
        WayPointIndex = 0;
    }

    void request()
    {
        if(WayPointIndex == 2)
        {
            Radio.GetComponent<RadioPlayer>().shipCall = true;
            print("Hi");
        }
        if(response == false && WayPointIndex > 4)
        {
            //penalty
        }
    }
}
