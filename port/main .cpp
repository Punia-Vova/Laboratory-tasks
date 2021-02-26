//
//  main.cpp
//  порт
//
//  Created by Владимир on 21.02.21.
//
#include <fstream>
#include <iostream>
#include <string>
#include <iostream>
using namespace::std;
int main()
{
    ifstream fin("hill.in");
    ofstream fout("hill.out");
    if(!fin)
     {
         cout<<"не удалось открыть файл"<<endl;
     }
    else
    {
        long k=1000;
        long n;
        fin >> n;
        string a;
        string* mas=new string[n];
        string* reid=new string[k];
        for(int i = 0; i < n; i++)
        {
            mas[i]="0";
        }
        for(int i = 0; i < k; k ++)
        {
            reid[i]="0";
        }
        int o;
        if(fin>>o)
        {
            fin>>o;
           
            if(o==1)
            {
                getline(fin,a);
                if(reid[0]=="0" && mas[n]=="0")
                {
                    for(int i = 0; i < n; i++)
                    {
                        if(mas[i]=="0")
                        {
                            mas[i]=a;
                            fout<<"в порт прибыл корабль:"<<mas[i]<<endl;
                            fout<<"корабль:"<<mas[i]<<" прибыл на причал:"<<i<<endl;
                        }
                    }
                }
                else
                {
                    for(int i=0; i<k;i++)
                    {
                        if(reid[i]=="0")
                        {
                            reid[i]=a;
                            fout<<"в порт прибыл корабль:"<<reid[i]<<endl;
                            break;
                        }
                    }
                }
            }
            
            if(o==2)
            {
                int t=0;
                fin >> t;
                mas[t]=reid[0];
                fout<<"причал:"<<t<<"освободился на это место приплыл новый корабль:"<<mas[t]<<endl;
                for(int i=0;i<k-1;i++)
                {
                    if(reid[i+1]=="0")
                    {
                        break;
                    }
                    swap(reid[i],reid[i+1]);
                }
            }
            
            
            if(o==3)
            {
                long p=0;
                fout<<"в гавани находяться:";
                for(int i=0; i<k;i++)
                {
                    if(reid[i]!="0")
                    {
                        p++;
                        fout<<reid[i]<<",";
                    }
                }
                fout<<endl;
                fout<<p<<"кораблей"<<endl;
            }
            
            if(o==4)
            {
                {
                    long p=0;
                    fout<<"на причалах находяться:";
                    for(int i=0; i<k;i++)
                    {
                        if(reid[i]!="0")
                        {
                            p++;
                            fout<<reid[i]<<",";
                        }
                    }
                    fout<<endl;
                    fout<<p<<"кораблей"<<endl;
                }
            }
        }
        delete[]mas;
        delete[]reid;
     }
    fin.close();
    fout.close();
}
