using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;


    void Update()
    {
        transform.Rotate(0f, 0f, Time.deltaTime * speed);
        // zorlu seviler için Rotator'a animasyon ekleyerek hızını anlık azaltıp artıırabilirsin. ki yaptıkta.
    }
}
