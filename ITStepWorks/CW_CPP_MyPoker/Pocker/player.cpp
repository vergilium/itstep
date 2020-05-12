#include "player.h"

playerstd::Player::Player(COORD p_crd, COORD p_name, COORD p_money, COORD p_comb, string name) :ConsoleOut(p_crd, p_name, p_money, p_comb), CardsCombination(), m_lpName(name), m_moneys(100), m_winer(false), m_bet(0) {}

string playerstd::Player::getName() {
	return m_lpName;
}

size_t playerstd::Player::getBet() {
	return m_bet;
}

bool playerstd::Player::getWin() {
	return m_winer;
}

int playerstd::Player::getMoney() {
	return m_moneys;
}

void playerstd::Player::resetBet() {
	m_bet = 0;
}

void playerstd::Player::isWiner() {
	m_winer = true;
}

void playerstd::Player::resetWin() {
	m_winer = false;
}

void playerstd::Player::takeWin(int win) {
	m_moneys += win;
	m_bet = 0;
}

void playerstd::Player::fillPlayerData() {
	gotoxy(m_COORD_name);
	wcout << m_lpName.c_str();
	clearLine(m_COORD_money, 5);
	gotoxy(m_COORD_money);
	wcout << m_moneys;
}

void playerstd::Player::clearPlayerData(bool all) {
	if (all) {
		clearLine(m_COORD_name, m_lpName.size());
		clearLine(m_COORD_money, 5);
	}
	clearLine(m_COORD_comRes, 14);

}

int playerstd::Player::popMoney(int sum) {
	if ((m_moneys - sum) >= 0) {
		m_moneys -= sum;
		m_bet += sum;
	}
	else return -1;
	return sum;
}

int playerstd::Player::pushMoney(int sum) {
	if ((m_bet - sum) >= 0) {
		m_moneys += sum;
		m_bet -= sum;
	}
	else return -1;
	return sum;
}