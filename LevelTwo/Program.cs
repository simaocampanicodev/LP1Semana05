using System;
using Spectre.Console;
using Spectre.Console.ImageSharp;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "tux.jpg";
        int width = 24;

        if (args.Length >= 2)
        {
            fileName = args[0];
            if (!int.TryParse(args[1], out width) || width <= 0)
            {
                Console.WriteLine("Erro: A largura deve ser um número inteiro positivo.");
                return;
            }
        }
        try
        {
            var image = new CanvasImage(fileName);
            image.MaxWidth(width);
            AnsiConsole.Write(image);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar a imagem: {ex.Message}");
        }
    }
}