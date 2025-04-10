using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gustoDeHelado;
    public int cantidadDeHelado;
     int promocionConFrutilla = 10;
    float precioPorGramo = 0.5f;
    float precioHelado = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if(cantidadDeHelado > 3000 || cantidadDeHelado < 250) {
            Debug.Log("cantidad no valida");
            return;
        }
        if(gustoDeHelado == "CHO" || gustoDeHelado == "DDL")
        {
            precioHelado = cantidadDeHelado * precioPorGramo;
        } else if(gustoDeHelado == "FRU")
        {
            precioHelado = cantidadDeHelado * precioPorGramo;
            precioHelado -= (precioHelado * promocionConFrutilla) / 100;
        }
        else
        {
            Debug.Log("codigo no valido");
            return;
        }
        Debug.Log(precioHelado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
