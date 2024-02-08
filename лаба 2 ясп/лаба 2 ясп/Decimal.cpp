#include<iostream>
#include<fstream>
#include"Decimal.h"


Decimal::Decimal(unsigned int value)
{
	*this = value;
}

Decimal::Decimal(const std::string& value) {
	*this = value;
}


Decimal& Decimal::operator=(unsigned int value) {
	unsigned int num = value;

	// convert int to chars
	while (num) {
		this->data[size] = unsigned char(num % 10 + ZERO);
		size++;
		num /= 10;
	}

	// filling zeroes
	for (size_t i = size; i < ARR_SIZE; ++i) {
        data[i] = ZERO;
    }

	// zero 
	if (value == 0) size = 1;
	return *this;

}

Decimal& Decimal::operator=(const std::string value) {
	size = value.size();

	for (size_t i = 0; i < value.size(); i++) {
		data[value.size() - 1 - i] = value[i];
	}

	for (size_t i = size; i < ARR_SIZE; ++i) {
		data[i] = ZERO;
	}

	return *this;
}



bool Decimal::operator<(const Decimal& other)
{
	if (this->size > other.size)return false;
	if (this->size < other.size)return true;

	for (size_t i = 0; i < this->size; i++) {
		if (this->data[i] < other.data[i]) return true;
		else if (this->data[i] > other.data[i]) return false;
	}

	return false;
}

bool Decimal::operator>(const Decimal& other)
{
	if (this->size < other.size)return false;
	if (this->size > other.size)return true;

	for (size_t i = 0; i < this->size; i++) {
		if (this->data[i] > other.data[i]) return true;
		else if (this->data[i] < other.data[i]) return false;
	}

	return false;
}
bool Decimal::operator==(const Decimal& other)
{
	if (this->size != other.size) return false;

	for (size_t i = 0; i < this->size; i++) {
		if (this->data[i] != other.data[i]) return false;
	}

	return true;
}
 
bool Decimal::operator!=(const Decimal& other)
{
	return !(*this==other);

}

bool Decimal::operator>=(const Decimal& other)
{
	return (*this == other) || (*this > other);

}

bool Decimal::operator<=(const Decimal& other)
{
	return (*this == other) || (*this < other);

}


Decimal Decimal::operator+(const Decimal& other) {
	Decimal result = 0;
	result.size = (this->size > other.size) ? this->size : other.size;

	int dop = 0;
	for (size_t i = 0; i < result.size; i++) {
		int dig1 = int(this->data[i] - ZERO);
		int dig2 = int(other.data[i] - ZERO);
		int res = dig1 + dig2 + dop;

		result.data[i] = unsigned char(res % 10 + ZERO);
		dop = res / 10;
	}

	if (dop) {
		result.data[result.size] = unsigned char(dop + ZERO);
		result.size++;
	}
	return result;
}

Decimal Decimal::operator-(const Decimal& other) {
	if (*this <= other) return Decimal(0);

	Decimal result = 0;
	result.size = this->size;

	int credit = 0;
	for (size_t i = 0; i < result.size; i++) {
		int dig1 = int(this->data[i] - ZERO);
		int dig2 = int(other.data[i] - ZERO);
		int res = dig1 - dig2 - credit;
		credit = 0;

		if (res < 0) {
			credit = 1;
			res += 10;
		}

		result.data[i] = unsigned char(res % 10 + ZERO);
	}

	// repair size
	while (result.size > 1 && result.data[result.size - 1] == ZERO) result.size--;

	return result;

}

Decimal Decimal::operator*(const Decimal& other)
{
	Decimal result = 0;
	result.size = this->size + other.size;
	int carry = 0;
	int prod = 0;

	for (size_t i = 0; i < this->size; i++)
	{
		for (size_t j = 0; j < other.size; j++)
		{
			int dig1 = int(this->data[i] - ZERO);
			int dig2 = int(other.data[j] - ZERO);
			int digRes = int(result.data[i + j] - ZERO);

			prod = dig1 * dig2 + digRes + carry;
			result.data[i + j] = unsigned char(prod % 10 + ZERO);
			carry = prod / 10;
		}

		result.data[other.size+i] += carry;
		carry = 0;
		
	}

	// repair size
	while (result.size > 1 && result.data[result.size - 1] == ZERO)
		result.size--;

	return result;
}


std::ostream& operator << (std::ostream& os, const Decimal& digit)
{
	for (size_t i = digit.size - 1; i > 0; --i)
	{
		os << unsigned int(digit.data[i] - ZERO);
	}
	os << unsigned int(digit.data[0] - ZERO);
	return os;
}