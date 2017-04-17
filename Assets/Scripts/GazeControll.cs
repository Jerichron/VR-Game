using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeControll : MonoBehaviour {

    public GameObject target;
    
    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && (hit.collider.gameObject == target))
        {
           // target.GetComponent<NavScript>().activate();
        }
        else
        {
           // target.GetComponent<NavScript>().deActivate();
        }
    }
    void SetRandomPosition()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);
        target.transform.position = new Vector3(x, 0.0f, z);
    }
}
