using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashControler : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;
    [SerializeField] GameObject hills;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SurfaceEffector2D se = hills.GetComponent<SurfaceEffector2D>();
        if (collision.tag == "Surface")
        {
            Invoke("reLoadScene",5f);
            se.speed = 1f;
            ps.Play();
        }
    }


    public void reLoadScene()
    {
        SceneManager.LoadScene(0);

    }

}
