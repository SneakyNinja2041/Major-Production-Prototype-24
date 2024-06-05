using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

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

    public int Points;

    public Transform WP;

    public float moveSpeed = 2f;

    

    private void Start()
    {      
        WP = OWP;

        // Passengers



    }

    private void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.R)) //Move to Red Station
        {
            WP = RWP;
        }

        if (Input.GetKeyDown(KeyCode.O)) //Move to Orange Station
        {
            WP = OWP;
        }

        if (Input.GetKeyDown(KeyCode.Y)) //Move to Yellow Station
        {
            WP = YWP;
        }

        if (Input.GetKeyDown(KeyCode.G)) //Move to Green Station
        {
            WP = GWP;
        }

        if (Input.GetKeyDown(KeyCode.B)) //Move to Blue Station
        {
            WP = BWP;
        }

        if (Input.GetKeyDown(KeyCode.L)) //Move to Purple Station
        {
            WP = PpWP;
        }

        if (Input.GetKeyDown(KeyCode.P)) //Move to Pink Station
        {
            WP = PkWP;
        }

        transform.position = Vector3.MoveTowards(transform.position, WP.transform.position, moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
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
            }
            Debug.Log("Arrived at PINK STATION");
        }


    }

}
