using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibraryOfCollection
{
    public class MyStack<TData> : BaseList<TData>
    {
        ElementStack<TData> head = null;//Указатель на голову

        /// <summary>
        /// Поиск по ключу
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override IMyEntity<TData> FindByKey(int key)
        { 
            //Если стек пуст
            if (head == null)
                return null;

            //Временная переменная для ссылки на следующий элемент
            var next = head;
            
            do//В цикле
            {
                //Если элемент найден
                if (next.Entity.Key == key)
                    return next.Entity;//Возвращаем его
                
                //Переходим к следующему элементу
                next = next.Next;
            } while (next != null);//До последнего элемента

            //Если элемент не найден
            return null;
        }

        /// <summary>
        /// Добавление нового элемента
        /// </summary>
        /// <param name="obj"></param>
        public override void Add(IMyEntity<TData> obj)
        {
            //Создаем новый элемент с ссылкой на текущий элемент "головы"
            var elem = new ElementStack<TData> { Entity = obj, Next = head };
            
            //Меняем указатель на "голову"
            head = elem;

            //Вызов базоваго метода
            base.Add(obj);//для увеличение счетчика
        }

        /// <summary>
        /// Получение первого элемента с удалением его из списка
        /// </summary>
        /// <returns></returns>
        public override IMyEntity<TData> GetAndDel()
        {
            //Если стек пуст
            if (head == null) return null;

            //Временная переменная для ссылки на следующий элемент
            var tmp = head;

            //Переназначаем указатель на первый элемент
            head = head.Next;

            //Вызов базового метода
            base.GetAndDelBase();

            //Возвращаем первый элемент
            return tmp.Entity;
        }
    }
}
