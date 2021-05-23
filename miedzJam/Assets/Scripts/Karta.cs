using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karta : KartaWydarzenia
{
    public Text opis1;
    public Text opis2;
    public string PodajOpis1;
    public string PodajOpis2;

    //Statystyki po kliknieciu drugiej opcji//
    public int miedz2;
    public int srebro2;
    public int zadowolenie2;
    public int energia2;
    public int zanieczyszczenie2;
    public int gornicy2;
    public int roboty2;
    public int wynagrodzenie2;
    public int elektrownieWeglowe2;
    public int elektrownieWiatrowe2;
    public int zuzycieEnergi2;
    public int poziomWydobycia2;
    public int idNastepnejKartyOpcja2;

    private void Start()
    {
        nazwa.text = PodajNazwe;
        opis.text = PodajOpis;
        opis1.text = PodajOpis1;
        opis2.text = PodajOpis2;
        game = GetComponentInParent<Game>();
        talia = GetComponentInParent<Talia>();
    }

    public void OpcjaB()
    {
        game.idNastepnejKarty = idNastepnejKartyOpcja2;
        game.ZmienIloscMiedzi(miedz2);
        game.ZmienIloscSrebra(srebro2);
        game.ZmienIloscZadowolenia(zadowolenie2);
        game.ZmienIloscEnergii(energia2);
        game.ZmienIloscZanieczyszczenia(zanieczyszczenie2);
        game.ZmienIloscGornikow(gornicy2);
        game.ZmienIloscRobotow(roboty2);
        game.ZmienIloscWynagrodzenia(wynagrodzenie2);
        game.ZmienIloscElektrowniWeglowych(elektrownieWeglowe2);
        game.ZmienIloscElektrowniWiatrowych(elektrownieWiatrowe2);
        game.ZmienIloscZuzyciaEnergi(zuzycieEnergi2);
        game.ZmienIloscPoziomuWydobycia(poziomWydobycia2);
        Destroy(this.gameObject);
        talia.licznikKart++;
        if (talia.licznikKart % talia.coIleKartJestMiesiac == 0)
        {
            game.Miesiac();
        }
        game.WyswietlWynagrodzenie();
        game.WyswietlPoziomWydobycia();
        game.WyswietlZuzycieEnergii();
        if (game.CheckEndOrWin() == false)
        {
            talia.LosujNowaKarte();
        }
    }

    private bool Porownaj(int x, int y, int z)
    {
        if(x>=y && (x<=z||z==0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
