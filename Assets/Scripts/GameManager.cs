using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private bool gameIsStop = false;

    public Rotator rotator;
    public Swapner swapner;

    public Animator animator;

    public void endGame()
    {
        if (gameIsStop) // kod bir defa buraya girdiginde sadece Debug.Log("end game!!!"); bir defa çalışır ondan sonra hep return olur
            return;

        rotator.enabled = false;
        swapner.enabled = false;

        animator.SetTrigger("EndGame");
        gameIsStop = true;
        
    }

    public void ResetLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //bu en son kaldıgı levelden başlatır- index alıyor /SceneManager.LoadScene(0)
    }
}
