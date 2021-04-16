//
//  PapaMama.hpp
//  папа и мама
//
//  Created by Владимир on 15.04.21.
//

#ifndef PapaMama_hpp
#define PapaMama_hpp

#include <stdio.h>
#pragma once
#include<string>
using namespace std;
class PapaMama
{
private:
    string _message;
    int  _repeats;
    int _delay;
public:
    static int num_of_repeats;
    PapaMama(string, int, int);
    void operator()();
};
#endif /* PapaMama_hpp */
