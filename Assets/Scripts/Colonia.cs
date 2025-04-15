using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonia : MonoBehaviour
{
    public int juveniles;
    public int infantiles;
    int profesoresI;
    int profesoresJ;
    int profesoresT;
    int coordinadores;
    int listaEspera;
    int restanteProfe;

    // Start is called before the first frame update
    void Start()
    {
        if (juveniles < 0 || juveniles > 100)
        {
            Debug.Log("Maximo de suscritos 100, minimo 0. Reingrese valores.");
            return;
        }
        else if (infantiles < 0 || infantiles > 100)
        {
            Debug.Log("Maximo de suscritos 100, minimo 0. Reingrese valores.");
            return;
        }
        else
        {
            profesoresI = infantiles / 10;
            profesoresJ = juveniles / 20;
            listaEspera = juveniles % 20 + infantiles % 10;
            profesoresT = profesoresI + profesoresJ;
            coordinadores = profesoresT / 5;
            restanteProfe = profesoresT % 5;
            if (restanteProfe > 0)
            {
                coordinadores = coordinadores + 1;
            }
            else
            {
                coordinadores = coordinadores;
            }
            Debug.Log("Se necesitan " + profesoresJ + " profesores para los inscriptos juveniles.");
            Debug.Log("Se necesitan " + profesoresI + " profesores para los inscriptos infantiles.");
            Debug.Log("Se necesitan " + coordinadores + " coordinadores para los profesores.");
            Debug.Log("En la lista de espera se encuentran " + listaEspera + " suscriptos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
