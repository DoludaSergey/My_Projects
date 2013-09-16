﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathFinther1
{
    class PathFinger
    {
        #region fields
        const int m = 56, n = 56, k = 3136;
        int Ni = 0;
        int startX = 0, startY = 0, finishX = 0, finishY = 0;

        #region MatrixLabirint
        //матрица лабиринта
        // -3 стена, -5 финиш, -7 проход
       int[,] filld = {
       /*1*/    {-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
       /*2*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-5,-3,-3},
       /*3*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},
       /*4*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},
       /*5*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},
       /*6*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},
       /*7*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},             
       /*8*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},
       /*9*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},
      /*10*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-3,-3,-3,-3,-3},
      /*11*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-3,-7,-7,-3,-3},
      /*12*/    {-3,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-3,-7,-7,-3,-3},             
      /*13*/    {-3,-7,-7,-7,-7,-3,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-7,-7,-7,-3,-7,-7,-3,-3},
      /*14*/    {-3,-7,-7,-7,-7,-3,-7,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-3,-3,-3,-3,-7,-7,-3,-3},
      /*15*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-7,-7,-7,-3,-7,-7,-3,-3}, 
      /*16*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-7,-7,-7,-3,-7,-7,-3,-3},
      /*17*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-3,-3,-3,-3,-7,-3,-7,-7,-3,-3},             
      /*18*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-7,-7,-3,-7,-3,-7,-7,-3,-3},
      /*19*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*20*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*21*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*22*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},             
      /*23*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*24*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-7,-7,-7,-3,-3},
      /*25*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3},
      /*26*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-7,-7,-7,-3,-3},
      /*27*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-7,-3,-3},             
      /*28*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-7,-7,-7,-3,-3},
      /*29*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3},
      /*30*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-7,-7,-7,-3,-3},             
      /*31*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-7,-3,-3},
      /*32*/    {-3,-7,-7,-7,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-7,-7,-7,-3,-3},             
      /*33*/    {-3,-7,-7,-3,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*34*/    {-3,-7,-7,-7,-7,-7,-3,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*35*/    {-3,-3,-3,-7,-3,-3,-3,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},            
      /*36*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*37*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},             
      /*38*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*39*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-7,-7,-3,-3},
      /*40*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3},             
      /*41*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-7,-7,-7,-7,-3,-3},
      /*42*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-7,-3,-3,-3,-3,-7,-3,-3},             
      /*43*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,
                -7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-7,-7,-7,-3,-7,-3,-3},
      /*44*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-3,-7,-3,-3},
      /*45*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,
                -7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-7,-7,-3,-3,-3,-7,-3,-7,-3,-3},             
      /*46*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-7,-7,-3,-3,-7,-7,-3,-7,-3,-3},
      /*47*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,
                -7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-7,-7,-3,-3,-3,-7,-3,-7,-3,-3},             
      /*48*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-3,-3,-7,-7,-3,-7,-3,-3},
      /*49*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,
                -7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-7,-7,-3,-3,-7,-7,-3,-7,-3,-3},
      /*50*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-3,-7,-3,-3,-3,-3,-7,-3,-7,-3,-3},
      /*51*/    {-3,-7,-7,-7,-7,-7,-7,-3,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,
                -7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3,-7,-7,-7,-7,-3,-3},
      /*52*/    {-3,-7,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},             
      /*53*/    {-3,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,
                -7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3},
      /*54*/    {-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3},
      /*55*/    {-3,0,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,
                -7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-7,-3,-3},             
      /*56*/    {-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,
                -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                            };

        #endregion
        #endregion

        #region OutputLabirint
       public void OutputLabirint()
      {
          //вывод графа на экран
          System.Console.WriteLine("Исходный вид лабиринта :\n");
  
          for (int i = 0; i < m ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (filld[i, j] == -3) System.Console.Write("#");
                    else if (filld[i, j] == -7) System.Console.Write(" ");
                    else if (filld[i, j] == -5)
                    {
                        finishX = i;
                        finishY = j;
                        System.Console.Write("F");
                    }
                    else if (filld[i, j] == 0)
                    {
                        startX = i; 
                        startY = j;
                        System.Console.Write("S");
                    }
                    else System.Console.Write(filld[i, j]);
                }

                System.Console.WriteLine();
            }
            System.Console.ReadLine();
      }
       #endregion

        #region FindPath
       public void FindPath()
        {
            //*
            //Построение графа 
            System.Console.WriteLine("Заполняем граф возможными маршрутами :\n");
            bool endFinther = false;
            do
            {
                if (endFinther) break;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (filld[i, j] == Ni)
                        {
                            if (filld[i + 1, j] == -5)
                            {
                                filld[i + 1, j] = Ni + 1;
                                endFinther = true;
                                break;
                            }
                            else if (filld[i + 1, j] == -7)
                            {
                                filld[i + 1, j] = Ni + 1;
                            };

                            if (filld[i - 1, j] == -5)
                            {
                                filld[i - 1, j] = Ni + 1;
                                endFinther = true;
                                break;
                            }
                            else if (filld[i - 1, j] == -7)
                            {
                                filld[i - 1, j] = Ni + 1;
                            };

                            if (filld[i, j + 1] == -5)
                            {
                                filld[i, j + 1] = Ni + 1;
                                endFinther = true;
                                break;
                            }
                            else if (filld[i, j + 1] == -7)
                            {
                                filld[i, j + 1] = Ni + 1;
                            };

                            if (filld[i, j - 1] == -5)
                            {
                                filld[i, j - 1] = Ni + 1;
                                endFinther = true;
                                break;
                            }
                            else if (filld[i, j - 1] == -7)
                            {
                                filld[i, j - 1] = Ni + 1;
                            };
                            
                        };
                    }

                } Ni++;
                
            } while ((Ni < k) || (!endFinther) );
        }
       #endregion

        #region MinPath
       public void MinPath()
        {
            //формирование минимального пути
            int minID = Ni ;
            int x, y, tempX=0, tempY=0;

            x = finishX;
            y = finishY;
            
            do
            {
               
                if (filld[x, y] == Ni )
                {
                     if ((filld[x + 1, y] < minID) && (filld[x + 1, y] != -1) && (filld[x + 1, y] != -3) &&
                                                      (filld[x + 1, y] != -5) && (filld[x + 1, y] != -7))
                     {
                          minID = filld[x + 1, y];
                          tempX = x + 1;
                          tempY = y;
                     }

                     if ((filld[x - 1, y] < minID) && (filld[x - 1, y] != -1) && (filld[x - 1, y] != -3) &&
                                                      (filld[x - 1, y] != -5) && (filld[x - 1, y] != -7))
                     {
                          minID = filld[x - 1, y];
                          tempX = x - 1;
                          tempY = y;
                     }

                     if ((filld[x, y + 1] < minID) && (filld[x, y + 1] != -1) && (filld[x, y + 1] != -3) &&
                                                      (filld[x, y + 1] != -5) && (filld[x, y + 1] != -7))
                     {
                          minID = filld[x, y + 1];
                          tempX = x;
                          tempY = y + 1;
                     }

                     if ((filld[x, y - 1] < minID) && (filld[x, y - 1] != -1) && (filld[x, y - 1] != -3) &&
                                                      (filld[x, y - 1] != -5) && (filld[x, y - 1] != -7))
                     {
                          minID = filld[x, y - 1];
                          tempX = x;
                          tempY = y - 1;
                     }

                     filld[x, y] = -1;
                     Ni = minID;
                     x = tempX;
                     y = tempY;

                 }
            } while (Ni >0 || ((x!=startX)&&(y!=startY)) );
        }
       #endregion

        #region Output
       public void Output()
        {
            //вывод маски минимального маршрута;
            System.Console.WriteLine("Маска минимального маршрута от S до F имеет следующий вид :\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (filld[i, j] == -1 || filld[i, j] == -5 || filld[i, j] == 0) System.Console.Write(" ");
                    else System.Console.Write("#");
                }
                System.Console.WriteLine();
                
            }
            System.Console.ReadLine();
        }
       #endregion

    }
}