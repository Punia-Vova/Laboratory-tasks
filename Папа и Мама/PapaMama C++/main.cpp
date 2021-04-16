//
//  main.cpp
//  папа и мама
//
//  Created by Владимир on 15.04.21.
//

#include<iostream>
#include<thread>
#include<vector>
#include<string>
#include "PapaMama.hpp"
using namespace std;

int main()
{
    setlocale(LC_ALL, "ru");
    cout << "колько всего сообщений вы хотите вывести" << endl;
    cin >> PapaMama::num_of_repeats;
    cout << "сколько тредов вы хотите создать?" << endl;
    int numThr;
    cin >> numThr;
    string t;
    getline(cin, t);
    vector<thread> threads(numThr);
    vector<PapaMama> inform;
    for (int i = 0; i < numThr; i++)
    {
        cout << "Какое сообщение вы хотите вывести в  " << i + 1 << " треде?" << endl;
        string message;
        getline(cin, message);
        cout << "Сколько раз вы хотите вывести сообщение в " << i + 1 << " треде?" << endl;
        int rep;
        cin >> rep;
        cout << "С каким интервалом вы хотите выводить сообщения в " << i + 1 << " треде(в миллисекундах)?" << endl;
        int inter;
        cin >> inter;
        getline(cin, t);
        PapaMama papa{ message, rep, inter };
        inform.push_back(papa);
    }
    for(int i = 0; i < numThr; i++)
    {
        threads[i] = thread(inform[i]);
    }
    for (int i = 0; i < numThr; i++)
    {
        threads[i].join();
    }
}
