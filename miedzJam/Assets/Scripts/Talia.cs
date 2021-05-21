using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talia : MonoBehaviour
{
    public KartaWydarzenia[] karty;
    public KartaWydarzenia[] pojedynczeKarty;
    public Game game;
    public int licznikKart;
    public int coIleKartJestMiesiac;
    private bool[] usunieta;

    // Start is called before the first frame update
    void Start()
    {
        UstawTalie();
        usunieta = new bool[karty.Length];
    }

    public void LosujNowaKarte()
    {
        while(1==1)
        {
            if(game.idNastepnejKarty!=0)
            {
                var myNewSmoke = Instantiate(pojedynczeKarty[game.idNastepnejKarty-1], transform);
                myNewSmoke.transform.parent = gameObject.transform;
                game.idNastepnejKarty = 0;
                break;
            }
            else
            {
                int random = Random.Range(0, karty.Length);
                if(usunieta[random]==false)
                {
                    if (karty[random].CzyMozliwa(game) == true)
                    {
                        var myNewSmoke = Instantiate(karty[random], transform);
                        myNewSmoke.transform.parent = gameObject.transform;

                        if (karty[random].czyUsuwanaZTali == true)
                        {
                            usunieta[random] = true;
                        }

                        break;
                    }
                }
            }
        }
    }

    void UstawTalie()
    {
                
    }
}
