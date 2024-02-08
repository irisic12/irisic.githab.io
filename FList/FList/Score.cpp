
#include "Score.h"

bool Score::operator<(const Score& score)
{
    bool result = true;
    if (this->number > score.number)
        result = false;
    if (this->number == score.number)
    {
        if (this->opening_date > score.opening_date)
            result = false;
        if (this->opening_date == score.opening_date)
        {
            if (this->name > score.name)
                result = false;
            if (this->name == score.name)
            {
                if (this->type > score.type)
                    result = false;
                if (this->type == score.type)
                    if (this->account_summa > score.account_summa || this->account_summa == score.account_summa)
                        result = false;
            }
        }
    }
    return result;
}

bool Score::operator==(const Score& score)
{
    return this->number == score.number && this->opening_date == score.opening_date &&
        this->name== score.name && this->type == score.type &&
        this->account_summa == score.account_summa;
}

bool Score::operator>(const Score& score)
{
    return !(*this < score) && !(*this == score);
}

bool Score::operator>=(const Score& score)
{
    return !(*this < score);
}

bool Score::operator!=(const Score& score)
{
    return !(*this == score);
}

bool Score::operator<=(const Score & score)
{
    return (*this < score) || (*this == score);
}





std::istream& operator>>(std::istream& file, Score& score)
{
    std::getline(file, score.number);
    std::getline(file, score.opening_date);
    std::getline(file, score.name);
    std::getline(file, score.type);
    std::getline(file, score.account_summa);
    return file;
}

std::ostream& operator<<(std::ostream& fout, const Score& score)
{
    fout << score.number << '\n' << score.opening_date << '\n' << score.name << '\n' << score.type << '\n' << score.account_summa << '\n';
    return fout;
}
