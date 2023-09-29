

#include <iostream>
using namespace std;

int main()
{
    struct Student
    {
        string nameStudent;
        int bal;
        int spec;
    };
    Student* students = new Student[5];
    for (int i = 0; i < 5; i++)
    {
        cout << "Enter student name:"; cin >> students[i].nameStudent; cout << '\n';
        cout << "Enter student bal:"; cin >> students[i].bal; cout << '\n';
        cout << "Enter student spec:"; cin >> students[i].spec; cout << '\n';
    }
    Student max = students[0];
    for (int i = 0; i < 5; i++)
    {
        if (students[i].nameStudent == "Ivan") cout << "The student with name Ivan has : " << students[i].bal <<" bal " << " and : " << students[i].spec << " speciality." << '\n';
        if (students[i].bal > max.bal)max=students[i];
    }
    cout << "Student with the highest bal is: " << max.nameStudent << " with : " << max.bal << " bal." << '\n';
}

