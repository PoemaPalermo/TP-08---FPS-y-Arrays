using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int hambre;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Comer(int valorAlimentario)
    {
        hambre -= valorAlimentario;
        if (hambre <= 0)
        {
            hambre = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if (alimento)
        {
            Comer(alimento.valor);
            Destroy(other.gameObject);
        }
    }
}
