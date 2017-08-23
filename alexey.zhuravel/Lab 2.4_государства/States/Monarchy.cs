using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States.States
{
    class Monarchy : State
    {
        public Monarchy(string name, int territory, int population, List<string> adminUnits, int army, int treasury):
            base(name, territory, population, adminUnits, army, treasury)
        {
            minRangeForPeopleNumberChange = -5;
            maxRangeForPeopleNumberChange = 10;

            minRangeForRevenuePerInhabitant = 40;
            maxRangeForRevenuePerInhabitant = 60;
            minRangeForArmyExpenses = -1200;
            maxRangeForArmyExpenses = -900;
        }

        //-------------------------------------------------------------
        public override void ChangeExecutiveAuthority()
        {
            throw new NotImplementedException();
        }

        //-------------------------------------------------------------
        public override void ChangeLegalAuthority()
        {
            throw new NotImplementedException();
        }

        //-------------------------------------------------------------
        public override void ChangeLegislativeAuthority()
        {
            throw new NotImplementedException();
        }

        //-------------------------------------------------------------
        public override void GenerateEvents()
        {

        }

        //-------------------------------------------------------------
        public override void MakeChangesToConstitution(bool isConstitution)
        {
            throw new NotImplementedException();
        }

        //-------------------------------------------------------------
        public override void SetTheLeader()
        {
            throw new NotImplementedException();
        }

        //-------------------------------------------------------------



    }
}
