using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace States.States
{
    public enum TransferOfPower { ELECTIONS, HERITAGE};
    public enum Authorities { MONARCH, KING, PRESIDENT, PARLIAMENT, CABINET_OF_MINISTRIES, COURT}

    abstract class State
    {
        public State(string name, int territory, int population, List<string> adminUnits, int army, int budget)
        {
            this.name = name;
            this.territory = territory;
            this.population = population;
            this.adminUnits = adminUnits;
            this.army = army;
            this.budget = budget;
            capital = adminUnits[0];

            DisplayCurrentStatus();

        }

        //-------------------------------------------------------------
        public abstract void MakeChangesToConstitution(bool isConstitution);

        //-------------------------------------------------------------
        public abstract void SetTheLeader();

        //-------------------------------------------------------------
        public abstract void ChangeLegislativeAuthority();

        //-------------------------------------------------------------
        public abstract void ChangeExecutiveAuthority();

        //-------------------------------------------------------------
        public abstract void ChangeLegalAuthority();

        //-------------------------------------------------------------
        protected void InitEvent()
        {
            Random rand = new Random();
            int currEvent =  rand.Next(-1,+1);
        }

        //-------------------------------------------------------------
        public abstract void GenerateEvents();

        //-------------------------------------------------------------
        public void RecruitDismissArmy(int people)
        {
            army+=people;
            population -= people;
        }

        //-------------------------------------------------------------
        public void Iterate()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Государство: \t{0}", this.name);
            Console.ForegroundColor = ConsoleColor.White;

            Random rand = new Random();
            double currRand = rand.NextDouble();
            Console.WriteLine("Случайное значение для событий: {0}", Math.Round(currRand, 2));

            InitEvent();

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("");
            //Console.WriteLine("Год {0}", periodNo);
            //Console.ForegroundColor = ConsoleColor.White;

            GetPopulationNumber();
            GetBudget();

            //periodNo++;
        }

        //-------------------------------------------------------------
        public void GetPopulationNumber()
        {
            Random rand = new Random();
            double populationIncrease = (double)rand.Next(this.minRangeForPeopleNumberChange, this.maxRangeForPeopleNumberChange) / 100;

            population = (int)(population * (1 + populationIncrease));
            Console.WriteLine("Темп роста населения: \t{0}", populationIncrease.ToString("P2"));
            Console.WriteLine("Население: \t\t{0}", population.ToString("# ###", CultureInfo.InvariantCulture));
        }

        //-------------------------------------------------------------
        public void GetBudget()
        {
            Random rand = new Random();
            int incomePerInhabitant = rand.Next(this.minRangeForRevenuePerInhabitant, this.maxRangeForRevenuePerInhabitant);
            Console.WriteLine("Входящее сальдо: \t{0}", budget.ToString("# ### ###"));

            int income = population * incomePerInhabitant;
            Console.WriteLine("Доход: \t\t\t{0}", income.ToString("# ### ###"));

            int expensesPerSoldier = rand.Next(this.minRangeForArmyExpenses, this.maxRangeForArmyExpenses);
            int armyExpenses = army * expensesPerSoldier;
            string format = "#,##0.00;(#,##0)";
            Console.WriteLine("Расходы на армию: \t{0}", armyExpenses.ToString(format));

            budget += income + armyExpenses;
            Console.WriteLine("Конечное сальдо: \t{0}", budget.ToString("# ### ###"));
        }


        //-------------------------------------------------------------
        public void DisplayCurrentStatus()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("Вы создали государство \t{0}", name);
            Console.WriteLine("Население: \t\t{0}", population.ToString("# ###"));
            Console.WriteLine("Территория: \t\t{0}", territory.ToString("# ###"));
            Console.WriteLine("Административные подразделения: ");
            foreach (string unit in adminUnits)
            {
                Console.WriteLine("-{0}", unit);
            }
            Console.WriteLine("Армия :\t\t\t{0} человек", army.ToString("# ###"));
            Console.WriteLine("Столица \t\tг. {0}", this.Capital);

            Console.ForegroundColor = ConsoleColor.White;
        }

        //-------------------------------------------------------------
        public string Capital
        {
            get
            { return capital; }

            set
            {
                if (capital != null)
                    capital = adminUnits[0];
                else
                    capital = value;
            }
        }
        //-------------------------------------------------------------
        string                  name;
        int                     territory;
        int                     population;
        List<string>            adminUnits;
        int                     army;
        int                     budget;

        bool                    isConstitution { get; set; }
        protected Authorities   leader { get; set; }
        Authorities             legislativeAuthority;
        Authorities             executiveAuthority;
        Authorities             legalAuthority;
        string                  capital;

        protected int           minRangeForPeopleNumberChange{ get; set; }
        protected int           maxRangeForPeopleNumberChange { get; set; }
        protected int           minRangeForRevenuePerInhabitant { get; set; }
        protected int           maxRangeForRevenuePerInhabitant { get; set; }
        protected int           minRangeForArmyExpenses { get; set; }
        protected int           maxRangeForArmyExpenses { get; set; }


    }
}
