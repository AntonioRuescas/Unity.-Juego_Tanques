using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public CuentaAtras countDown;
    public GameObject bullet;
    public GameObject npjCannon;
    public float npjImpulseForce;
    float npjReadyCannon;
    public float npjCadence;
 
    // Update is called once per frame
    void Update()
    {
        if (countDown.isCountingDown == true)
        {
            EnemyFire();            
        }
        
    }

    public void EnemyFire() {
        npjReadyCannon += Time.deltaTime;
        if (npjReadyCannon > npjCadence) { 
            GameObject Fire = Instantiate(bullet, npjCannon.transform.position, npjCannon.transform.rotation);
            Fire.GetComponent<Rigidbody>().AddForce(Fire.transform.forward * npjImpulseForce);
            npjReadyCannon = 0;
            Destroy(Fire, 2);
        }       
    }

}
