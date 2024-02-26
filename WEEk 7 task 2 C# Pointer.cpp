// Week 7 Tasks C++
#include <iostream>

using namespace std;

    void IncrementValue(int* ptr)
    {
        (*ptr++);
    }

int main()

{
    int myVariable = 2;
    IncrementValue(&myVariable);
    std::cout <<"Modified "
}