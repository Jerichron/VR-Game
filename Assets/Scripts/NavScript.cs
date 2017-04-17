using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavScript : MonoBehaviour {

    public float rangeToPlayer;
    public GameObject player;
    public Camera sourceCam;
    public Transform target;
    private UnityEngine.NavMeshAgent agent;
    private bool active;
    void Start()
    {
        active = false;
        agent = GetComponent<UnityEngine.NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        //if (active == true)
        //{
        //    if (PlayerInRange())
        //    {
        ////        agent.enabled = !agent.enabled;
        //        GetComponent<NavScript>().enabled = false;
        //    }
        //    Ray ray = sourceCam.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
            //{
                agent.SetDestination(target.position);
            //}
        }
       // else
            //GetComponent<NavScript>().enabled = false;
    }
    //public void activate()
    //{
    //    //active = true;
    //    Debug.Log("statue is active");
    //}
    //public void deActivate()
    //{
    //    //active = false;
    //    Debug.Log("statue is inactive");
    //}
    //bool PlayerInRange()
    //{
    //    return (Vector3.Distance(player.transform.position, transform.position) <= rangeToPlayer); //Vector3.Distance(a,b) is the same as (a-b).magnitude.
    //}
//}
