#pragma once
#include <iostream>

using namespace std;
//========================Task 2===================================
/*Создать базовый класс список Реализовать на базе
списка стек и очередь с виртуальными функциями
вставки и вытаскивания

ДЛЯ ЭКОНОМИИ ВРЕМЕНИ В РЕШЕНИИ ОТСУТСТВУЮТ МНОГИЕ НЕОБХОДИМЫЕ 
МЕТОДЫ, ТАКИЕ КАК ДЕСТРУКТОРЫ и пр.*/

template <class T>
struct Element {
	T data;
	Element<T>* next;
};

template <class T>
class List {
public:
	virtual void push(T) = 0;
	virtual T pop() = 0;
};

template <class T>
class Stack : public List<T> {
private:
	Element<T>* m_pTop;
public:
	Stack() {
		m_pTop = nullptr;
	}

	virtual void push(T data) {
		Element<T>* temp = new Element<T>;
		temp->data = data;
		temp->next = m_pTop;
		m_pTop = temp;
	}

	virtual T pop() {
		if (m_pTop == nullptr)
			return 0;
		Element<T>* temp;
		T data;
		data = m_pTop->data;
		temp = m_pTop;
		m_pTop = temp->next;
		delete temp;
		return data;
	}


};

template <class T>
class Queue : public List<T> {
private:
	Element<T>* m_pWait;
	Element<T>* m_pTail;
	size_t m_size;
public:
	Queue(){
		m_pWait = nullptr;
		m_pTail = nullptr;
	}
	virtual void push(T data) {
		Element<T>* temp = new Element<T>;
		temp->data = data;
		temp->next = nullptr;
		if (!m_pWait) m_pWait = m_pTail = temp;
		else {
			m_pTail->next = temp;
			m_pTail = m_pTail->next;
		}
	}

	virtual T pop() {
		if (m_pWait == nullptr) return 0;
		Element<T>* temp;
		T data;
		data = m_pWait->data;
		temp = m_pWait;
		m_pWait = temp->next;
		delete temp;
		return data;
	}
};



