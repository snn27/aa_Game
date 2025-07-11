using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private float PinSpeed;
    private bool isPinned = false;

    public Rigidbody2D rb;
    void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * PinSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            Score.Pincont++; // her igne daireye girdiginde Pincont bir artar
            isPinned = true;
            //collision.GetComponent<Rotator>().speed *= -1; dayren,n bir sağa bir sorla dönmesini sağlar. hızını -1 ile çaptırıgn için.
        }
        else if(collision.tag == "Pin")
        {
            //SceneManager.LoadScene(0);
            FindAnyObjectByType<GameManager>().endGame();
        }
    }
}
