using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win3 : MonoBehaviour
{
    private PlayerJump playerJump;

    // Start is called before the first frame update
    void Start()
    {
        playerJump = FindObjectOfType<PlayerJump>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerJump.SendCoinXHealthAnalytics();
            playerJump.CollectAnalytics("winScene");
            SceneManager.LoadScene("Win3");
        }
}
}
