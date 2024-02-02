using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    private PuanManag puanManag;
    private Menu menu;

    void Start()
    {
        puanManag = GameObject.Find("PuanM").GetComponent<PuanManag>();
  
        menu = GameObject.Find("CanvasContoroller").GetComponent<Menu>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Back")
        {
            puanManag.UpdatePuan(50);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
                menu.Olum();
         
        }
    }
}