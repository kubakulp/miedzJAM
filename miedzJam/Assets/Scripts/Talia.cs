using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talia : MonoBehaviour
{
    public Karta[] karty;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LosujNowaKarte()
    {
        int random = Random.Range(0, karty.Length);
        var myNewSmoke = Instantiate(karty[random], transform);
        myNewSmoke.transform.parent = gameObject.transform;
    }

    void UstawTalie()
    {
        
    }
}
