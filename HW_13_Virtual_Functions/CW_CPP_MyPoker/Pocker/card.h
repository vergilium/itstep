#pragma once
#include <random>
#include <algorithm>
#include <iterator>
#include <iostream>
#include <memory>
#include <chrono>

#include "console.h"

#define C_COMBINATION_SIZE	5		//Колличество карт комбинации игрока

constexpr auto U_SPAID = L"\u2660";	//иконка Пики;
constexpr auto U_HEART = L"\u2665";	//иконка Чирва;
constexpr auto U_CLUB = L"\u2663";	//иконка Трефа;
constexpr auto U_DIAMOND = L"\u2666";	//иконка Бубны;


using namespace std;

namespace cardstd {

	enum class suits { spaid, heart, club, diamond };  //Масти карт - Пика, Чирва, Трефа, Бубны
	enum ranks { R2, R3, R4, R5, R6, R7, R8, R9, R10, Jack, Queen, King, Ace};  //достоинства карт 2 - 10, Валет, Дама, Король, Туз
	enum class combinations { HightCard = 1, OnePair,TwoPairs, Set, Straight, Flush, FullHouse, Quads, StraightFlusht, RoyalFlush	};	//Комбинации по возрастанию

	/////////////////////////////////////////////////////////////////////////
	////		Класс Карта
	////		Используется в классе КолодаКарт
	////		Может быть инициализирован только классом Колода Карт
	/////////////////////////////////////////////////////////////////////////
	class Card{
		friend class CardsDesk;
	private:
		int m_weight;
		Card(int weight) : m_weight(weight) {}
	public:
		//////Получене ранга и масти
		suits getSuit();
		ranks getRank();
		
		//void print();

		friend wostream& operator<< (wostream& wstream, const Card& obj) {
			switch ((suits)(obj.m_weight / 13)) {
			case suits::spaid: wstream << U_SPAID; break;
			case suits::heart: wstream << U_HEART; break;
			case suits::club: wstream << U_CLUB; break;
			case suits::diamond: wstream << U_DIAMOND; break;
			default:break;
			}
			switch ((ranks)(obj.m_weight % 13)) {
			case ranks::R2:
			case ranks::R3:
			case ranks::R4:
			case ranks::R5:
			case ranks::R6:
			case ranks::R7:
			case ranks::R8:
			case ranks::R9:
			case ranks::R10: wstream << (obj.m_weight % 13) + 2; break;
			case ranks::Jack: wstream << L"J"; break;
			case ranks::Queen: wstream << L"Q"; break;
			case ranks::King: wstream << L"K"; break;
			case ranks::Ace: wstream << L"A"; break;
			default:break;
			}
			return wstream;
		}
		
	};

	///////////////////////////////////////////////////////////////////////////////////////////////////////
	////		Класс КолодаКарт
	////		Состоит из множества Карт, Каждая карта это число которое определяет масть и достоинство
	///////////////////////////////////////////////////////////////////////////////////////////////////////
	class CardsDesk {
	private:
		vector<int> m_aCards;
	public:
		CardsDesk();
		/////////Количество карт в колоде
		size_t count();
		////////////////
		////Перетасовка колоды карт
		void shuffle();
		////////////////
		////Вытащить карту с колоды
		Card getNextCard();
	};

	////////////////////////////////////////////////////////////////////////////////////////////////////////////
	////		Класс КомбинацияКарт на руках у игрока
	////		В этом классе происходит раздача карт и определение уровня комбинации по силе
	////////////////////////////////////////////////////////////////////////////////////////////////////////////
	class CardsCombination : virtual public console::ConsoleOut{
	private:
		vector<Card> m_lpComb;	//Колекция карт игрока
		vector<size_t> indSingleCards;		//индексы карт не участвующих в выиграшной комбинации
		pair<combinations, int>  m_cmbResult;	//Результат - комбинация/уровень (уровень нужен в случае если у игроков одинаковые комбинации)
		
		///////////////////////////////////////////////////
		//		Поиск последовательности достоинств (true = все карты по порядку)
		bool findSequence(vector<ranks>& rnk, int start);

	public:
		CardsCombination() { m_lpComb.reserve(C_COMBINATION_SIZE); }		//Буфер для получения 5ти карт

		//////////////////////////////////////////////////
		//		Получить раздачу с колоды
		bool getDeal(CardsDesk& cDesk);
		///////Получить из колоды одну карту
		bool getNewCard(CardsDesk& cDesk, int numCard);
		//////Получить список индексов карт которые не участвуют в выиграшной комбинации
		vector<size_t> getSingleCards() {
			vector<size_t> _v(indSingleCards.size());
			copy(indSingleCards.begin(), indSingleCards.end(), _v.begin());
			return _v;
		}
		//////Получение результата собраной комбинации
		pair<combinations, int> getResult();
		//////Сброс предыдущей комбинации
		void resetComb();
		//////Сортировака карт по масти + по рангу
		void sortComb();

		//////////////////////////////////////////////////
		//		Определить силу комбинации
		void findCombinations();
		///////Вывод силы комбинации
		void dispResult();
		///////Вывод карты (одной) на экран 
		void fillCardFace(short numCard);
		///////Вывод всей комбинации на экран
		void displayCombination();


	};
}