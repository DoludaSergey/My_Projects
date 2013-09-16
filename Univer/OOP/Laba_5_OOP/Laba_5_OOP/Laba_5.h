#include <iostream>
#include <string>
#include <Windows.h>
#include <conio.h>

using namespace std;

const char* ERRORLIMITS="\nВ введенной строке не выявленно необходимых слов\n или в ней НЕДОПУСТИМОЕ количество слов!!!!!!\n";
const char* ERRORPOINT="\nСтрока должна заканчиваться ТОЧКОЙ!!!!!!\n";
const char* Point=".";
const char* COMMA=",";
#define ESC 27


class myString
{
private:
	string setStr;//Поле для введенной строки
	string* mas;
	int count;
public:
	myString(string s)//конструктор
	{
		setStr=s;//инициализируем строку
	}
	~myString(){delete []mas;}//деструктор
	bool setText();
	void outText();
};
bool myString::setText()//Анализ введенного текста
{
	int posStart=0,posFinish=0,pos=0,index=0,nChar;
	bool flag;//Признак нужного слова

	mas=new string[0];
	string tempStr="";
	posFinish=setStr.find(Point);//Находим позицию точки
	setStr=setStr.substr(0,posFinish+1);//Обрезаем лишний текст
	tempStr=setStr;//Присваиваем значение временной переменной
	count=0;//Обнуляем счетчик

	if(posFinish>0)//Если строка не пуста
	{
		for(int i=0;i<tempStr.length();)
		{
			flag=true;
			nChar=0;

			//Находим позицию конца слова(запятую)
			pos=tempStr.find(COMMA);
			//Находим позицию конца текста(точку)
			posFinish=tempStr.find(Point);

			//Если слово нужного размера
			if((pos>0)&&(pos<6))
			{
				for(int j=0;j<pos;j++)
				{
					//Если в слове лишний символ,инорируем это слово
					if(tempStr[j]<'A'|| tempStr[j]>'Z')
					{
						flag=false;
						break;//Выход из цикла
					}
					
				}
				if(flag)//Если слово подходящее
					count++;//Увеличиваем счетчик нужных слов
				index++;//Увеличиваем счетчик всех слов
				//Переходим к следующему слову
				tempStr=tempStr.substr(pos+1);
			}
			//Если слово длиннее или равно нулю
			if((pos==0)||(pos>5))
			{
				//Пропускаем его
				tempStr=tempStr.substr(pos+1);
				index++;//Увеличиваем счетчик всех слов
			}
			if(pos<0)//если запятых нет(осталось всего одно слово)
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
		//Если слов допустимое количество
		if(count>0&&count<31)
		{
			//Создаем массив для слов
			mas=new string[count];
			int k=0;

			//Записываем нужные слова в массив
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
				if(pos<0)//если запятых нет
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
			cout<<"Строка до точки не содержит символов!!!\n";
			return 1;
		}
		else
		{
			cout<<ERRORPOINT;
			return 1;
		}
}
void myString::outText()//Вывод результата после обработки
{
	cout<<"\nОБРАБАТЫВАЕМ ВВЕДЕННУЮ СТРОКУ!!!\n";
	cout<<"\nИз строки были выделенны следующие слова :\n";

	for(int j=0;j<count;j++)
		cout<<mas[j]<<", ";

	cout<<"\n\nСлова после модификации :\n";

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