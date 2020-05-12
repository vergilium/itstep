#include "card.h"
using namespace cardstd;
//////////////////
//	Класс Card	//
//////////////////

suits Card::getSuit() {
	return (suits)(m_weight / 13);
}

ranks Card::getRank() {
	return (ranks)(m_weight % 13);
}

//////////////////////
//	Класс CardsDesk	//
//////////////////////

CardsDesk::CardsDesk() : m_aCards{ 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,
								21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,
								41,42,43,44,45,46,47,48,49,50,51 } {}

size_t CardsDesk::count() {
	return m_aCards.size() - 1;
}
void CardsDesk::shuffle() {
	std::random_device rd;
	std::mt19937 g(rd());
	std::shuffle(m_aCards.begin(), m_aCards.end(), g);
}

Card CardsDesk::getNextCard() {
	if (m_aCards.empty()) {
		//Выбраны все карты из колоды
		return -1;
	}
	Card crd(m_aCards.back());
	m_aCards.pop_back();
	return crd;
}

//////////////////////////////
//	Класс CardsColection	//
//////////////////////////////
bool CardsCombination::findSequence(vector<ranks>& rnk, int start) {
	if ((start + 1) == C_COMBINATION_SIZE) return true;
	if (rnk.at(start) + 1 == rnk.at(start+1))
		findSequence(rnk, ++start);
	else return false;
}

bool CardsCombination::getDeal(CardsDesk& cDesk) {
	m_lpComb.clear();
	for (auto i = 0; i < C_COMBINATION_SIZE; ++i) {
		if (cDesk.count() > 0) 
			m_lpComb.push_back(cDesk.getNextCard());
		else
			return false;
	}
	return true;
}

bool CardsCombination::getNewCard(CardsDesk& cDesk, int numCard) {
	if (cDesk.count() > 0) {
		m_lpComb[numCard] = cDesk.getNextCard();
		return true;
	}
	else return false;
}

pair<combinations, int> CardsCombination::getResult() {
	return m_cmbResult;
}

void CardsCombination::resetComb() {
	m_lpComb.clear();
	m_cmbResult = {};
}

void CardsCombination::sortComb() {
	sort(m_lpComb.begin(), m_lpComb.end(), [](Card crd_a, Card crd_b) {return crd_a.getSuit() < crd_b.getSuit(); });
	sort(m_lpComb.begin(), m_lpComb.end(), [](Card crd_a, Card crd_b) {return crd_a.getRank() < crd_b.getRank(); });

}

void CardsCombination::findCombinations() {
	suits st_buf = m_lpComb.begin()->getSuit();
	vector<ranks> _runks;
	//===================================================================
	//		
	bool m_isOneSuit = true;
	for (auto iter = m_lpComb.begin(); iter != m_lpComb.end(); ++iter) {
		if (st_buf != iter->getSuit()) {
			m_isOneSuit = false;
		}
		_runks.push_back(iter->getRank());
	}
	sort(_runks.begin(), _runks.end());
	//====================================================================

	//====================================================================
	//		Проверка комб. На Стрит-Флэш, Роял-Флэш и Стрит
	//====================================================================
	if (findSequence(_runks, 0)) {
		if (m_isOneSuit == true) {
			m_cmbResult.first = combinations::StraightFlusht;
			m_cmbResult.second = _runks.at(0);
			if (m_cmbResult.second == ranks::R10) m_cmbResult.first = combinations::RoyalFlush;	// комбинация начинается с R10 по Ase, т.е Роял-Флеш
		}
		else {
			m_cmbResult.first = combinations::Straight;
			m_cmbResult.second = _runks.at(0);
		}
	}
	//======================================================================
	//		Проверка на Флэш
	//======================================================================
	if (m_isOneSuit && (m_cmbResult.first < combinations::Flush)) {
		m_cmbResult.first = combinations::Flush;
		m_cmbResult.second = 0;
	}
	//======================================================================

	vector<pair<ranks, int>> repBuf;
	int tmp;
	indSingleCards.clear();
	for (auto iter = _runks.begin(); iter != _runks.end(); ++iter) {
		tmp = count(_runks.begin(), _runks.end(), *iter);
		if (tmp > 1) {
			if(repBuf.empty()) repBuf.push_back({ *iter, tmp });
			else {
				if (find(repBuf.begin(), repBuf.end(), pair<ranks,int>{ *iter, tmp }) == repBuf.end())
					repBuf.push_back({ *iter, tmp });
			}
		}
		else {
			indSingleCards.push_back(distance(_runks.begin(), iter));
		}
	}
	//======================Определение Карэ===============================
	if (repBuf.size()) {
		if (repBuf.at(0).second == 4) {
			if (m_cmbResult.first < combinations::Quads) {
				m_cmbResult.first = combinations::Quads;
				m_cmbResult.second = repBuf.at(0).first;
			}
		}
		else if (repBuf.size() == 2) {
			if (repBuf.at(0).second == 3 || repBuf.at(1).second == 3) {
				//=============================Определение Фул-Хаус=======================
				if (repBuf.at(0).second == 2 || repBuf.at(1).second == 2) {
					if (m_cmbResult.first < combinations::FullHouse) {
						m_cmbResult.first = combinations::FullHouse;
						m_cmbResult.second = repBuf.at(0).first + repBuf.at(1).first;
					}
				}
			}
			//===============================Определение Две пары=========================
			else {
				if (m_cmbResult.first < combinations::TwoPairs) {
					m_cmbResult.first = combinations::TwoPairs;
					m_cmbResult.second = repBuf.at(0).first + repBuf.at(1).first;
				}
			}
		}
		else if (repBuf.size() == 1) {
			//=============================Определение Сет============================
			if (repBuf.at(0).second == 3) {
				if (m_cmbResult.first < combinations::Set) {
					m_cmbResult.first = combinations::Set;
					m_cmbResult.second = repBuf.at(0).first;
				}
			}
			//===================================Определение Одна Пара========================
			else {
				if (m_cmbResult.first < combinations::OnePair) {
					m_cmbResult.first = combinations::OnePair;
					m_cmbResult.second = repBuf.at(0).first;
				}
			}
		}
	}
	//======================================Определение Старшая карта=====================
	if (m_cmbResult.first < combinations::HightCard) {
		m_cmbResult.first = combinations::HightCard;
		m_cmbResult.second = _runks.back();
	}
}

void CardsCombination::dispResult() {
	console::ConsoleOut::clearLine(m_COORD_comRes, 14);
	gotoxy(m_COORD_comRes);
	wcout << L"[ " << console::ConsoleOut::m_lpCombStr.at((int)m_cmbResult.first).c_str() << " ]";
}

void CardsCombination::fillCardFace(short numCard) {
	console::ConsoleOut::gotoxy({ console::ConsoleOut::m_COORD_card1.X + (numCard * CARD_DISTANCE), console::ConsoleOut::m_COORD_card1.Y });
	wcout << m_lpComb.at(numCard);
}

void CardsCombination::displayCombination() {
	short card_distance = 0;
	
	for (auto iter = m_lpComb.begin(); iter != m_lpComb.end(); ++iter, card_distance += CARD_DISTANCE) {
		console::ConsoleOut::clearCard({ console::ConsoleOut::m_COORD_card1.X + card_distance, console::ConsoleOut::m_COORD_card1.Y });
		console::ConsoleOut::gotoxy({console::ConsoleOut::m_COORD_card1.X + card_distance, console::ConsoleOut::m_COORD_card1.Y});
		wcout << *iter;
	}
}