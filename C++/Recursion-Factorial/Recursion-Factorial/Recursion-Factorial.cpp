
#include <iostream>
using namespace std;
int Factorial(int a)
{
    int t;
    if (a > 1)t = a * Factorial(a - 1);
    else return 1;

    return t;
}

int main()
{
    int number;
    cout << "Enter number: ";
    cin >> number;
    cout << "Factorial of " << number << " is " << Factorial(number);
}

