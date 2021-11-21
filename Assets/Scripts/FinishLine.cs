using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] GameObject hills;
    [SerializeField] Text score;
    float scoreValue = 0;
    bool ifWin = false;

    void Update()
    {
        if (ifWin == false)
        {
            scoreValue = scoreValue + Time.deltaTime;
            score.text = Mathf.FloorToInt(scoreValue).ToString();
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SurfaceEffector2D se = hills.GetComponent<SurfaceEffector2D>();
        if (collision.tag == "Player")
        {
            ifWin = true;
            se.speed = 1f;
            ps.Play();
            GetComponent<AudioSource>().Play();
            Invoke("reLoadScene", 8f);
        }
    }

    public void reLoadScene()
    {
        SceneManager.LoadScene(0);
        
    }
}
