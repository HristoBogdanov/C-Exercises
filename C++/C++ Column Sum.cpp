

#include <iostream>
using namespace std;

int main()
{
    int r, c;
    cout << "Rows:"; cin >> r;
    cout << "Colums:"; cin >> c;
    int *arr = new int(r*c);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            cout << "Enter row element " << i << " and column element " << j << '\n';
            cin >> arr[i, j];
        }
    }
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            
            cout << arr[i,j] << " ";
        }
        cout << '\n';
    }

}


