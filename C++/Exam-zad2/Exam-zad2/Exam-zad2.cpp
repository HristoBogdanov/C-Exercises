

#include <iostream>
using namespace std;

int main()
{
    int arr [3][3];
    arr[0][0] = 1;
    arr[0][1] = 2;
    arr[0][2] = 3;
    arr[1][0] = 4;
    arr[1][1] = 5;
    arr[1][2] = 6;
    arr[2][0] = 5;
    arr[2][1] = 8;
    arr[2][2] = 9;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << arr[i][j] << " ";
        }
        cout << "\n";
    }
    cout << "\n";

    int pom[3];
    pom[0] = arr[0][0];
    pom[1] = arr[1][0];
    pom[2] = arr[2][0];

    arr[0][0] = arr[0][2];
    arr[1][0] = arr[1][2];
    arr[2][0] = arr[2][2];

    arr[0][2] = pom[0];
    arr[1][2] = pom[1];
    arr[2][2] = pom[2];

    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << arr[i][j] << " ";
        }
        cout << "\n";
    }
    cout << "\n";
}

