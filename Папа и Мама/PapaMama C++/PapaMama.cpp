//
//  PapaMama.cpp
//  папа и мама
//
//  Created by Владимир on 15.04.21.
//

#include "PapaMama.hpp"
#include<thread>
#include<iostream>
#include<mutex>

int PapaMama::num_of_repeats;
mutex mtx;

PapaMama::PapaMama(string message, int repeats, int delay)
{
    _message = message;
    _repeats = repeats;
    _delay = delay;
}

void PapaMama::operator()()
{
    int i = 0;
    mtx.lock();
    while (i < _repeats && num_of_repeats > 0)
    {
        cout << _message << endl;
        num_of_repeats--;
        mtx.unlock();
        i++;
        this_thread::sleep_for(chrono::milliseconds{_delay});
        mtx.lock();
    }
    mtx.unlock();
}
