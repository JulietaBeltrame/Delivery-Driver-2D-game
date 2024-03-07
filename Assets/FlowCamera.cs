using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowCamera : MonoBehaviour
{
    // Flow camera es para seguir al objeto principal (en este caso el auto) porque el mapa del juego es mas grande que el mapa en configuracion.
    //La posicion de la camara tiene que ser la misma que la del auto.
    [SerializeField] GameObject thingToFollow;
    
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
