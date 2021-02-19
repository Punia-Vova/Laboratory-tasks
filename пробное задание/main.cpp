//
//  main.cpp
//  пробное задание
//
//  Created by Владимир on 19.02.21.
//

#include <iostream>
#include <fstream>
#include <iostream>
using namespace:: std;
int main()
{
    ifstream fin("hill.in");
    ofstream fout("hill.out");
    long a=1000;
    long* mas=new long [a];
    if(!fin.is_open())
    {
        cout << "Файл не может быть открыт!";
    }
    else
    {
        int x,i=0;
        while(fin>>x)
        {
            mas[i]=x;
            i++;
        }
        long k;
        cin>>k;
        for(int t=0;t<i;t++)
        {
            if(mas[t]==k)
            {
                cout<<"такой цифры в данном масcиве нету"<<endl;
            }
            else
            {
                cout<<"таклй цифры в данном массиве нету"<<endl;
            }
        }
    }
}
