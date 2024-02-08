#pragma once
#include <string>
#include <iostream>

class Score
{
private:
	std::string number;
	std::string opening_date;
	std::string name;
	std::string type;
	std::string account_summa;
public:
	Score() {}
	Score(std::string number, std::string date, std::string client, std::string type, std::string summa) :
		number(number), opening_date(date), name(client), type(type), account_summa(summa) {}
	std::string getName()
	{
		return name;
	}

	bool operator<(const Score& score);
	bool operator==(const Score& score);
	bool operator>(const Score& score);
	bool operator<=(const Score& score);
	bool operator!=(const Score& score);
	bool operator>=(const Score& score);

	friend std::istream& operator>>(std::istream& file, Score& score);
	friend std::ostream& operator<<(std::ostream& fout, const Score& score);
};
