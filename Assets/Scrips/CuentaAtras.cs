using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{

    //Creamos las variables que vamos a utilizar, en el inspector asignaremos el valor de tiempo que queremos y marcaremos el booleano como "true"
    public float time;
    public bool isCountingDown = true;
    public TextMesh message;
    public TextMesh messageTime;

    // Update is called once per frame
    void Update()
    {
        //Si el booleano IsCountingDown está marcado como true, se ejecutará el método en cada frame
        if (isCountingDown == true)
        {
            CountDown();
        }
    }
    //Creamos el método de cuenta atrás, cuando el tiempo es mayor a 0 se restará una unidad, cuando llega a 0 se mostrará el mensaje y se deshabilitará el booleano
    public void CountDown() {
       
        if (time - Time.deltaTime > 0)
        {
            time -= Time.deltaTime;
            //Añadimos el mensaje del tiempo que queda "in game"
            messageTime.text = "" + time.ToString("f2");
                
        }
        else
        {
            Debug.Log("Te has quedado sin gasolina");
            //Se deshabilita el tiempo que queda por pantalla y se habilita el mensaje que se muestra en consola
            messageTime.text = "";
            message.text = "Te has quedado sin gasolina";
            
            isCountingDown = false;
        }
    }
}