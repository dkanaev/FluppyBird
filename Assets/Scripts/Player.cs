using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public float junmpForce;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * junmpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipePart"))
        {
            GameManager.instance.Lose();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
