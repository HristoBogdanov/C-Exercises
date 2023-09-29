
#include <iostream>
using namespace std;

int main()
{
	int count;
	struct car
	{
		string model;
		int price;
		int year;
	};
	cout << "Enter Count: "; cin >> count;
	car* cars = new car[count];

	for (int i = 0; i < count; i++)
	{
		cout << "Enter car model: "; cin >> cars[i].model;
		cout << "Enter car price: "; cin >> cars[i].price;
		cout << "Enter car year: "; cin >> cars[i].year;
	}
	for(int i=0;i<count;i++)
	{ 
		cout << "Model: " << cars[i].model << " price: " << cars[i].year << "year: "<<cars[i].year<<'\n';
	}
}


