//��������� �����, 2 ����, 9 ������ ������
//������� ����� Decimal ��� ������ � ������������ ������ ����������� �������,
//��������� ��� ������������� ����� ������ �� 100 ��������� ���� unsigned char,
//������ �� ������� �������� ���������� ������.������� ����� ����� �������
//������(������� � � ������� �������� �������).�������� ������ ������� ��������
//��� �������� ������������ �������������.����������� �������������� ��������
//��������, ���������, ��������� � �������� ���������.
#include<iostream>
#include<sstream>
#include<fstream>
#include<string>
#include"Decimal.h"

void menu();

void showAbilities(Decimal& a, Decimal& b, Decimal& c) {

	std::cout << "a = " << a << '\n';
	std::cout << "b = " << b << '\n';
	std::cout << "c = " << c << '\n';

	std::cout << "a + b = " << a + b << '\n';
	std::cout << "a + c = " << a + c << '\n';
	std::cout << "b + a = " << b + a << '\n';
	std::cout << "b + c = " << b + c << '\n';
	std::cout << "c + a = " << c + a << '\n';
	std::cout << "c + b = " << c + b << '\n';

	std::cout << "a - b = " << a - b << '\n';
	std::cout << "a - c = " << a - c << '\n';
	std::cout << "b - a = " << b - a << '\n';
	std::cout << "b - c = " << b - c << '\n';
	std::cout << "c - a = " << c - a << '\n';
	std::cout << "c - b = " << c - b << '\n';

	std::cout << "a * b = " << a * b << '\n';
	std::cout << "a * c = " << a * c << '\n';
	std::cout << "b * a = " << b * a << '\n';
	std::cout << "b * c = " << b * c << '\n';
	std::cout << "c * a = " << c * a << '\n';
	std::cout << "c * b = " << c * b << '\n';

	std::cout << "a > b = " << (a > b) << '\n';
	std::cout << "a > c = " << (a > c) << '\n';
	std::cout << "b > a = " << (b > a) << '\n';
	std::cout << "b > c = " << (b > c) << '\n';
	std::cout << "c > a = " << (c > a) << '\n';
	std::cout << "c > b = " << (c > b) << '\n';

	std::cout << "a >= b = " << (a >= b) << '\n';
	std::cout << "a >= c = " << (a >= c) << '\n';
	std::cout << "b >= a = " << (b >= a) << '\n';
	std::cout << "b >= c = " << (b >= c) << '\n';
	std::cout << "c >= a = " << (c >= a) << '\n';
	std::cout << "c >= b = " << (c >= b) << '\n';

	std::cout << "a < b = " << (a < b) << '\n';
	std::cout << "a < c = " << (a < c) << '\n';
	std::cout << "b < a = " << (b < a) << '\n';
	std::cout << "b < c = " << (b < c) << '\n';
	std::cout << "c < a = " << (c < a) << '\n';
	std::cout << "c < b = " << (c < b) << '\n';

	std::cout << "a <= b = " << (a <= b) << '\n';
	std::cout << "a <= c = " << (a <= c) << '\n';
	std::cout << "b <= a = " << (b <= a) << '\n';
	std::cout << "b <= c = " << (b <= c) << '\n';
	std::cout << "c <= a = " << (c <= a) << '\n';
	std::cout << "c <= b = " << (c <= b) << '\n';

	std::cout << "a == b = " << (a == b) << '\n';
	std::cout << "a == c = " << (a == c) << '\n';
	std::cout << "b == a = " << (b == a) << '\n';
	std::cout << "b == c = " << (b == c) << '\n';
	std::cout << "c == a = " << (c == a) << '\n';
	std::cout << "c == b = " << (c == b) << '\n';

	std::cout << "a != b = " << (a != b) << '\n';
	std::cout << "a != c = " << (a != c) << '\n';
	std::cout << "b != a = " << (b != a) << '\n';
	std::cout << "b != c = " << (b != c) << '\n';
	std::cout << "c != a = " << (c != a) << '\n';
	std::cout << "c != b = " << (c != b) << '\n';
}



void showAbilitiesFiles(Decimal& a, Decimal& b, Decimal& c) {
	std::ofstream fout("output.txt");
	fout << "a = " << a << '\n';
	fout << "b = " << b << '\n';
	fout << "c = " << c << '\n';

	fout << "a + b = " << a + b << '\n';
	fout << "a + c = " << a + c << '\n';
	fout << "b + a = " << b + a << '\n';
	fout << "b + c = " << b + c << '\n';
	fout << "c + a = " << c + a << '\n';
	fout << "c + b = " << c + b << '\n';

	fout << "a - b = " << a - b << '\n';
	fout << "a - c = " << a - c << '\n';
	fout << "b - a = " << b - a << '\n';
	fout << "b - c = " << b - c << '\n';
	fout << "c - a = " << c - a << '\n';
	fout << "c - b = " << c - b << '\n';

	fout << "a * b = " << a * b << '\n';
	fout << "a * c = " << a * c << '\n';
	fout << "b * a = " << b * a << '\n';
	fout << "b * c = " << b * c << '\n';
	fout << "c * a = " << c * a << '\n';
	fout << "c * b = " << c * b << '\n';

	fout << "a > b = " << (a > b) << '\n';
	fout << "a > c = " << (a > c) << '\n';
	fout << "b > a = " << (b > a) << '\n';
	fout << "b > c = " << (b > c) << '\n';
	fout << "c > a = " << (c > a) << '\n';
	fout << "c > b = " << (c > b) << '\n';

	fout << "a >= b = " << (a >= b) << '\n';
	fout << "a >= c = " << (a >= c) << '\n';
	fout << "b >= a = " << (b >= a) << '\n';
	fout << "b >= c = " << (b >= c) << '\n';
	fout << "c >= a = " << (c >= a) << '\n';
	fout << "c >= b = " << (c >= b) << '\n';

	fout << "a < b = " << (a < b) << '\n';
	fout << "a < c = " << (a < c) << '\n';
	fout << "b < a = " << (b < a) << '\n';
	fout << "b < c = " << (b < c) << '\n';
	fout << "c < a = " << (c < a) << '\n';
	fout << "c < b = " << (c < b) << '\n';

	fout << "a <= b = " << (a <= b) << '\n';
	fout << "a <= c = " << (a <= c) << '\n';
	fout << "b <= a = " << (b <= a) << '\n';
	fout << "b <= c = " << (b <= c) << '\n';
	fout << "c <= a = " << (c <= a) << '\n';
	fout << "c <= b = " << (c <= b) << '\n';

	fout << "a == b = " << (a == b) << '\n';
	fout << "a == c = " << (a == c) << '\n';
	fout << "b == a = " << (b == a) << '\n';
	fout << "b == c = " << (b == c) << '\n';
	fout << "c == a = " << (c == a) << '\n';
	fout << "c == b = " << (c == b) << '\n';

	fout << "a != b = " << (a != b) << '\n';
	fout << "a != c = " << (a != c) << '\n';
	fout << "b != a = " << (b != a) << '\n';
	fout << "b != c = " << (b != c) << '\n';
	fout << "c != a = " << (c != a) << '\n';
	fout << "c != b = " << (c != b) << '\n';

	fout.close();

}
void keybord_input()
{
	std::string x,y,z;
	std::cout << "������� 3 �����:\n";
	std::cin >> x >> y >> z;
	Decimal a(x);
	Decimal b(y);
	Decimal c(z);
	showAbilities(a, b, c);
	showAbilitiesFiles(a, b, c);
}

void file_input()
{
	std::ifstream file("long.txt");
	std::string x, y, z;
	file >> x >> y >> z;
	Decimal a(x);
	Decimal b(y);
	Decimal c(z);
	showAbilities(a, b, c);
	showAbilitiesFiles(a, b, c);
	file.close();
}


void menu()
{
	std::cout << "1. C������ � �������\n";
	std::cout << "2. C������ � �����\n";
	int choice;
	std::cin >> choice;
	switch (choice)
	{
	case 1:
		keybord_input();
		break;
	case 2:
		file_input();
		break;
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");
	menu();
	return 0;
}
