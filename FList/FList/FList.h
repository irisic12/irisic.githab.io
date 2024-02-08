#pragma once
#include "Node.h"
#include <fstream>

using ptrNode = Node*;

class FList
{
private:
	ptrNode head, tail;

	void add_by_ptr(ptrNode& ptr, TInfo value);

public:
	FList() { tail = head = nullptr; }
	FList(std::ifstream& file);
	FList(const FList& list);
	FList& operator=(const FList& list);
	FList(FList&& list);
	FList& operator=(FList&& list);
	~FList();

	ptrNode get_head() const;
	bool empty();
	void add_to_head(TInfo value);
	void add_to_tail(TInfo value);
	void del_from_head();
	void print();
	void clear();
};

