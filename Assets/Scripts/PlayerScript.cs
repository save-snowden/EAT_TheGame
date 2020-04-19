using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerScript : MonoBehaviour
{
    private Text scoreText;
    private int score = 0;

    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Fruit")
        {
            target.gameObject.SetActive(false);
            score++;
            scoreText.text = score.ToString();
            
        }
        if (target.tag == "Bomb")
        {
            transform.position = new Vector2(0, 100);
            target.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
        }



    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(1f);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex - 1);
    }
}















