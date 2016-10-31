using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class MovableHolidays
    {
        string bozeCialo = "BOŻE CIAŁO";
        string zeslDuchaSw = "Zesłanie Ducha Świętego";
        string wniebowstapienieNMP = "Wniebowstąpienie NMP";
        string wielkanoc = "WIELKANOC";
        string poniedzialekWielkanocny = "PONIEDZIAŁEK WIELKANOCNY";
        string niedzielaPalnowa = "Niedziela Palmowa";
        string popielec = "Popielec";
        string ostatki = "Ostatki";
        string tlustyCzwartek = "Tłusty czwartek";

        public string movableHol(DateTime now)
        {
            string todayHoliday;

            string bozeCialo17 = "2017-06-15";
            string zeslDuchaSw17 = "2017-06-04";
            string wniebowstapienieNMP17 = "2017-05-28";
            string wielkanoc17 = "2017-04-16";
            string poniedzialekWielkanocny17 = "2017-04-17";
            string niedzielaPalnowa17 = "2017-04-09";
            string popielec17 = "2017-03-01";
            string ostatki17 = "2017-02-28";
            string tlustyCzwartek17 = "2017-02-23";
            
            string bozeCialo18 = "2018-05-31";
            string zeslDuchaSw18 = "2018-05-20";
            string wniebowstapienieNMP18 = "2018-05-13";
            string wielkanoc18 = "2018-04-01";
            string poniedzialekWielkanocny18 = "2018-04-02";
            string niedzielaPalnowa18 = "2018-03-25";
            string popielec18 = "2018-02-14";
            string ostatki18 = "2018-02-13";
            string tlustyCzwartek18 = "2018-02-08";
            
            string bozeCialo19 = "2019-06-20";
            string zeslDuchaSw19 = "2019-06-09";
            string wniebowstapienieNMP19 = "2019-06-02";
            string wielkanoc19 = "2019-04-21";
            string poniedzialekWielkanocny19 = "2019-04-22";
            string niedzielaPalnowa19 = "2019-04-14";
            string popielec19 = "2019-03-06";
            string ostatki19 = "2019-03-05";
            string tlustyCzwartek19 = "2019-02-28";
            
            string bozeCialo20 = "2020-06-11";
            string zeslDuchaSw20 = "2020-05-31";
            string wniebowstapienieNMP20 = "2020-05-24";
            string wielkanoc20 = "2020-04-12";
            string poniedzialekWielkanocny20 = "2020-04-13";
            string niedzielaPalnowa20 = "2020-04-05";
            string popielec20 = "2020-02-26";
            string ostatki20 = "2020-02-25";
            string tlustyCzwartek20 = "2020-02-20";
            
            string bozeCialo21 = "2020-06-03";
            string zeslDuchaSw21 = "2020-05-23";
            string wniebowstapienieNMP21 = "2020-05-16";
            string wielkanoc21 = "2020-04-04";
            string poniedzialekWielkanocny21 = "2020-04-05";
            string niedzielaPalnowa21 = "2020-03-28";
            string popielec21 = "2020-02-17";
            string ostatki21 = "2020-02-16";
            string tlustyCzwartek21 = "2020-02-11";

            if (now.Year == 2017)
            {
                todayHoliday = now.Date.ToShortDateString().Equals(bozeCialo17) ? bozeCialo : null;
                todayHoliday = now.Date.ToShortDateString().Equals(zeslDuchaSw17) ? zeslDuchaSw : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wniebowstapienieNMP17) ? wniebowstapienieNMP : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wielkanoc17) ? wielkanoc : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(poniedzialekWielkanocny17) ? poniedzialekWielkanocny : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(niedzielaPalnowa17) ? niedzielaPalnowa : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(popielec17) ? popielec : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(ostatki17) ? ostatki : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(tlustyCzwartek17) ? tlustyCzwartek : todayHoliday;
            }

            else if (now.Year == 2018)
            {
                todayHoliday = now.Date.ToShortDateString().Equals(bozeCialo18) ? bozeCialo : null;
                todayHoliday = now.Date.ToShortDateString().Equals(zeslDuchaSw18) ? zeslDuchaSw : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wniebowstapienieNMP18) ? wniebowstapienieNMP : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wielkanoc18) ? wielkanoc : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(poniedzialekWielkanocny18) ? poniedzialekWielkanocny : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(niedzielaPalnowa18) ? niedzielaPalnowa : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(popielec18) ? popielec : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(ostatki18) ? ostatki : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(tlustyCzwartek18) ? tlustyCzwartek : todayHoliday;
            }

            else if (now.Year == 2019)
            {
                todayHoliday = now.Date.ToShortDateString().Equals(bozeCialo19) ? bozeCialo : null;
                todayHoliday = now.Date.ToShortDateString().Equals(zeslDuchaSw19) ? zeslDuchaSw : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wniebowstapienieNMP19) ? wniebowstapienieNMP : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wielkanoc19) ? wielkanoc : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(poniedzialekWielkanocny19) ? poniedzialekWielkanocny : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(niedzielaPalnowa19) ? niedzielaPalnowa : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(popielec19) ? popielec : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(ostatki19) ? ostatki : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(tlustyCzwartek19) ? tlustyCzwartek : todayHoliday;
            }

            else if (now.Year == 2020)
            {
                todayHoliday = now.Date.ToShortDateString().Equals(bozeCialo20) ? bozeCialo : null;
                todayHoliday = now.Date.ToShortDateString().Equals(zeslDuchaSw20) ? zeslDuchaSw : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wniebowstapienieNMP20) ? wniebowstapienieNMP : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wielkanoc20) ? wielkanoc : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(poniedzialekWielkanocny20) ? poniedzialekWielkanocny : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(niedzielaPalnowa20) ? niedzielaPalnowa : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(popielec20) ? popielec : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(ostatki20) ? ostatki : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(tlustyCzwartek20) ? tlustyCzwartek : todayHoliday;
            }

            else if (now.Year == 2021)
            {
                todayHoliday = now.Date.ToShortDateString().Equals(bozeCialo21) ? bozeCialo : null;
                todayHoliday = now.Date.ToShortDateString().Equals(zeslDuchaSw21) ? zeslDuchaSw : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wniebowstapienieNMP21) ? wniebowstapienieNMP : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(wielkanoc21) ? wielkanoc : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(poniedzialekWielkanocny21) ? poniedzialekWielkanocny : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(niedzielaPalnowa21) ? niedzielaPalnowa : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(popielec21) ? popielec : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(ostatki21) ? ostatki : todayHoliday;
                todayHoliday = now.Date.ToShortDateString().Equals(tlustyCzwartek21) ? tlustyCzwartek : todayHoliday;
            }
            else todayHoliday = null;

            return todayHoliday;
        }
    }
}
