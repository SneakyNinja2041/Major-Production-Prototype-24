using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PassengerSpawner : MonoBehaviour
{

    [SerializeField] GameObject RedPassenger;
    [SerializeField] GameObject OrangePassenger;
    [SerializeField] GameObject YellowPassenger;
    [SerializeField] GameObject GreenPassenger;
    [SerializeField] GameObject BluePassenger;
    [SerializeField] GameObject PurplePassenger;
    [SerializeField] GameObject PinkPassenger;
    [SerializeField] GameObject None;

    

    private GameObject PassToSpawn;

    [SerializeField] Transform SpawnPos;

    private int randomTemp;



    private void Start()
    {
        StartCoroutine(SpawnPass());


    }

    void Update()
    {
        

    }

    public void GetPassenger()
    {
        randomTemp = Random.Range(1, 20);

        if (randomTemp <= 2)
        {
            PassToSpawn = RedPassenger;
        }
        else if (randomTemp <= 4) 
        {
            PassToSpawn = OrangePassenger;
        }
        else if (randomTemp <= 6)
        {
            PassToSpawn = YellowPassenger;
        }
        else if (randomTemp <= 8)
        {
            PassToSpawn = GreenPassenger;
        }
        else if (randomTemp <= 10)
        {
            PassToSpawn = BluePassenger;
        }
        else if(randomTemp <= 12)
        {
            PassToSpawn = PurplePassenger;
        }
        else if (randomTemp <= 14)
        {
            PassToSpawn = PinkPassenger;
        }
        else
        {
            PassToSpawn = None;
            return;
        }


    }

    IEnumerator SpawnPass()
    {
        Debug.Log("Coroutine start!");
        yield return new WaitForSeconds(3);

        Debug.Log("TRY FOR PASSENGER");
        GetPassenger();

        if (PassToSpawn != None)
        {
            Debug.Log("SPAWN PASSENGER");
            Instantiate(PassToSpawn, SpawnPos);
            yield return new WaitForSeconds(7);
            StartCoroutine(SpawnPass());
        }
        else
        {
            Debug.Log("NO GUY SPAWNED");
            StartCoroutine(SpawnPass());
        }
        
        
    }

    


}
