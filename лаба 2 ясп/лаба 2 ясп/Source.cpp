//Ѕарбашина »рина, 2 курс, 9 группа ћќиј»—
//—оздать класс Decimal дл€ работы с беззнаковыми целыми дес€тичными числами,
//использу€ дл€ представлени€ числа массив из 100 элементов типа unsigned char,
//каждый из которых €вл€етс€ дес€тичной цифрой.ћладша€ цифра имеет меньший
//индекс(единицы Ц в нулевом элементе массива).–еальный размер массива задаетс€
//как аргумент конструктора инициализации.–еализовать арифметические операции
//сложени€, вычитани€, умножени€ и операции сравнени€.
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
	std::cout << "¬ведите 3 числа:\n";
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
	std::cout << "1. Cчитать с консоли\n";
	std::cout << "2. Cчитать с файла\n";
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
