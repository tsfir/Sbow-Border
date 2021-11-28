using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashControler3 : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Surface")
        {
            Invoke("reLoadScene", 5f);
            ps.Play();
        }
    }


    public void reLoadScene()
    {
        SceneManager.LoadScene(0);
    }

}
