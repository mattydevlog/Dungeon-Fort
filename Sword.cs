using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Sword : MonoBehaviour
{
    public GameObject player;
    public GameObject sword;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Sword");


            GameObject Clone = Instantiate(sword, transform.position, transform.rotation);
            Destroy(Clone, 0.25f);
        }
    }
}
