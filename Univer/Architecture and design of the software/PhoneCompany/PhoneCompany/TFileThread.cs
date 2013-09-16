using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PhoneCompany
{
    public class TFileThread
    {
        static public string rec;
        static public byte erCode;
        static public string erStr;
        static string err;

        static public void Execute(TCallDetailRecord Caller)
        {
            erStr = "";
            if (Analis(Caller))//если звонок подходящий
                HandledCalls(Caller);//формируем отчет о звонке
            else//иначе
            {
                rec = "";
                ErrorRec(Caller);//формируем отчет об ошибке
            }
        }

        static private bool Analis(TCallDetailRecord Caller)//анализ звонка
        {
            if (Caller._numB.Prefix == "10")//если звонок международжный
            {
                if (Caller._numB.CountryCode != "375")//и если код страны неверный
                    erCode = 1;//ошибка №1
                else//иначе
                    if (Caller._numB.SityCode != "17")//если код города неверный
                        erCode = 2;//ошибка №2
                    else //иначе
                        if (Caller._numB.AbonNumber.Length != 7)//если номер не семизначный
                            erCode = 3;//ошибка №3
                        else return true;//иначе звонок подходящий
            }
            else if (Caller._numB.Prefix == "8")//если звонок междугородний
            {
                if (Caller._numB.SityCode != "17")//и если код города неверный
                    erCode = 2;//ошибка №2
                else //иначе
                    if (Caller._numB.AbonNumber.Length != 7)//если номер не семизначный
                        erCode = 3;//ошибка №3
                    else return true;//иначе звонок подходящий
            }

            return false;
        }

        static private void ErrorRec(TCallDetailRecord Caller)
        {

            err = "";//обнуляем строку об ошибке
            switch (erCode)//перебераем по коду ошибке
            {
                case 1:
                    err = "Missing country code!";//неверный код страны
                    break;

                case 2:
                    err = "Missing city code!";//неверный код города
                    break;

                case 3:
                    err = "Number digits does'n equal to 7!!";//номер не семизначный
                    break;

            }

            if (err != "")//если строка об ошибке не пустая
            {
                erStr = (Caller._numA + "(" + Caller._numB.Prefix + " " + Caller._numB.CountryCode +
                    " " + Caller._numB.SityCode + ")" + Caller._numB.AbonNumber + "-" + err);
                //формируем полную строку об ошибке
            }
        }

        static private void HandledCalls(TCallDetailRecord Caller)
        {

            //отчет о коректных звонках
            rec = (Caller._numA + "(" + Caller._numB.Prefix + " " + Caller._numB.CountryCode + " " +
                Caller._numB.SityCode + ")" + Caller._numB.AbonNumber + "/");
            rec += Caller._date.ToShortDateString().ToString() + "/" + Caller._time.ToShortTimeString().ToString() + "/";
            rec += Caller._tLineID.C + "/" + Caller._tLineID.S + "Time" + Caller._long + "m" + Caller._endRec;

            //открываем файл на дозапись и создаем поток записи
            using(StreamWriter sw=File.AppendText("CallerID.log"))
            {
                sw.WriteLine(rec);//записываем строку отчета в файл
            }
        }

    }


}