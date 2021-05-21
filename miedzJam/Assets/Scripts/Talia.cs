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

    // Start is called before the first frame update
    void Start()
    {
        UstawTalie();
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
                if (karty[random].CzyMozliwa(game) == true)
                {
                    var myNewSmoke = Instantiate(karty[random], transform);
                    myNewSmoke.transform.parent = gameObject.transform;

                    if(karty[random].czyUsuwanaZTali == true)
                    {
                        UsunKarte(random, karty);
                    }

                    break;
                }
            }
        }
    }

    void UstawTalie()
    {
                
    }

    void UsunKarte(int x, KartaWydarzenia[] karty)
    {
        int licznik = 0;
        int licznik2 = 0;
        KartaWydarzenia[] karty1 = new KartaWydarzenia[karty.Length-1];
        foreach( KartaWydarzenia k in karty)
        {
            if(x!=licznik)
            {
                karty1[licznik2] = karty[licznik];
                licznik2++;
            }
            licznik++;
        }
        karty = karty1;
    }

}
