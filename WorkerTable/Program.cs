using System;
using Spectre.Console;
using Bogus;
using Bogus.DataSets;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int count = int.Parse(args[0]);
            Randomizer.Seed = new Random(count);
            Faker faker = new Faker("pt_PT");

            var table = new Table();

            table.AddColumn("ID");
            table.AddColumn("Name");
            table.AddColumn("Job");

            for (int i = 0; i < count; i++)
            {
                Name name = faker.Name;
                table.AddRow($"{(i + 1)}", $"{name.FirstName()} {name.LastName()}", name.JobTitle());
            }
            AnsiConsole.Write(table);
        }
    }
}
