using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swapner : MonoBehaviour
{
    [SerializeField]
    private GameObject pinPrefab;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            pinSwapn();
        }
    }

    void pinSwapn()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
