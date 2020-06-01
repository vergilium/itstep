#include "Firm.h"



Firm::Firm()
{
	builderLicense = false;
	name = "";
}

Firm::Firm(string fName, bool bLicense, bool eLicense, bool cLicense)
{
	builderLicense = bLicense;
	name = fName;
	environmentalLicense = eLicense;
	cityLicense = cLicense;
}


Firm::~Firm()
{
}
