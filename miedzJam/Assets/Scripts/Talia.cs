using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talia : MonoBehaviour
{
    public KartaWydarzenia[] karty;
    public Game game;
    public int licznikKart;
    public int coIleKartJestMiesiac;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LosujNowaKarte()
    {
        while(1==1)
        {
            int random = Random.Range(0, karty.Length);

            if(karty[random].CzyMozliwa(game)==true)
            { 
                var myNewSmoke = Instantiate(karty[random], transform);
                myNewSmoke.transform.parent = gameObject.transform;
                break;
            }
        }
    }

    void UstawTalie()
    {
        
    }
}
