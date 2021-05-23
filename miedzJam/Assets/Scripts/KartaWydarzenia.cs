using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KartaWydarzenia : MonoBehaviour
{
    public Game game;
    public Talia talia;

    public int iloscWTalii;
    public bool czyUsuwanaZTali;

    public Text nazwa;
    public Text opis;

    public string PodajNazwe;
    public string PodajOpis;

    //Statystyki po wydarzeniu//
    public int miedz1;
    public int srebro1;
    public int zadowolenie1;
    public int energia1;
    public int zanieczyszczenie1;
    public int gornicy1;
    public int roboty1;
    public int wynagrodzenie1;
    public int elektrownieWeglowe1;
    public int elektrownieWiatrowe1;
    public int zuzycieEnergi1;
    public int poziomWydobycia1;
    public int idNastepnejKartyOpcja1;

    //Warunki//
    public int iloscMiedziWiekszaNiz;
    public int iloscMiedziMniejszaNiz;
    public int iloscSrebraWiekszaNiz;
    public int iloscSrebraMniejszaNiz;
    public int iloscZadowoleniaWiekszaNiz;
    public int iloscZadowoleniaMniejszaNiz;
    public int iloscEnergiWiekszaNiz;
    public int iloscEnergiMniejszaNiz;
    public int iloscZanieczyszczeniaWiekszaNiz;
    public int iloscZanieczyszczeniaMniejszaNiz;
    public int iloscGornikowWiekszaNiz;
    public int iloscGornikowMniejszaNiz;
    public int iloscRobotowWiekszaNiz;
    public int iloscRobotowMniejszaNiz;
    public int iloscWynagrodzeniaWiekszaNiz;
    public int iloscWynagrodzeniaMniejszaNiz;
    public int iloscElektrowniWeglowychWiekszaNiz;
    public int iloscElektrowniWeglowychMniejszaNiz;
    public int iloscElektrowniWiatrowychWiekszaNiz;
    public int iloscElektrowniWiatrowychMniejszaNiz;
    public int iloscZuzyciaEnergiWiekszaNiz;
    public int iloscZuzyciaEnergiMniejszaNiz;
    public int wymaganyPoziomWydobyciaWiekszyNiz;
    public int wymaganyPoziomWydobyciaMniejszyNiz;

    private void Start()
    {
        nazwa.text = PodajNazwe;
        opis.text = PodajOpis;
        game = GetComponentInParent<Game>();
        talia = GetComponentInParent<Talia>();
    }

    public void OpcjaA()
    {
        game.idNastepnejKarty = idNastepnejKartyOpcja1;
        game.ZmienIloscMiedzi(miedz1);
        game.ZmienIloscSrebra(srebro1);
        game.ZmienIloscZadowolenia(zadowolenie1);
        game.ZmienIloscEnergii(energia1);
        game.ZmienIloscZanieczyszczenia(zanieczyszczenie1);
        game.ZmienIloscGornikow(gornicy1);
        game.ZmienIloscRobotow(roboty1);
        game.ZmienIloscWynagrodzenia(wynagrodzenie1);
        game.ZmienIloscElektrowniWeglowych(elektrownieWeglowe1);
        game.ZmienIloscElektrowniWiatrowych(elektrownieWiatrowe1);
        game.ZmienIloscZuzyciaEnergi(zuzycieEnergi1);
        game.ZmienIloscPoziomuWydobycia(poziomWydobycia1);
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

    private bool Porownaj(int x, int z, int y)
    {
        if (x >= y && (x <= z || z == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CzyMozliwa(Game game)
    {
        if (Porownaj(game.miedzValue, iloscMiedziMniejszaNiz, iloscMiedziWiekszaNiz) == true)
        {
            if (Porownaj(game.srebroValue, iloscSrebraMniejszaNiz, iloscSrebraWiekszaNiz) == true)
            {
                if (Porownaj(game.zadowolenieValue, iloscZadowoleniaMniejszaNiz, iloscZadowoleniaWiekszaNiz) == true)
                {
                    if (Porownaj(game.energiaValue, iloscEnergiMniejszaNiz, iloscEnergiWiekszaNiz) == true)
                    {
                        if (Porownaj(game.zanieczyszczenieValue, iloscZanieczyszczeniaMniejszaNiz, iloscZanieczyszczeniaWiekszaNiz) == true)
                        {
                            if (Porownaj(game.gornicyValue, iloscGornikowMniejszaNiz, iloscGornikowWiekszaNiz) == true)
                            {
                                if (Porownaj(game.robotyValue, iloscRobotowMniejszaNiz, iloscRobotowWiekszaNiz) == true)
                                {
                                    if (Porownaj(game.wynagrodzenieValue, iloscWynagrodzeniaMniejszaNiz, iloscWynagrodzeniaWiekszaNiz) == true)
                                    {
                                        if (Porownaj(game.elektrownieWegloweValue, iloscElektrowniWeglowychMniejszaNiz, iloscElektrowniWeglowychWiekszaNiz) == true)
                                        {
                                            if (Porownaj(game.elektrownieWiatroweValue, iloscElektrowniWiatrowychMniejszaNiz, iloscElektrowniWiatrowychWiekszaNiz) == true)
                                            {
                                                if (Porownaj(game.zuzycieEnergiValue, iloscZuzyciaEnergiMniejszaNiz, iloscZuzyciaEnergiWiekszaNiz) == true)
                                                {
                                                    if (Porownaj(game.poziomWydobyciaValue, wymaganyPoziomWydobyciaMniejszyNiz, wymaganyPoziomWydobyciaWiekszyNiz) == true)
                                                    {
                                                        return true;
                                                    }
                                                    else
                                                    {
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
