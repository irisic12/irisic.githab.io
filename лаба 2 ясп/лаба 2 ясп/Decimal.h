#pragma once
const size_t ARR_SIZE = 100;
const unsigned char ZERO = (unsigned char)('0');


class Decimal
{
public:
	Decimal(unsigned int value = 0); 
	Decimal(const std::string& value); 

	Decimal operator+(const Decimal& other);									
	Decimal operator-(const Decimal& other);									
	Decimal operator*(const Decimal& other);									
	bool operator<(const Decimal& other);										
	bool operator>(const Decimal& other);										
	bool operator==(const Decimal& other);										
	bool operator!=(const Decimal& second);										
	bool operator>=(const Decimal& second);										
	bool operator<=(const Decimal& second);										
	Decimal& operator=(const unsigned int value);								
	Decimal& operator=(const std::string value);								

	friend std::ostream& operator<<(std::ostream& os, const Decimal& digit);	
private:
	size_t size = 0;
	unsigned char* data = new unsigned char[ARR_SIZE];
};