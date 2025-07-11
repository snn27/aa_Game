using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int Pincont;
    public Text text;

    private void Start()
    {
        Pincont = 0;
    }

    void Update()
    {
        text.text = Pincont.ToString();
    }
}
