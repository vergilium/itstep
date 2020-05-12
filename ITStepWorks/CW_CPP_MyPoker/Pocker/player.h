#pragma once
#include <string>

#include "card.h"
#include "console.h"

using namespace std;

namespace playerstd {

	class Player : virtual public console::ConsoleOut, public cardstd::CardsCombination {
	private:
		string m_lpName;
		int m_moneys;
		int m_bet;
		bool m_winer;

	public:
		Player(COORD p_crd, COORD p_name, COORD p_money, COORD p_comb, string name = "Player");
		//////Получение имени игрока
		string getName();
		//////Получение остатка на счету
		int getMoney();
		//////Получение суммы сделаной ставки
		size_t getBet();
		//////Возвращает статус игрока Выиграл/Проиграл
		bool getWin();
		//////Сброс ставок и возврат в кошелек
		void resetBet();
		//////Установка статуса Победитель
		void isWiner();
		//////Установка статуса по умолчанию (проиграл)
		void resetWin();
		//////Получение выигрыша и зачисление в кошелек
		void takeWin(int win);
		//////Запись данных игрока (Имени и баланс кошелька)
		void fillPlayerData();
		void clearPlayerData(bool all = false);
		//////Вычет денег из кошелька (процесс cтавок)
		int popMoney(int sum);
		/////Возврат денег из ставки (НЕ ВЫИГРЫШ)
		/////возвращаются только деньги которые игрок поставил
		int pushMoney(int sum);
	};
}
