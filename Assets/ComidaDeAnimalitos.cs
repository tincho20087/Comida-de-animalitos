using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{
    public string animal;
    public int dias;    
    int gatos;
    int perritos;
    int perrotes;
    int plata;
    // Start is called before the first frame update
    void Start()
    {
      if (animal != "G" && animal != "PP" && animal != "PG")
{
    Debug.Log("Animal no válido, Gatos es G, Perros pequeños es PP y Perros Grandes es PG");
    return;
}
else if (dias < 3)
{
    Debug.Log("Cantidad de días no válida, el mínimo es 3");
    return;
}

if (animal == "G")
{
    gatos = dias * 300;
    Debug.Log("Para ese período se necesitan " + gatos + " gramos de alimento");
    gatos = gatos / 100;
    gatos = gatos * 80;
    Debug.Log("El precio final del alimento es " + gatos);
}
else if (animal == "PP")
{
    perritos = dias * 400;
    Debug.Log("Para ese período se necesitan " + perritos + " gramos de alimento");
    perritos = perritos / 100;
    perritos = perritos * 80;
    Debug.Log("El precio final del alimento es " + perritos);
}
else if (animal == "PG")
{
    perrotes = dias * 700;
    Debug.Log("Para ese período se necesitan " + perrotes + " gramos de alimento");
    perrotes = perrotes / 100;
    perrotes = perrotes * 80;
    Debug.Log("El precio final del alimento es " + perrotes);
}


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
