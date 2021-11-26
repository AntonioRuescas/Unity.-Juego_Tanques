using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tanque : MonoBehaviour
{
    //Creamos las variables que vamos a necesitar y hacemos públicas las que vamos a utilizar en el inspector
    public float tankSpeed;
    public float rotationTankSpeed;
    public Cadencia cadende;
    //Creamos una variable CountDown, desde el scrip de CuentaAtras
    public CuentaAtras countDown;

    
    // Update is called once per frame
    void Update()
    {
        //Busco la variable IsCountingDown en el script de CuentaAtras y dependiendo de su estado, el tanque ejecutará los métodos asignados
        if (countDown.isCountingDown == true)
        {
            TankMove();
            cadende.Cadence();           
        }
        else
        {
            TankQuiet();
        }
    }

    //Creamos método para movimiento del tanque, el control es como los Resident Evil originales, en los que debias avanzar o retroceder en función de tu rotación
    public void TankMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * tankSpeed * Time.deltaTime, Space.Self);           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * tankSpeed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0) * rotationTankSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0) * rotationTankSpeed * Time.deltaTime);
        }
        
    }
    //Creamos un método vacio para asignarlo cuando se deshabilita el tiempo
    public void TankQuiet()
    {
    }  
    
}
