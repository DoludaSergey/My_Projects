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

const char* ErrorLimits ="!!!!!!!! �������� ���������� �������� !!!!!!!\n";
const char* Explanation ="�������� ������ ���� �� ";
const char* To =" �� ";
const char* FORMULA ="���������� ���������� ��� ��������� �� ������� : ";
const char* ENTER_MASS ="\n������� �������� ������� :\n";
const char* IN_MASS ="������� ���������� ��������� �������";
const char* ONEFORMULA ="���������� ���������� � �������� ������� �� ������� :\n";
const char* DIVISION ="������� �� ����!!!!\n";
const char* CONTINUE ="��� ����������� ������� ����� �������.����� - Esc\n";
const char* RAND ="�������� ������� ������� ��������� �������!\n";
const char* ERROR_COUNT ="\n\t\t!!!!!������!!!!!\n������ ������� ������ ������ � ��������� �� 0 �� 1000!!!\n\t\t��������� ����!\n\n";

using namespace std;

template <typename T>
class mass
{
private:
	T* ptrMass;//��������� �� ������
	int size;//������ �������

public:
	mass(int s=10)//����������� �� ���������
	{
		size = s;
		ptrMass = new T[size];

		if(size > 10)//���� ������ ������� ����� 10
			//��������� ��� ������-���������� �������
		{
			srand ((unsigned)time(NULL));
			for (int i=0;i<size;i++)
				ptrMass[i]=(T)-100+rand()% 201;
		}
		else//����� ��������� ������
			for (int i=0;i<size;i++)
				ptrMass[i]=0;
	}

	mass (mass & obj)//����������� �����������
	{
		size = obj.size;
		ptrMass = new T[size];

		for (int i=0;i<size;i++)
				ptrMass[i]=obj.ptrMass[i];
	}
	~mass(){delete []ptrMass;}//����������

	//������� ���������� ���� ������� ������� �� ������ ��������
	//� ��������� ���������� ��� � �������� �������
	bool One(const mass<T> &massA,const mass<T> &massB)
	{
		if (massA.size==1 && massB.size==1)
		{
			try
			{
				T a=massA.ptrMass[0],b=massB.ptrMass[0];
				if(a<b)
				{
					cout<<"����������� ����������, ����� A<B ->������"<<endl;
					if(!a) throw DIVISION;
					ptrMass[0]=b/a+5;
					cout<<ONEFORMULA;
					cout<<"x=a/b+5\n";
				}
				else if(a==b)
				{
					cout<<"����������� ����������, ����� A=B ->�����"<<endl;
					if(!b) throw DIVISION;
					ptrMass[0]=-5;
					cout<<ONEFORMULA;
					cout<<"x=-5\n";
				}
				else if (a>b)
				{
					cout<<"����������� ����������, ����� A>B ->������"<<endl;
					if(!b) throw DIVISION;
					ptrMass[0]=(a*b)/b;
					cout<<ONEFORMULA;
					cout<<"x=(a*b)/b\n";
				}
				cout<<"a = "<<a<<endl;
				cout<<"b = "<<b<<endl;
				cout<<"����� = "<<ptrMass[0]<<endl;
				return true;
			}
			catch (const char *v)
			{
				cout << "\n!!!!! ��������� �������������� ��������." << endl;
				cout << "������: "<<v;
				return false;
			}
			catch(...) // ���������� ���������� - �������� ���� ����������
			{
				cout << "\n!!!!! ��������� ����������������� �������������� ��������."
				<< endl;
				return false;
			}
		}
		else return false;
	}
	mass operator -(const T n)//��������������� ��������� ���������
	{
		mass mX(*this);
		for (int i=0;i<size;i++)
			mX.ptrMass[i]-=n;
		return mX;
	}
	mass operator +(const T n)//��������������� ��������� ��������
	{
		mass mX(*this);
		for (int i=0;i<size;i++)
			mX.ptrMass[i]+=n;
		return mX;
	}
	mass operator=(const mass &mB)//��������������� ��������� ����������
	{
		delete []ptrMass;
		size=mB.size;
		ptrMass = new T[size];

		for (int i=0;i<size;i++)
			ptrMass[i]=mB.ptrMass[i];
		return *this;
	}
	mass operator=(const T n)//��������������� ��������� ����������
	{
		for (int i=0;i<size;i++)
			ptrMass[i]=n;
		return *this;
	}
	mass operator -()//��������� ����� ��������� �������
	{
		mass x;
		x.size==size;
		x.ptrMass=new T[x.size];

		for (int i=0;i<size;i++)
			x.ptrMass[i]=ptrMass[i]*(-1);
		return x;
	}
	T Summa_El_Mass(const mass & massB)//���������� ����� ��������� �������
	{
		T sumMass=0;

		for (int i=0;i<massB.size;i++)
			sumMass+=massB.ptrMass[i];
		return sumMass;
	}
	bool operator==(const mass & massB)//��������������� ��������� ���������
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
	bool operator<(const mass & massB)//��������������� ��������� ������
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
	bool operator>(const mass & massB)//��������������� ��������� ������
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
	mass operator/(const mass & massB)//��������������� ��������� �������
	{
		mass massX(*this);//�������� � ������ massX ������ massB

		if(size>massB.size)//���� ������ ������� massA ������ ������� ������� massB
		{
			int i;

			for(i=0;i<massB.size;i++)
			{
				//���� ����. ����� 0, �� ������� ������� - ����������
				if(!massB.ptrMass[i])continue;
				else massX.ptrMass[i]=ptrMass[i]/massB.ptrMass[i];
			}
			for(i;i<massX.size;i++)//��������� ��������� �������� ������
				massX.ptrMass[i]=0;
		}
		else if(size<massB.size)//���� ������ ������� ������ ������� ������� massB
		{
			int i;

			delete []massX.ptrMass;//������� ���������� ������
			massX.size=massB.size;//��������� ����� ������
			massX.ptrMass=new T[massX.size];//�������� ������ ��� ����� ������

			for(i=0;i<size;i++)
			{
				//���� ����������� ����� 0, �� � ���. ������ ������� �������� ������� massB
				if(!massB.ptrMass[i]) massX.ptrMass[i]=massB.ptrMass[i];
				else massX.ptrMass[i]= ptrMass[i]/massB.ptrMass[i];
			}
			for(i;i<massX.size;i++)//��������� ��������� �������� ������
				massX.ptrMass[i]=0;
		}
		else if(size==massB.size)//���� ������ ������� ����� ������� ������� massB
		{
			for(int i=0;i<size;i++)
			{
				//���� ����������� ����� 0, �� � ��� ������ ������� �������� ������� B
				if(!massB.ptrMass[i]) massX.ptrMass[i]=ptrMass[i];
				else massX.ptrMass[i]= ptrMass[i]/massB.ptrMass[i];
			}
		}
		return massX;
	}

	mass operator*(const mass & massB)//��������������� ��������� �������
	{
		mass massX(*this);//�������� � ������ massX ������ massB

		if(size>massB.size)//���� ������ ������� ������ ������� ������� massB
		{
			int i;

			for(i=0;i<massB.size;i++)
			{
				//���� ����. ����� 0, �� ������� ������� - ����������
				if((!massB.ptrMass[i])||(!ptrMass[i]))
					massX.ptrMass[i]=0;
				else massX.ptrMass[i]=ptrMass[i]*massB.ptrMass[i];
			}
			for(i;i<massX.size;i++)//��������� ��������� �������� ������
				massX.ptrMass[i]=0;
		}
		else if(size<massB.size)//���� ������ ������� ������ ������� ������� massB
		{
			int i;

			delete []massX.ptrMass;//������� ���������� ������
			massX.size=massB.size;//��������� ����� ������
			massX.ptrMass=new T[massX.size];//�������� ������ ��� ����� ������

			for(i=0;i<size;i++)
				massX.ptrMass[i]= ptrMass[i]*massB.ptrMass[i];

			for(i;i<massX.size;i++)//��������� ��������� �������� ������
				massX.ptrMass[i]=0;
		}
		else if(size==massB.size)//���� ������ ������� ����� ������� ������� massB
		{
			for(int i=0;i<size;i++)
				massX.ptrMass[i]= ptrMass[i]*massB.ptrMass[i];
		}
		return massX;
	}
	friend istream & operator>><T>(istream & input, mass & obj);
	friend ostream & operator<<<T>(ostream & output, mass & obj);
};
//�������� �� �������� INT
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
//�������� �� �������� FLT
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
//�������� �� �������� DBL
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
//�������� ������ �������� ������ ��� ����� � �������
template <typename T>
T in(T & k)
{
	//cout<<"������� ������� ������� ->"<<endl;

	ifstream my_inp ("CON");
	long double t;

	if(typeid(k)==typeid(int)||typeid(k)==typeid(float)||typeid(k)==typeid(double))
		my_inp>>t;//���� ����������
	else
		my_inp>>k;

	switch(my_inp.rdstate())//������ ��������� ����������
	{
	case ios::goodbit:
	case ios::eofbit:
		//�������� ���������� ����������
		//������������ �����
		if(typeid(k)==typeid(int)) 
			if(CheckInt(t))return 1;
		
		if(typeid(k)==typeid(float)) 
			if(CheckFLT(t))return 1;

		if(typeid(k)==typeid(double)) 
			if(CheckDBL(t))return 1;

		if(typeid(k)==typeid(int)||typeid(k)==typeid(float)||typeid(k)==typeid(double)) 
			k=t;

		return 0;//��� � �������

	case ios::failbit:
	case ios::badbit:
		cout<<"\n!!!!������ ����� �������� !!!!!";
		cout<<"\n���������� ��� ��� !!!!!"<<endl;
		return 1;
	}
	cout<<"\n���-�� ��� ��������� �� �����!!!"<<endl;
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
		cout<<"������� ["<<i+1<<"] : ";
		while(in(obj.ptrMass[i]));
	}
	return input;
}