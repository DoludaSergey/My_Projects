using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneCompany
{
    public class TCAllThread
    {
        static public string err;
        static public string rec;

        static public void Execute(TCallDetailRecord Caller)
        {
            ClearRec(Caller);//Очищаем поля
            MakeRecord(Caller);//Создаем новую запись звонка
            ShowRecord(Caller);//Формируем запись для вывода на экран
        }

        static public void MakeRecord(TCallDetailRecord Caller)
        {
            Random r = new Random();//экземпляр класса Random

            //генерируем номер абонента
            for (int i = 0; i < 7; i++)
                Caller._numA += (r.Next(9) + 1).ToString();

            //генерируем префикс
            if (r.Next(3) == 2)
                Caller._numB.Prefix = "8";//междугородний звонок
            else Caller._numB.Prefix = "10";//международний звонок

            //генерируем код(страна/город)
            if (Caller._numB.Prefix == "10")//если звонок международный
            {
                if (r.Next(3) != 2)
                    Caller._numB.CountryCode = "375";//код Белоруссии
                else Caller._numB.CountryCode = (r.Next(50) + 370).ToString();//случайный код
            }

            if (r.Next(7) != 2)
                Caller._numB.SityCode = "17";//код Минска
            else Caller._numB.SityCode = (r.Next(9) + 15).ToString();//случайный код

            int col;
            if (r.Next(7) != 2)
                col = 7;//семизначный номер
            else col = 8;//восьмизначный номер

            for (int i = 0; i < col; i++)
                Caller._numB.AbonNumber += (r.Next(9) + 1);//формируем номер абонента

            //заполняем детали записи
            Caller._date = DateTime.Now.AddDays(r.Next(-20, 20));
            Caller._time = DateTime.Now.AddMinutes(r.Next(-1000,1000));
            Caller._long = r.Next(180);
            Caller._tLineID.C = "Byelorussia";
            Caller._tLineID.O = Caller._numB.CountryCode;
            Caller._tLineID.I = Caller._numB.SityCode;
            Caller._tLineID.S = "Minsk";

        }

        //очищаем поля записи
        static private void ClearRec(TCallDetailRecord Caller)
        {
            Caller._numA = "";
            Caller._numB.CountryCode = "";
            Caller._numB.SityCode = "";
            Caller._numB.AbonNumber = "";
            Caller._date = DateTime.Now;
            Caller._time = DateTime.Now;
            Caller._long = 0;
            Caller._tLineID.C = "";
            Caller._tLineID.I = "";
            Caller._tLineID.O = "";
            Caller._tLineID.S = "";
            Caller._endRec = "#";
        }

        static private void ShowRecord(TCallDetailRecord Caller)
        {
            string numRecord;//строка для номера

            if (Caller._numB.Prefix == "10")
                numRecord = (Caller._numB.Prefix + "-" + Caller._numB.CountryCode + "-" + Caller._numB.SityCode +
                    "-" + Caller._numB.AbonNumber + "/");
            else
                numRecord = (Caller._numB.Prefix + "-" + Caller._numB.SityCode +
                    "-" + Caller._numB.AbonNumber + "/");

            rec = (Caller._numA + "/" + numRecord);
            rec += Caller._date.ToShortDateString() + "/" + Caller._time.ToShortTimeString() + "/" + Caller._long + "/" + Caller._endRec;
        }
    }
}
