using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputConsol : MonoBehaviour
{
    //public Text input1;
    public Text ConsolText;
    public InputField IputFueld1;
    public GoPlanets goPlanets;

    bool Vom = false;
    public string Vomsina = "";
    //public string ProverkaProduct;


    public void Start()
    {
        InputField IputFueld1 = GetComponent<InputField>();
        GoPlanets goPlanets = GetComponent<GoPlanets>();
    }



    
    public void ProverKAKA()
    {
        if(Vom)
            Vomsina = "спс '20'";

        if (IputFueld1.text.ToUpper() == "FFFF")
        {
            IputFueld1.text = "";
            ConsolText.text = "uwu";
        }

        else if(IputFueld1.text.ToUpper() == "1")
        {
            IputFueld1.text = "";
            ConsolText.text = "Выбран марс";
            goPlanets.Planets = 4;
            goPlanets.WAS = true;
        }
        /*
        else if (IputFueld1.text.ToUpper() == "2")
        {
            IputFueld1.text = "";
            ConsolText.text = "Выбран ГГ-1234с";
            goPlanets.Planets = 5;
            goPlanets.WAS = true;//Не забуду назначить
        }
        else if (IputFueld1.text.ToUpper() == "3")
        {
            IputFueld1.text = "";
            ConsolText.text = "Выбран Клуня";
            goPlanets.Planets = 4;//Не забуду назначить
            goPlanets.WAS = true;
        }
       */
        else if (IputFueld1.text.ToUpper() == "20")
        {
            IputFueld1.text = "";
            ConsolText.text = "спс";
            goPlanets.Planets = 1;//Не забуду назначить
            goPlanets.WAS = true;
        }

        else if (IputFueld1.text.ToUpper() == "ПЛАНЕТЫ")
        {
            IputFueld1.text = "";
            ConsolText.text = "Чтобы выбрать планету введите цыфру в '_'\nПланета марс '1'";
            goPlanets.Planets = 6;
        }

        else if(IputFueld1.text.ToUpper() == "ПОМОЩЬ")
        {
            IputFueld1.text = "";
            ConsolText.text = "ПЛАНЕТЫ-выбор плонет \nпомощь-для просмотра команд \n \n ";
        }
        else if (IputFueld1.text.ToUpper() == "STORE")
        {
            IputFueld1.text = "";
            ConsolText.text = "ФАНАРИК 15 \nПРО-ФАНАРИК 30\nЛопата 30 \nотмычка  20 \nингалятор 120\nГудок 150\nЧтобы купить ";
        }

        else if (IputFueld1.text.ToUpper() == "VOMSINA")
        {
            IputFueld1.text = "";
            ConsolText.text = "<3";
            Vom = true;
        }

        else
        {
            IputFueld1.text = "";
            ConsolText.text = "Неизвестная команда \nВведите помощь для просмотра команд";
        }
        //Эту страку написал 31 декабря в 23:16 
    }
}
