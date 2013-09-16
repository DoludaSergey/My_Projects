#include <iostream>
#include <string>
#include <Windows.h>
#include <conio.h>

using namespace std;

const char* ERRORLIMITS="\n� ��������� ������ �� ��������� ����������� ����\n ��� � ��� ������������ ���������� ����!!!!!!\n";
const char* ERRORPOINT="\n������ ������ ������������� ������!!!!!!\n";
const char* Point=".";
const char* COMMA=",";
#define ESC 27


class myString
{
private:
	string setStr;//���� ��� ��������� ������
	string* mas;
	int count;
public:
	myString(string s)//�����������
	{
		setStr=s;//�������������� ������
	}
	~myString(){delete []mas;}//����������
	bool setText();
	void outText();
};
bool myString::setText()//������ ���������� ������
{
	int posStart=0,posFinish=0,pos=0,index=0,nChar;
	bool flag;//������� ������� �����

	mas=new string[0];
	string tempStr="";
	posFinish=setStr.find(Point);//������� ������� �����
	setStr=setStr.substr(0,posFinish+1);//�������� ������ �����
	tempStr=setStr;//����������� �������� ��������� ����������
	count=0;//�������� �������

	if(posFinish>0)//���� ������ �� �����
	{
		for(int i=0;i<tempStr.length();)
		{
			flag=true;
			nChar=0;

			//������� ������� ����� �����(�������)
			pos=tempStr.find(COMMA);
			//������� ������� ����� ������(�����)
			posFinish=tempStr.find(Point);

			//���� ����� ������� �������
			if((pos>0)&&(pos<6))
			{
				for(int j=0;j<pos;j++)
				{
					//���� � ����� ������ ������,��������� ��� �����
					if(tempStr[j]<'A'|| tempStr[j]>'Z')
					{
						flag=false;
						break;//����� �� �����
					}
					
				}
				if(flag)//���� ����� ����������
					count++;//����������� ������� ������ ����
				index++;//����������� ������� ���� ����
				//��������� � ���������� �����
				tempStr=tempStr.substr(pos+1);
			}
			//���� ����� ������� ��� ����� ����
			if((pos==0)||(pos>5))
			{
				//���������� ���
				tempStr=tempStr.substr(pos+1);
				index++;//����������� ������� ���� ����
			}
			if(pos<0)//���� ������� ���(�������� ����� ���� �����)
			{
				if((posFinish>0)||(posFinish)<6)
				{
					for(int j=0;j<posFinish;j++)
					{
						if(tempStr[j]<'A'|| tempStr[j]>'Z')
						{
							flag=false;
							break;
						}
					
					}
					if(flag)
						count++;
					index++;
					tempStr=tempStr.substr(posFinish+1);
				}
				else
				{
					index++;
					tempStr=tempStr.substr(posFinish+1);
				}
			}
		}
		//���� ���� ���������� ����������
		if(count>0&&count<31)
		{
			//������� ������ ��� ����
			mas=new string[count];
			int k=0;

			//���������� ������ ����� � ������
			for(int i=0;i<index;i++)
			{
				flag=true;
				pos=setStr.find(COMMA);
				posFinish=setStr.find(Point);

				if(pos>0&&pos<6)
				{
					for(int j=0;j<pos;j++)
					{
						if(setStr[j]<'A'|| setStr[j]>'Z')
						{
							flag=false;
							break;
						}
					
					}
					if(flag)
					{
						mas[k]="";
						mas[k]=setStr.substr(posStart,pos);
						k++;
					}
					setStr=setStr.substr(pos+1);
				}
				if((pos==0)||(pos>5))
					setStr=setStr.substr(pos+1);
				if(pos<0)//���� ������� ���
				{
					if((posFinish>0)||(posFinish)<6)
					{
						for(int j=0;j<posFinish;j++)
						{
							if(setStr[j]<'A'|| setStr[j]>'Z')
							{
								flag=false;
								break;
							}
					
						}
						if(flag)
						{
							mas[k]="";
							mas[k]=setStr.substr(posStart,posFinish);
							k++;
						}
						setStr=setStr.substr(posFinish+1);
					}
					else
						setStr=setStr.substr(posFinish+1);
				}
			}
			return 0;
		}
		else 
		{
			cout<<ERRORLIMITS;
			return 1;
		}
	}
		if(posFinish==0)
		{
			cout<<"������ �� ����� �� �������� ��������!!!\n";
			return 1;
		}
		else
		{
			cout<<ERRORPOINT;
			return 1;
		}
}
void myString::outText()//����� ���������� ����� ���������
{
	cout<<"\n������������ ��������� ������!!!\n";
	cout<<"\n�� ������ ���� ��������� ��������� ����� :\n";

	for(int j=0;j<count;j++)
		cout<<mas[j]<<", ";

	cout<<"\n\n����� ����� ����������� :\n";

	string* tempStr=new string[count];
	int k=0;
	bool flag;

	for(int i=0;i<count;i++)
	{
		flag=true;

		if(!i)
		{
			tempStr[i]=mas[i];
			cout<<mas[i]<<", ";
		}

		for(int j=0;j<count;j++)
		{
			if(tempStr[j]==mas[i])
			{
				
				flag=false;
				break;
			}
		}
		if(flag)
		{
			cout<<mas[i]<<", ";
			k++;
			tempStr[k]=mas[i];
		}
	}
}