using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TrainMovement : MonoBehaviour
{
    //[SerializeField] private Transform[] waypoints;

    // Waypoint options
    [SerializeField] Transform PkWP;
    [SerializeField] Transform PpWP;
    [SerializeField] Transform OWP;
    [SerializeField] Transform YWP;
    [SerializeField] Transform BWP;
    [SerializeField] Transform GWP;
    [SerializeField] Transform RWP;

    public int RedPassengers = 0;
    public int OrangePassengers = 0;
    public int YellowPassengers = 0;
    public int GreenPassengers = 0;
    public int BluePassengers = 0;
    public int PurplePassengers = 0;
    public int PinkPassengers = 0;

    [SerializeField] GameObject RedCounter;
    [SerializeField] GameObject OrangeCounter;
    [SerializeField] GameObject YellowCounter;
    [SerializeField] GameObject GreenCounter;
    [SerializeField] GameObject BlueCounter;
    [SerializeField] GameObject PurpleCounter;
    [SerializeField] GameObject PinkCounter;

    public TextMeshProUGUI scoreText;

    public int Points;

    public Transform WP;

    public float moveSpeed = 2f;

    

    private void Start()
    {      
        WP = OWP;

        // Passengers


        // Reset Counter UI

        RedCounter.SetActive(false);
        OrangeCounter.SetActive(false);
        YellowCounter.SetActive(false);
        GreenCounter.SetActive(false);
        BlueCounter.SetActive(false);
        PurpleCounter.SetActive(false);
        PinkCounter.SetActive(false);
    }

    private void Update()
    {
        scoreText.text = "SCORE: " + Points;

        transform.position = Vector3.MoveTowards(transform.position, WP.transform.position, moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        // Collision with the stations

        if (other.CompareTag("Red"))
        {           
            if(RedPassengers > 0)
            {
                Points++;
                RedPassengers--;

                if (RedPassengers > 0)
                {
                    Points++;
                    RedPassengers--;

                    if (RedPassengers > 0)
                    {
                        Points++;
                        RedPassengers--;

                    }
                }

                RedCounter.SetActive(false);
            }

            Debug.Log("Arrived at RED STATION");
        }

        if (other.CompareTag("Orange"))
        {
            if (OrangePassengers > 0)
            {
                Points++;
                OrangePassengers--;

                if (OrangePassengers > 0)
                {
                    Points++;
                    OrangePassengers--;

                    if (OrangePassengers > 0)
                    {
                        Points++;
                        OrangePassengers--;

                    }
                }

                OrangeCounter.SetActive(false);

            }
            Debug.Log("Arrived at ORANGE STATION");
        }

        if (other.CompareTag("Yellow"))
        {
            if (YellowPassengers > 0)
            {
                Points++;
                YellowPassengers--;
                if (YellowPassengers > 0)
                {
                    Points++;
                    YellowPassengers--;
                    if (YellowPassengers > 0)
                    {
                        Points++;
                        YellowPassengers--;

                    }
                }

                YellowCounter.SetActive(false);
            }
            Debug.Log("Arrived at YELLOW STATION");
        }

        if (other.CompareTag("Green"))
        {
            if (GreenPassengers > 0)
            {
                Points++;
                GreenPassengers--;
                if (GreenPassengers > 0)
                {
                    Points++;
                    GreenPassengers--;
                    if (GreenPassengers > 0)
                    {
                        Points++;
                        GreenPassengers--;

                    }
                }

                GreenCounter.SetActive(false);
            }
            Debug.Log("Arrived at GREEN STATION");
        }

        if (other.CompareTag("Blue"))
        {
            if (BluePassengers > 0)
            {
                Points++;
                BluePassengers--;
                if (BluePassengers > 0)
                {
                    Points++;
                    BluePassengers--;
                    if (BluePassengers > 0)
                    {
                        Points++;
                        BluePassengers--;

                    }
                }

                BlueCounter.SetActive(false);
            }
            Debug.Log("Arrived at BLUE STATION");
        }

        if (other.CompareTag("Purple"))
        {
            if (PurplePassengers > 0)
            {
                Points++;
                PurplePassengers--;
                if (PurplePassengers > 0)
                {
                    Points++;
                    PurplePassengers--;
                    if (PurplePassengers > 0)
                    {
                        Points++;
                        PurplePassengers--;

                    }
                }

                PurpleCounter.SetActive(false);
            }
            Debug.Log("Arrived at PURPLE STATION");
        }

        if (other.CompareTag("Pink"))
        {
            if (PinkPassengers > 0)
            {
                Points++;
                PinkPassengers--;
                if (PinkPassengers > 0)
                {
                    Points++;
                    PinkPassengers--;
                    if (PinkPassengers > 0)
                    {
                        Points++;
                        PinkPassengers--;

                    }
                }

                PinkCounter.SetActive(false);
            }
            Debug.Log("Arrived at PINK STATION");
        }

        // Collision with the passengers

        if (other.CompareTag("PRed"))
        {
            RedPassengers++;
            RedCounter.SetActive(true);

            Debug.Log("RED PASSENGER!");
            Destroy(other.gameObject);
        }

        if (other.CompareTag("POrange"))
        {
            OrangePassengers++;
            OrangeCounter.SetActive(true);

            Debug.Log("ORANGE PASSENGER");
            Destroy(other.gameObject); 
        }

        if (other.CompareTag("PYellow"))
        {
            YellowPassengers++ ;
            YellowCounter.SetActive(true);

            Debug.Log("YELLOW PASSENGER");
            Destroy(other.gameObject);
        }

        if (other.CompareTag("PGreen"))
        {
            GreenPassengers++;
            GreenCounter.SetActive(true);

            Debug.Log("GREEN PASSENGER");
            Destroy(other.gameObject);
        }

        if (other.CompareTag("PBlue"))
        {
            BluePassengers++;
            BlueCounter.SetActive(true);

            Debug.Log("BLUE PASSENGER");
            Destroy(other.gameObject);
        }

        if (other.CompareTag("PPurple"))
        {
            PurplePassengers++;
            PurpleCounter.SetActive(true);

            Debug.Log("PURPLE PASSENGER");
            Destroy(other.gameObject);
        }

        if (other.CompareTag("PPink"))
        {
            PinkPassengers++;
            PinkCounter.SetActive(true);

            Debug.Log("PINK PASSENGER");
            Destroy(other.gameObject);
        }
    }

    public void MoveRed()
    {
        WP = RWP;
    }

    public void MoveOrange()
    {
        WP = OWP;
    }

    public void MoveYellow()
    {
        WP = YWP;
    }

    public void MoveGreen()
    {
        WP = GWP;
    }

    public void MoveBlue()
    {
        WP = BWP;
    }

    public void MovePurple()
    {
        WP = PpWP;
    }

    public void MovePink()
    {
        WP = PkWP;
    }


}
