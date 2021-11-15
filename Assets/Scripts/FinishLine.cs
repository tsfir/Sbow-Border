using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] GameObject hills;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SurfaceEffector2D se = hills.GetComponent<SurfaceEffector2D>();
        if (collision.tag == "Player")
        {
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
