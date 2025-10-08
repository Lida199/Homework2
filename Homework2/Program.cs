using System.IO.Compression;
using System.Text.Json;
using System;
using System.IO;

ModernFurnitureFactory modernFurniture = new ModernFurnitureFactory();
Client furnitureClient = new Client(modernFurniture);
furnitureClient.Sofa.GetStyle();


Actor actor1 = new StuntActor();
actor1.Act("action");
actor1.Act("romance");

ReportFacade report = new ReportFacade();
report.ReportBuilder("pdf", "header", "body", "footer");
report.ReportBuilder("html", "header", "body", "footer");

ProcessFiles jsonProcessor = new ProcessFiles(new JsonFiles());
jsonProcessor.ProcessFile(@"C:\Users\lidashubitidze\source\repos\Homeworks\Homework2\testing.json");

#region Exercise 1 - Abstract Factory
// ინტერფეისები აბსტრაქტული კლასებისთვის
public interface IChair
{
    void HasLegs();
    void SitOn();
}

public interface ISofa
{
    void GetStyle();
    void NumberOfPeople();
}

public interface ICoffeeTable
{
    void GetNumberOfLegs();
    void IsWooden();
}

public interface IFurnitureFactory
{
    IChair CreateChair();
    ICoffeeTable CreateCoffeeTable();
    ISofa CreateSofa();
}

// კონკრეტული კლასები
public class ModernChair : IChair
{
    public void HasLegs() {
        Console.WriteLine("Modern Chair Has 3 Legs");
     }

    public void SitOn()
    {
        Console.WriteLine("You Cannot Sit On Modern Chair");
    }
}

public class VictorianChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("Victorian Chair Has 4 Legs");
    }

    public void SitOn()
    {
        Console.WriteLine("You Can Sit On Victorian Chair");

    }
}

public class ArtDecoChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("ArtDeco Chair Has No Legs");
    }

    public void SitOn()
    {
        Console.WriteLine("You Cannot Sit On ArtDeco Chair");

    }
}

public class ModernSofa : ISofa
{
    public void GetStyle()
    {
        Console.WriteLine("Modern Style Sofa");
    }

    public void NumberOfPeople()
    {
        Console.WriteLine("1 Person Can Sit On Modern Sofa");
    }
}

public class VictorianSofa : ISofa
{
    public void GetStyle()
    {
        Console.WriteLine("Victorian Style Sofa");
    }

    public void NumberOfPeople()
    {
        Console.WriteLine("4 Person Can Sit On Victorian Sofa");
    }
}

public class ArtDecoSofa : ISofa
{
    public void GetStyle()
    {
        Console.WriteLine("ArtDeco Style Sofa");
    }

    public void NumberOfPeople()
    {
        Console.WriteLine("No One Can Sit On ArtDeco Sofa");
    }
}

public class ModernCoffeeTable : ICoffeeTable
{
    public void GetNumberOfLegs()
    {
        Console.WriteLine("Modern Coffee Table Has 2 Legs");
    }

    public void IsWooden()
    {
        Console.WriteLine("Modern Coffee Table Is Not Wooden");
    }
}

public class VictorianCoffeeTable : ICoffeeTable
{
    public void GetNumberOfLegs()
    {
        Console.WriteLine("Victorian Coffee Table Has 4 Legs");
    }

    public void IsWooden()
    {
        Console.WriteLine("Victorian Coffee Table Is Wooden");
    }
}

public class ArtDecoCoffeeTable : ICoffeeTable
{
    public void GetNumberOfLegs()
    {
        Console.WriteLine("ArtDeco Coffee Table Has No Legs");
    }

    public void IsWooden()
    {
        Console.WriteLine("ArtDeco Coffee Table Is Wooden");
    }
}

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }
    public ICoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }
}

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }
    public ICoffeeTable CreateCoffeeTable()
    {
        return new VictorianCoffeeTable();
    }

    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }
}

public class ArtDecoFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ArtDecoChair();
    }
    public ICoffeeTable CreateCoffeeTable()
    {
        return new ArtDecoCoffeeTable();
    }

    public ISofa CreateSofa()
    {
        return new ArtDecoSofa();
    }
}

public class Client
{
    public IChair Chair;
    public ICoffeeTable CoffeeTable;
    public ISofa Sofa;

    public Client(IFurnitureFactory factory)
    {
        Chair = factory.CreateChair();
        CoffeeTable = factory.CreateCoffeeTable();
        Sofa = factory.CreateSofa();
    }
}
#endregion

#region Exercise 2 - Proxy
    public abstract class Actor
    {
        public abstract void Act(string scene);
    }
    public class RealActor : Actor
    {
        public override void Act(string scene)
        {
            Console.WriteLine($"Real Actor Performing {scene}");
        }
    }
    public class StuntActor : Actor
    {
        Actor realActor;

        public override void Act(string scene)
        {
            if (scene.Contains("action"))
            {
                Console.WriteLine($"Stunt Actor performing the dangerous scene: {scene}");
            }
            else
            {
                realActor = new RealActor();
                realActor.Act(scene);
            }
        }

    }
#endregion

#region Exercise 3 - Facade
public class ReportFacade
{
    public void ReportBuilder(string type, string header, string body, string footer)
    {
        IReportGenerator generator;
        if(type.ToUpper() == "PDF")
        {
            generator = new GeneratePDFReport();
        }else if(type.ToUpper() == "HTML")
        {
            generator=new GenerateHTMLReport();
        }else
        {
            Console.WriteLine("Invalid Type");
            return;
        }
        generator.Generate(header, body, footer);   
    }
}

public interface IReportGenerator
{
    void Generate(string header, string body, string footer);
    string GenerateHeader(string header);
    string GenerateBody(string body);
    string GenerateFooter(string footer);
}

public class GenerateHTMLReport: IReportGenerator
{
    public void Generate(string header, string body, string footer)
    {
        Console.WriteLine($"{GenerateHeader(header)}\n{GenerateBody(body)}\n{GenerateFooter(footer)}");
    }

    public string GenerateHeader(string header)
    {
        return $"<header> {header} </header>";
    }

    public string GenerateBody(string body)
    {
        return $"<body> {body} </body>";
    }

    public string GenerateFooter(string footer)
    {
        return $"<footer> {footer} </footer>";
    }
}

public class GeneratePDFReport: IReportGenerator
{
    public void Generate(string header, string body, string footer)
    {
        Console.WriteLine($"{GenerateHeader(header)}\n{GenerateBody(body)}\n{GenerateFooter(footer)}");
    }

    public string GenerateHeader(string header)
    {
        return $"Header:\n{header}";
    }

    public string GenerateBody(string body)
    {
        return $"Body:\n{body}";
    }

    public string GenerateFooter(string footer)
    {
        return $"Footer:\n{footer}";
    }
}
#endregion

#region Exercise 4 - Strategy
public class ProcessFiles
{
    IFile file;
    public ProcessFiles(IFile file)
    {
        this.file = file;
    }
    public void ProcessFile(string filePath)
    {
        file.Process(filePath);
    }
}

public interface IFile
{
    void Process(string filePath);
}

public class ZipFiles : IFile
{
    public void Process(string filePath)
    {
        string directory = Path.GetDirectoryName(filePath)!;
        string extractPath = Path.Combine(directory, "backup");

        Directory.CreateDirectory(extractPath);
        ZipFile.ExtractToDirectory(filePath, extractPath, overwriteFiles: true);
    }
}

public class JsonFiles: IFile
{
    public void Process(string filePath)
    {
        string json = File.ReadAllText(filePath);
        Console.WriteLine($"JSON Content: {json}");
    }
}

public class TextFiles : IFile
{
    public void Process(string filePath)
    {
        File.Delete(filePath);
        Console.WriteLine("TXT File deleted successfully!");
    }
}

#endregion