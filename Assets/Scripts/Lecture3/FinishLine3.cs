using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLine3 : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ps.Play();
            Invoke("reLoadScene", 8f);
        }
    }

    public void reLoadScene()
    {
        SceneManager.LoadScene(0);
        
    }
}
