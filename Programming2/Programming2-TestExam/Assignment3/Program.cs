using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyTools;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();
            while(run)
            {
                run = program.Start();
            }
            
        }

        bool Start()
        {
            List<Premise> premises = ReadPremises("..\\..\\premises.txt");
            List<Party> parties = ReadParties("..\\..\\parties.txt");

            if(premises.Count < 1 || parties.Count < 1)
            {
                return false;
            }
            string user = ProcessPremises(premises);
            CompareParties(user, parties);

            return ProgramTools.LoopProgram();
        }

        void CompareParties(string user, List<Party> parties)
        {
            foreach( Party party in parties)
            {
                string name = party.name;
                double percentage = DetermineMatch(user, party);

                Console.WriteLine($"{name, -4} : {percentage.ToString(".0")} %");
            }
        }

        double DetermineMatch(string user, Party party)
        {
            int sameAnswers = 0;
            for (int index = 0; index < user.Length; index++)
            {
                if (user[index] == party.answers[index])
                {
                    sameAnswers++;
                }
            }
            return (double)100 * sameAnswers / user.Length;
        }

        string ProcessPremises(List<Premise> premises)
        {
            string userAnswers = "";
            for (int i = 0; i < premises.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(i + 1 + $". {premises[i].title}");
                Console.ResetColor();
                Console.WriteLine(premises[i].text);
                Console.WriteLine();
                int answer = ProcessOpinion("Enter your opinion (1 = agree / 2 = disagree / 3 = no opinion): ");
                userAnswers += answer.ToString();
                Console.WriteLine();
            }
            return userAnswers;
        }

        int ProcessOpinion(string question)
        {
            int answer = 0;
            Console.Write(question);
            while (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 3)
            {
                Console.WriteLine("That's not a valid answer!");
                Console.Write(question);
            }
            return answer;
        }

        List<Premise> ReadPremises(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<Premise> premises = new List<Premise>();

            while(!reader.EndOfStream)
            {
                Premise premise = new Premise();
                premise.title = reader.ReadLine();
                premise.text = reader.ReadLine();
                premises.Add(premise);
            }
            return premises;
        }

        List<Party> ReadParties(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            List<Party> parties = new List<Party>();

            while (!reader.EndOfStream)
            {
                Party party = new Party();
                party.name = reader.ReadLine();
                party.answers = reader.ReadLine();
                parties.Add(party);
            }
            return parties;
        }
    }
}
