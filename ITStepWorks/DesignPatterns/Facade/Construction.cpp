#include "Construction.h"



Construction::Construction()
{
}


Construction::~Construction()
{
}

bool Construction::IsAllowed(Firm* pFirm) {
	cout << "\nLet's check for all permissions!\n";
	if (cService.HasCityAccess(pFirm) && coService.HasBuildingLicense(pFirm) && eService.HasEnvironmentalAccess(pFirm)) {
		return true;
	}
	return false;
}
