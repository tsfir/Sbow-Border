using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashControler : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] GameObject hills;
    [SerializeField] GameObject camera1;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        SurfaceEffector2D se = hills.GetComponent<SurfaceEffector2D>();
        if (collision.gameObject.tag == "Surface")
        {
            Invoke("reLoadScene", 5f);
            ps.Play();
            GetComponent<AudioSource>().Play();

            camera1.GetComponent<AudioSource>().Stop();
            se.speed = 1f;
            
        }
    }


    public void reLoadScene()
    {
        SceneManager.LoadScene(0);

    }

}
