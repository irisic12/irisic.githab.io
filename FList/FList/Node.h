#pragma once
#include "Score.h"

using TInfo = Score;

class Node
{
public:
	TInfo info;
	Node* next;
	Node() {}
	Node(TInfo info, Node* ptr = nullptr) : info(info), next(ptr) {}
	~Node() { next = nullptr; }
};