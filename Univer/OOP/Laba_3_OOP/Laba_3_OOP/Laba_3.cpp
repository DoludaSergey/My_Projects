#include "Laba_3.h"

void Result(mass massA,mass massB,mass massX)
{
	int k=0;
	cout<<"��������� ���������� \n"<<endl;
	if(!massX.One(massA,massB))
	{
		if(massA>massB)
		{
			k=1;
			cout<<"������ � ������ ������� B "<<endl<<endl;
			cout<<FORMULA;
			cout<<"x=(a*b)/b";
			massX=((massA*massB)/massB);
		}
		else if(massA<massB)
		{
			k=1;
			cout<<"������ � ������ ������� B "<<endl<<endl;
			cout<<FORMULA;
			cout<<"x=b/a+5";
			massX=massB/massA+5;
		}
		else if(massA==massB)
		{
			k=1;
			cout<<"������� ����� "<<endl<<endl;
			cout<<FORMULA;
			cout<<"x=-5";
			massX=-5;
		}
		if(k)
		{
			cout<<"\n������ � :\n";
			cout<<massA;
			cout<<"\n������ B :\n";
			cout<<massB<<endl;
			cout<<"�������������� ������ � :\n";
			cout<<massX;
		}
		else cout<<"��� ������� �� �������� �� ��� ���� ������� ���������!!!";

	}
	cout<<endl<<endl;
	cout<<CONTINUE;
}
void main ()
{
	setlocale(0,"rus");
	int kol,count=0;
	char ch;
	int maxSize=0;
	do
	{
		cout<<"\n**************** ������� �3 ************************\n"<<endl;
		cout<<"\n\t  \t(\t(b/a)+5\t\t���� a<b"<<endl;
		cout<<"\tX=\t{\t-5\t\t���� a=b"<<endl;
		cout<<"\t  \t(\t(a*b)/b\t\t���� a>b"<<endl;
		cout<<"\n**************** ���� � "<<++count<<"   ************************\n"<<endl;

		do
		{
			cout<<IN_MASS<<" A : ";
			while(in(kol));
			if(kol<=0 || kol>1000) cout<<ERROR_COUNT;
		}
		while(kol<=0 || kol>1000);

		maxSize=kol;

		mass massA(kol);

		if(kol<=10)
		{
			cout<<ENTER_MASS;
			cin>>massA;		
		}
		else cout<<endl<<RAND<<endl;
		cout<<massA;

		do
		{
			cout<<IN_MASS<<" B : ";
			while(in(kol));
			if(kol<=0 || kol>1000) cout<<ERROR_COUNT;
		}
		while(kol<=0 || kol>1000);

		mass massB(kol);

		if(kol>maxSize)
			maxSize=kol;
		if(kol<=10)
		{
			cout<<ENTER_MASS;
			cin>>massB;		
		}
		else cout<<endl<<RAND<<endl;
		cout<<massB;

		mass massX(maxSize);
		Result(massA,massB,massX);
		ch=getch();
	}
	while(ch!=27);

}