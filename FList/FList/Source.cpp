#include <iostream>
#include <fstream>
#include <Windows.h>
#include "FList.h"
FList Task(const FList& list, const std::string& name);

int main() 
{
	SetConsoleOutputCP(1251);
	const char* fname = "Data.txt";
	std::ifstream file(fname);
	if (file)
	{
		FList list(file);
		list.print();
		std::cout << "\nНовый список: \n\n";
		std::string str = "Ulyana";
		FList new_list = Task(list, str);
		new_list.print();
	}
	else
		std::cout << "Ошибка чтения файла\n";
	file.close();
	return 0;
}

FList Task(const FList& list, const std::string& name)
{
	FList result;
	ptrNode ptr = list.get_head();
	while (ptr)
	{
		if (ptr->info.getName() != name)
		{
			result.add_to_tail(ptr->info);
		}
		ptr = ptr->next;
	}
	return result;
}