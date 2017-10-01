using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States.States
{
    class Kingdom : State
    {

        public Kingdom(string name, int territory, int population, List<string> adminUnits, int army, int treasury):
            base(name, territory, population, adminUnits, army, treasury)
        {
            minRangeForPeopleNumberChange = -5;
            maxRangeForPeopleNumberChange = +15;

            minRangeForRevenuePerInhabitant = 20;
            maxRangeForRevenuePerInhabitant = 80;
            minRangeForArmyExpenses = -1000;
            maxRangeForArmyExpenses = -800;
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
        //leader = Authorities.KING;





    }
}
