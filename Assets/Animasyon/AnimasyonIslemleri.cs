using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimasyonIslemleri : MonoBehaviour
{
    Animator controlcuBaba;
    // Start is called before the first frame update
    void Start()
    {
        controlcuBaba = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            controlcuBaba.SetBool("benim_b", true);
            // controlcuBaba.SetTrigger("benim_t");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            controlcuBaba.SetBool("benim_b", false);
            // bool gelenBool = controlcuBaba.GetBool("benim_b");

            // if (gelenBool)
            // {
            //     controlcuBaba.SetBool("benim_b", false);
            // }
            // else
            // {
            //     controlcuBaba.SetBool("benim_b", true);
            // }


        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            controlcuBaba.ResetTrigger("ikinciTetik");
            controlcuBaba.SetTrigger("benim_t");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            controlcuBaba.ResetTrigger("benim_t");
            controlcuBaba.SetTrigger("ikinciTetik");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            controlcuBaba.SetInteger("benim_i", 2);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            controlcuBaba.SetTrigger("ucuncuTetik");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            controlcuBaba.SetTrigger("dorduncuTetik");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            controlcuBaba.SetFloat("benim_f", 2);
        }
    }
    // private void OnAnimatorMove()
    // {
    //     Vector3 poz = transform.position;
    //     poz.x += controlcuBaba.GetFloat("benim_f") * Time.deltaTime;
    //     transform.position = poz;
    // }
    public void Selamla(string deger)
    {
        print("Selamla " + deger);
    }
}
