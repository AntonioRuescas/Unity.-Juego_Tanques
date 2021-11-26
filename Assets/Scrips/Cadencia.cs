using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cadencia : MonoBehaviour
{
    //Creamos las variables que vamos a necesitar
    public float cadence;
    float readyCannon;
    public GameObject bullet;
    public GameObject cannon;
    public float impulseForce;

    //Creamos metodo de cadencia de disparo al pulsar una tecla
    public void Cadence() 
    {
        readyCannon += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (readyCannon > cadence)
            {
                GameObject Fire = Instantiate(bullet, cannon.transform.position, cannon.transform.rotation);
                Fire.GetComponent<Rigidbody>().AddForce(Fire.transform.forward * impulseForce);
                readyCannon = 0;
                Destroy(Fire, 2);
            }
        }

    }
}
