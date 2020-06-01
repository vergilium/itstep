#pragma once
#include "Firm.h"

// класс, отвечающий за проверку экологической части строительства
class EnvironmentalService
{
public:
	EnvironmentalService();
	virtual ~EnvironmentalService();
	// есть ли у фирмы разрешение на строительство со стороны экологической службы
	bool HasEnvironmentalAccess(Firm* pFirm) {
		return pFirm->GetEnvironmentalLicense() ? true : false;
	}
};

