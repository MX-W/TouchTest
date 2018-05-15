using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour {

    private GameObject countField;
    private Text counter, position, direction, eventText;

	// Use this for initialization
	void Start () {
        countField = GameObject.Find("DisplayText");
        counter = countField.GetComponent<Text>();

        GameObject positionField = GameObject.Find("Position");
        position = positionField.GetComponent<Text>();

        GameObject directionField = GameObject.Find("Direction");
        direction = directionField.GetComponent<Text>();

        GameObject eventField = GameObject.Find("Event");
        eventText = eventField.GetComponent<Text>();
    }

    // Update is called once per frame
    /*void Update () {
        int fingerCount = 0;
        foreach (Touch touch in Input.touches)
        {

            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }                

            if (Input.touchCount <= 1)
            {

                if (touch.deltaPosition.x > 2 && touch.deltaPosition.y > 2)
                {
                    direction.text = "Bewegung: nach rechts oben";
                    break;
                }
                else if (touch.deltaPosition.x > 2 && touch.deltaPosition.y > -2)
                {
                    direction.text = "Bewegung: nach rechts unten";
                    break;
                }
                else if (touch.deltaPosition.y > 2 && touch.deltaPosition.x > -2)
                {
                    direction.text = "Bewegung: nach links oben";
                    break;
                }
                else if (touch.deltaPosition.y > -2 && touch.deltaPosition.x > -2)
                {
                    direction.text = "Bewegung: nach links unten";
                    break;
                } else if (touch.deltaPosition.x > 2)
                {
                    direction.text = "Bewegung: nach rechts";
                    break;
                } else if (touch.deltaPosition.x > -2)
                {
                    direction.text = "Bewegung: nach links";
                    break;
                } else if (touch.deltaPosition.y > 2)
                {
                    direction.text = "Bewegung: nach oben";
                    break;
                } else if (touch.deltaPosition.y > -2)
                {
                    direction.text = "Bewegung: nach unten";
                    break;
                }


                position.text = "Position: " + touch.position;

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        eventText.text = "Event: Touch Start";
                        break;
                    case TouchPhase.Moved:
                        eventText.text = "Event: Finger bewegt sich";
                        break;
                    case TouchPhase.Ended:
                        eventText.text = "Event: Touch Ende";
                        break;
                    case TouchPhase.Stationary:
                        eventText.text = "Event: Finger bewegt sich nicht";
                        break;
                    case TouchPhase.Canceled:
                        eventText.text = "Event: Touch abgebrochen";
                        break;
                    default:
                        eventText.text = "Event: ";
                        break;
                }
            }

        }

        if (fingerCount > 0)
            counter.text = "User has " + fingerCount + " finger(s) touching the screen";

    }*/

    // Update is called once per frame
    void Update()
    {
        bool start = false;
        if(Input.touchCount > 1)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);
            if(touch2.phase == TouchPhase.Began)
            {
                start = true;
            }

            if(start == true)
            {
                if(touch1.position.x > touch2.position.x)
                {
                    if(touch1.position.y > touch2.position.y)
                    {
                        if(touch1.position.x - touch2.position.x <= 250)
                        {
                            eventText.text = "Event: Touch1 ist größer als Touch2!";
                        }
                    }
                }


                start = false;
            }
        }
    }
}
 