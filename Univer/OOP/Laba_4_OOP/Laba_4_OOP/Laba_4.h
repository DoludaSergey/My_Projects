#include <iostream>
#include <Windows.h>
#include <time.h>
#include <stdlib.h>
#include <conio.h>
#include <iomanip>
#include <fstream>
#include <typeinfo.h>
#include "float.h"
#include <limits.h>
#include <cmath>

const char* ErrorLimits ="!!!!!!!! Превышен допустимый диапазон !!!!!!!\n";
const char* Explanation ="Значение должно быть от ";
const char* To =" до ";
const char* FORMULA ="Производим вычисления над векторами по формуле : ";
const char* ENTER_MASS ="\nВведите элементы вектора :\n";
const char* IN_MASS ="Введите количество элементов вектора";
const char* ONEFORMULA ="Производим вычисления с обычними числами по формуле :\n";
const char* DIVISION ="Деление на ноль!!!!\n";
const char* CONTINUE ="Для продолжения нажмите любую клавишу.Выход - Esc\n";
const char* RAND ="Элементы вектора введены случайным образом!\n";
const char* ERROR_COUNT ="\n\t\t!!!!!ОШИБКА!!!!!\nРазмер вектора должен лежать в диапазоне от 0 до 1000!!!\n\t\tПовторите ввод!\n\n";

using namespace std;

template <typename T>
class mass
{
private:
	T* ptrMass;//указатель на массив
	int size;//размер массива

public:
	mass(int s=10)//конструктор по умолчанию
	{
		size = s;
		ptrMass = new T[size];

		if(size > 10)//если размер вектора более 10
			//заполняем его псевдо-случайными числами
		{
			srand ((unsigned)time(NULL));
			for (int i=0;i<size;i++)
				ptrMass[i]=(T)-100+rand()% 201;
		}
		else//иначи заполняем нулями
			for (int i=0;i<size;i++)
				ptrMass[i]=0;
	}

	mass (mass & obj)//конструктор копирования
	{
		size = obj.size;
		ptrMass = new T[size];

		for (int i=0;i<size;i++)
				ptrMass[i]=obj.ptrMass[i];
	}
	~mass(){delete []ptrMass;}//деструктор

	//функция вызывается если вектора состоят из одного элемента
	//и выполняет вычисления как с обычными числами
	bool One(const mass<T> &massA,const mass<T> &massB)
	{
		if (massA.size==1 && massB.size==1)
		{
			try
			{
				T a=massA.ptrMass[0],b=massB.ptrMass[0];
				if(a<b)
				{
					cout<<"Выполняется вычисление, когда A<B ->МЕНЬШЕ"<<endl;
					if(!a) throw DIVISION;
					ptrMass[0]=b/a+5;
					cout<<ONEFORMULA;
					cout<<"x=a/b+5\n";
				}
				else if(a==b)
				{
					cout<<"Выполняется вычисление, когда A=B ->РАВНЫ"<<endl;
					if(!b) throw DIVISION;
					ptrMass[0]=-5;
					cout<<ONEFORMULA;
					cout<<"x=-5\n";
				}
				else if (a>b)
				{
					cout<<"Выполняется вычисление, когда A>B ->БОЛЬШЕ"<<endl;
					if(!b) throw DIVISION;
					ptrMass[0]=(a*b)/b;
					cout<<ONEFORMULA;
					cout<<"x=(a*b)/b\n";
				}
				cout<<"a = "<<a<<endl;
				cout<<"b = "<<b<<endl;
				cout<<"Ответ = "<<ptrMass[0]<<endl;
				return true;
			}
			catch (const char *v)
			{
				cout << "\n!!!!! Обработка исключительной ситуации." << endl;
				cout << "Ошибка: "<<v;
				return false;
			}
			catch(...) // Абсолютный обработчик - перехват ВСЕХ исключений
			{
				cout << "\n!!!!! Обработка незапланированной исключительной ситуации."
				<< endl;
				return false;
			}
		}
		else return false;
	}
	mass operator -(const T n)//переопределение оператора вычитания
	{
		mass mX(*this);
		for (int i=0;i<size;i++)
			mX.ptrMass[i]-=n;
		return mX;
	}
	mass operator +(const T n)//переопределение оператора сложения
	{
		mass mX(*this);
		for (int i=0;i<size;i++)
			mX.ptrMass[i]+=n;
		return mX;
	}
	mass operator=(const mass &mB)//переопределение оператора присвоения
	{
		delete []ptrMass;
		size=mB.size;
		ptrMass = new T[size];

		for (int i=0;i<size;i++)
			ptrMass[i]=mB.ptrMass[i];
		return *this;
	}
	mass operator=(const T n)//переопределение оператора присвоения
	{
		for (int i=0;i<size;i++)
			ptrMass[i]=n;
		return *this;
	}
	mass operator -()//изменение знака элементов вектора
	{
		mass x;
		x.size==size;
		x.ptrMass=new T[x.size];

		for (int i=0;i<size;i++)
			x.ptrMass[i]=ptrMass[i]*(-1);
		return x;
	}
	T Summa_El_Mass(const mass & massB)//вычисление суммы элементов вектора
	{
		T sumMass=0;

		for (int i=0;i<massB.size;i++)
			sumMass+=massB.ptrMass[i];
		return sumMass;
	}
	bool operator==(const mass & massB)//переопределение оператора равенства
	{
		if(size==massB.size)
		{
			for (int i=0;i<massB.size;i++)
			{
				if(ptrMass[i]!=massB.ptrMass[i])
					return false;
			}
			return true;
		}
		else return false;
	}
	bool operator<(const mass & massB)//переопределение оператора меньше
	{
		T sumA=Summa_El_Mass(*this);
		T sumB=Summa_El_Mass(massB);

		if(size<massB.size) return true;
		else if (size==massB.size)
		{
			if(sumA<sumB)return true;
			else return false;
		}
		else return false;
	}
	bool operator>(const mass & massB)//переопределение оператора больше
	{
		T sumA=Summa_El_Mass(*this);
		T sumB=Summa_El_Mass(massB);

		if(size>massB.size) return true;
		else if (size==massB.size)
		{
			if(sumA>sumB)return true;
			else return false;
		}
		else return false;
	}
	mass operator/(const mass & massB)//переопределение оператора деления
	{
		mass massX(*this);//копируем в вектор massX вектор massB

		if(size>massB.size)//если размер вектора massA больше размера вектора massB
		{
			int i;

			for(i=0;i<massB.size;i++)
			{
				//если знам. равен 0, то элемент вектора - неизменный
				if(!massB.ptrMass[i])continue;
				else massX.ptrMass[i]=ptrMass[i]/massB.ptrMass[i];
			}
			for(i;i<massX.size;i++)//заполняем остальные элементы нулями
				massX.ptrMass[i]=0;
		}
		else if(size<massB.size)//если размер вектора меньше размера вектора massB
		{
			int i;

			delete []massX.ptrMass;//удаляем выделенную память
			massX.size=massB.size;//назначаем новый размер
			massX.ptrMass=new T[massX.size];//выделяем память под новый вектор

			for(i=0;i<size;i++)
			{
				//если знаменатель равен 0, то в рез. массив заносим значение вектора massB
				if(!massB.ptrMass[i]) massX.ptrMass[i]=massB.ptrMass[i];
				else massX.ptrMass[i]= ptrMass[i]/massB.ptrMass[i];
			}
			for(i;i<massX.size;i++)//заполняем остальные элементы нулями
				massX.ptrMass[i]=0;
		}
		else if(size==massB.size)//если размер вектора равен размеру вектора massB
		{
			for(int i=0;i<size;i++)
			{
				//если знаменатель равен 0, то в рез массив заносим значение вектора B
				if(!massB.ptrMass[i]) massX.ptrMass[i]=ptrMass[i];
				else massX.ptrMass[i]= ptrMass[i]/massB.ptrMass[i];
			}
		}
		return massX;
	}

	mass operator*(const mass & massB)//переопределение оператора деления
	{
		mass massX(*this);//копируем в вектор massX вектор massB

		if(size>massB.size)//если размер вектора больше размера вектора massB
		{
			int i;

			for(i=0;i<massB.size;i++)
			{
				//если знам. равен 0, то элемент вектора - неизменный
				if((!massB.ptrMass[i])||(!ptrMass[i]))
					massX.ptrMass[i]=0;
				else massX.ptrMass[i]=ptrMass[i]*massB.ptrMass[i];
			}
			for(i;i<massX.size;i++)//заполняем остальные элементы нулями
				massX.ptrMass[i]=0;
		}
		else if(size<massB.size)//если размер вектора меньше размера вектора massB
		{
			int i;

			delete []massX.ptrMass;//удаляем выделенную память
			massX.size=massB.size;//назначаем новый размер
			massX.ptrMass=new T[massX.size];//выделяем память под новый вектор

			for(i=0;i<size;i++)
				massX.ptrMass[i]= ptrMass[i]*massB.ptrMass[i];

			for(i;i<massX.size;i++)//заполняем остальные элементы нулями
				massX.ptrMass[i]=0;
		}
		else if(size==massB.size)//если размер вектора равен размеру вектора massB
		{
			for(int i=0;i<size;i++)
				massX.ptrMass[i]= ptrMass[i]*massB.ptrMass[i];
		}
		return massX;
	}
	friend istream & operator>><T>(istream & input, mass & obj);
	friend ostream & operator<<<T>(ostream & output, mass & obj);
};
//Проверка на диапазон INT
int CheckInt(int i, const int MIN=-INT_MIN, const int MAX=INT_MAX)
{
	if((fabsl(i)<MIN)||(fabsl(i)>MAX))
	{
		cout<<ErrorLimits;
		cout<<Explanation<<MIN<<To<<MAX<<endl;
		return 1;
	}
	return 0;
}
//Проверка на диапазон FLT
int CheckFLT(long double i, const long double MIN=-FLT_MIN, const long double MAX=FLT_MAX)
{
	if((fabsl(i)<MIN)||(fabsl(i)>MAX))
	{
		cout<<ErrorLimits;
		cout<<Explanation<<MIN<<To<<MAX<<endl;
		return 1;
	}
	return 0;
}
//Проверка на диапазон DBL
int CheckDBL(long double i, const long double MIN=-DBL_MIN, const long double MAX=DBL_MAX)
{
	if((fabsl(i)<MIN)||(fabsl(i)>MAX))
	{
		cout<<ErrorLimits;
		cout<<Explanation<<MIN<<To<<MAX<<endl;
		return 1;
	}
	return 0;
}
//Открытие своего входного потока для ввода с консоли
template <typename T>
T in(T & k)
{
	//cout<<"Введите элемент вектора ->"<<endl;

	ifstream my_inp ("CON");
	long double t;

	if(typeid(k)==typeid(int)||typeid(k)==typeid(float)||typeid(k)==typeid(double))
		my_inp>>t;//ввод переменной
	else
		my_inp>>k;

	switch(my_inp.rdstate())//анализ введенной информации
	{
	case ios::goodbit:
	case ios::eofbit:
		//контроль допустимых диапазонов
		//ВЕЩЕСТВЕННЫЕ числа
		if(typeid(k)==typeid(int)) 
			if(CheckInt(t))return 1;
		
		if(typeid(k)==typeid(float)) 
			if(CheckFLT(t))return 1;

		if(typeid(k)==typeid(double)) 
			if(CheckDBL(t))return 1;

		if(typeid(k)==typeid(int)||typeid(k)==typeid(float)||typeid(k)==typeid(double)) 
			k=t;

		return 0;//все в порядке

	case ios::failbit:
	case ios::badbit:
		cout<<"\n!!!!Ошибка ввода символов !!!!!";
		cout<<"\nПопробуйте еще раз !!!!!"<<endl;
		return 1;
	}
	cout<<"\nЧто-то еще произошло на вводе!!!"<<endl;
	return 1;
}
template <typename T>
ostream & operator<<(ostream & output, mass<T> & obj)
{
	cout<<endl;
	for(int i=0;i<obj.size;i++)
		output<<" "<<obj.ptrMass[i];
	cout<<endl<<endl;
	return output;
}
template <typename T>
istream & operator>>(istream & input, mass<T> & obj)
{
	for(int i=0;i<obj.size;i++)
	{
		cout<<"Элемент ["<<i+1<<"] : ";
		while(in(obj.ptrMass[i]));
	}
	return input;
}