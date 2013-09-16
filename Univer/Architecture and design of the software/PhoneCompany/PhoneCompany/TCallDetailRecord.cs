using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneCompany
{
    public class TCallDetailRecord
    {
        public string _numA;//номер абонента
        public TPhoneNumber _numB = new TPhoneNumber();//набранный номер
        public DateTime _date;//дата звонка
        public DateTime _time;//время звонка
        public int _long;//длительность разговора
        public TLineID _tLineID = new TLineID();//информация о линии
        public string _endRec;

    }
}
