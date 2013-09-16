#include "Laba_3.h"

void Result(mass massA,mass massB,mass massX)
{
	int k=0;
	cout<<"Ðåçóëüòàò âû÷èñëåíèé \n"<<endl;
	if(!massX.One(massA,massB))
	{
		if(massA>massB)
		{
			k=1;
			cout<<"ÂÅÊÒÎÐ À ÁÎËÜØÅ ÂÅÊÒÎÐÀ B "<<endl<<endl;
			cout<<FORMULA;
			cout<<"x=(a*b)/b";
			massX=((massA*massB)/massB);
		}
		else if(massA<massB)
		{
			k=1;
			cout<<"ÂÅÊÒÎÐ À ÌÅÍÜØÅ ÂÅÊÒÎÐÀ B "<<endl<<endl;
			cout<<FORMULA;
			cout<<"x=b/a+5";
			massX=massB/massA+5;
		}
		else if(massA==massB)
		{
			k=1;
			cout<<"ÂÅÊÒÎÐÛ ÐÀÂÍÛ "<<endl<<endl;
			cout<<FORMULA;
			cout<<"x=-5";
			massX=-5;
		}
		if(k)
		{
			cout<<"\nÂåêòîð À :\n";
			cout<<massA;
			cout<<"\nÂåêòîð B :\n";
			cout<<massB<<endl;
			cout<<"Ðåçóëüòèðóþùèé âåêòîð Õ :\n";
			cout<<massX;
		}
		else cout<<"ÄÂÀ ÂÅÊÒÎÐÀ ÍÅ ÏÎÄÕÎÄßÒ ÍÈ ÏÎÄ ÎÄÍÎ ÓÑËÎÂÈÅ ÐÀÂÅÍÑÒÂÀ!!!";

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
		cout<<"\n**************** ÂÀÐÈÀÍÒ ¹3 ************************\n"<<endl;
		cout<<"\n\t  \t(\t(b/a)+5\t\tåñëè a<b"<<endl;
		cout<<"\tX=\t{\t-5\t\tåñëè a=b"<<endl;
		cout<<"\t  \t(\t(a*b)/b\t\tåñëè a>b"<<endl;
		cout<<"\n**************** ÒÅÑÒ ¹ "<<++count<<"   ************************\n"<<endl;

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