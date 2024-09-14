using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterimScript : MonoBehaviour
{
    Animator animatorum;
    // Start is called before the first frame update
    void Start()
    {
        animatorum =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animatorum.SetBool("yurusun_mu", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animatorum.SetBool("yurusun_mu", false);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            animatorum.SetBool("normalkossun_mu", true);
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            animatorum.SetBool("normalkossun_mu", false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animatorum.SetBool("hizlikossun_mu", true);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animatorum.SetBool("hizlikossun_mu", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animatorum.SetTrigger("ziplasin_mi");
        }
    }
}
