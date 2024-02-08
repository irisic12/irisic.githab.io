#include "FList.h"

void FList::add_by_ptr(ptrNode& ptr, TInfo value)
{
	ptr = new Node(value, ptr);
}

FList::FList(std::ifstream& file)
{
	TInfo value;
	tail = head = nullptr;
	auto find_place = [this](TInfo value)->ptrNode
	{
		ptrNode result = head;
		while (result->next && result->next->info < value)
			result = result->next;
		return result;
	};
	while (file >> value)
	{
		if (empty() || head->info >= value)
			add_to_head(value);
		else
			add_by_ptr(find_place(value)->next, value);
	}
}

FList::FList(const FList& list)
{
	std::cout << "Copy Ctor\n";
	ptrNode ptr = list.head;
	this->tail = this->head = nullptr;
	while (ptr)
	{
		this->add_to_tail(ptr->info);
		ptr = ptr->next;
	}
}

FList& FList::operator=(const FList& list)
{
	std::cout << "= copy\n";
	this->clear();
	ptrNode ptr = list.head;
	while (ptr)
	{
		this->add_to_tail(ptr->info);
		ptr = ptr->next;
	}
	return *this;
}

FList::FList(FList&& list)
{
	std::cout << "move Ctor\n";
	this->head = list.head;
	this->tail = list.tail;
	list.tail = nullptr;
	list.head = nullptr;
}

FList& FList::operator=(FList&& list)
{
	std::cout << "= move\n";
	this->clear();
	this->head = list.head;
	this->tail = list.tail;
	list.tail = nullptr;
	list.head = nullptr;
	return *this;
}

FList::~FList()
{
	clear();
}

ptrNode FList::get_head() const
{
	return head;
}

bool FList::empty()
{
	return !head;
}

void FList::add_to_head(TInfo value)
{
	add_by_ptr(head, value);
	if (!head->next)
		tail = head;
}

void FList::add_to_tail(TInfo value)
{
	if (tail)
	{
		add_by_ptr(tail->next, value);
		tail = tail->next;
	}
	else
		add_to_head(value);
}

void FList::del_from_head()
{
	ptrNode p = head;
	head = head->next;
	delete p;
	if (!head)
		tail = head;

}

void FList::print()
{
	ptrNode ptr = head;
	while (ptr)
	{
		std::cout << ptr->info << "-----------------------------------\n";
		ptr = ptr->next;
	}
}

void FList::clear()
{
	while (head)
		del_from_head();
	tail = head = nullptr;
}

