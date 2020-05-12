#include "smart.h"

smartstd::Smart::Smart() : m_res(null), m_pHoldCards{ -1, -1 } {}

result smartstd::Smart::getAction() {
	return m_res;
}

int* smartstd::Smart::getholdCards() {
	return m_pHoldCards._Elems;
}

void smartstd::Smart::smrtAction(cardstd::combinations pwrComb, vector<size_t> _ind, int bet) {

	for (size_t i = 0; i < 2; ++i) {
		if (!_ind.empty()) {
			m_pHoldCards[i] = _ind.back();
			_ind.pop_back();
		}
	}

	switch (pwrComb) {
	case combinations::HightCard:
		if (bet <= 10) m_res = result::equaliseBet;
		else m_res = result::dropCards;
		break;
	case combinations::OnePair:
		if (bet <= 50) m_res = result::equaliseBet;
		else m_res = result::dropCards;
		break;
	case combinations::TwoPairs:
	case combinations::Set:
		m_res = result::equaliseBet;
		break;
	case combinations::Straight:
	case combinations::Flush:
		m_res = result::rizeBet;
		break;
	case combinations::FullHouse:
	case combinations::Quads:
		m_res = result::hightRizeBet;
	case combinations::StraightFlusht:
	case combinations::RoyalFlush:
		m_res = result::maxBet;
		break;
	default:break;
	}

}