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
    private KartaWydarzenia[] prawdziwaTalia;
    private int licznik = 0;

    // Start is called before the first frame update
    void Start()
    {
        prawdziwaTalia = new KartaWydarzenia[20000];
        UstawTalie();
        usunieta = new bool[prawdziwaTalia.Length];
    }

    public void LosujNowaKarte()
    {
        while(1==1)
        {
            if(game.idNastepnejKarty!=0)
            {
                var myNewSmoke = Instantiate(pojedynczeKarty[game.idNastepnejKarty-1], transform);
                myNewSmoke.transform.parent = gameObject.transform;
                game.obecnaKarta = myNewSmoke;
                SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
                spriteRenderer.sortingOrder = 300;
                game.idNastepnejKarty = 0;
                break;
            }
            else
            {
                int random = Random.Range(0, licznik);
                if(usunieta[random]==false)
                {
                    if (prawdziwaTalia[random].CzyMozliwa(game) == true)
                    {
                        var myNewSmoke = Instantiate(prawdziwaTalia[random], transform);
                        myNewSmoke.transform.parent = gameObject.transform;
                        myNewSmoke.gameObject.layer = 30;
                        game.obecnaKarta = myNewSmoke;
                        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
                        spriteRenderer.sortingOrder = 300;

                        if (prawdziwaTalia[random].czyUsuwanaZTali == true)
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
        for(int i=0; i<karty.Length; i++)
        {
            for(int j=0; j<karty[i].iloscWTalii; j++)
            {
                prawdziwaTalia[licznik] = karty[i];
                licznik++;
            }
        }
    }
}
